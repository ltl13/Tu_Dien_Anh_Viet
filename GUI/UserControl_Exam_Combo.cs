using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GUI
{
    public partial class UserControl_Exam_Combo : UserControl
    {
        private UserControl_Exam_Do doExam;
        private UserControl_Exam father;
        

        public UserControl_Exam_Combo(UserControl_Exam previous)
        {
            InitializeComponent();
            Father = previous;
        }
         
        public UserControl_Exam_Do DoExam { get => doExam; set => doExam = value; }
        public UserControl_Exam Father { get => father; set => father = value; }

        private void xuiButton_Start_Click(object sender, EventArgs e)
        {
            father.Time = Int32.Parse(metroTextBox_Time.Text);
            father.Number = Int32.Parse(metroTextBox_Number.Text);

            doExam = new UserControl_Exam_Do(father,true);
            Father.Father.panel_Main.Controls.Add(doExam);
            DoExam.BringToFront();
        }

        private void comboBox_Main_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox_Branch.Items.Clear();

            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\Exam\\" + comboBox_Main.SelectedItem.ToString() + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);

            conn.Open();
            DataTable dt_sheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            String[] excelSheets = new String[dt_sheet.Rows.Count];
            int i = 0;

            // Add the sheet name to the string array.
            foreach (DataRow row in dt_sheet.Rows)
            {
                string sheetname = row["TABLE_NAME"].ToString();
                if (!sheetname.Contains("$'ExternalData") && !sheetname.Contains("'$ExternalData"))
                {
                    excelSheets[i] = sheetname.Substring(1, sheetname.Length - 3);
                    comboBox_Branch.Items.Add(excelSheets[i]);
                    i++;
                }
            }
        }

        private void comboBox_Branch_SelectedValueChanged(object sender, EventArgs e)
        {
            father.listQuestion.Clear();
            father.dt.Clear();

            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\Exam\\" + comboBox_Main.SelectedItem.ToString() + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + comboBox_Branch.SelectedItem.ToString() + "$]", conn);


            myDataAdapter.Fill(father.dt);

            metroTextBox_Number.WaterMark = "less than " + father.dt.Rows.Count.ToString();
        }
    }
}
