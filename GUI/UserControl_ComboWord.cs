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
    public partial class UserControl_ComboWord : UserControl
    {
        public UserControl_ComboWord()
        {
            InitializeComponent();
            xuiButton_Back.Hide();
            dataGridView1.Hide();
            lb_comboWords.Hide();
        }

        #region Animal
        private void button_ComboWord1_MouseDown(object sender, MouseEventArgs e)
        {
            if (flowLayoutPanel_ComboWord1.Size == flowLayoutPanel_ComboWord1.MaximumSize)
            {
                flowLayoutPanel_ComboWord1.Size = flowLayoutPanel_ComboWord1.MinimumSize;
            }
            else { flowLayoutPanel_ComboWord1.Size = flowLayoutPanel_ComboWord1.MaximumSize; }
        }

        private void button_ComboWord1_MouseEnter(object sender, EventArgs e)
        {
            bt_animal.FlatStyle = FlatStyle.Popup;
        }
        private void button_ComboWord1_MouseLeave(object sender, EventArgs e)
        {
            bt_animal.FlatStyle = FlatStyle.Flat;
        }

        private void xuiButton_Birds_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "animal" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            System.Data.DataTable dt_sheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "birds" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Birds";
            lb_comboWords.Show();
        }
        private void xuiButton_insects_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "animal" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            System.Data.DataTable dt_sheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "insects" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Insects";
            lb_comboWords.Show();
        }
        private void xuiButton_marines_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "animal" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            System.Data.DataTable dt_sheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "marines" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Marines";
            lb_comboWords.Show();
        }
        private void xuiButton_mammals_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "animal" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            System.Data.DataTable dt_sheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "mammals" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Mammals";
            lb_comboWords.Show();
        }
        private void xuiButton_breedingAnimals_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "animal" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            System.Data.DataTable dt_sheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "breeding animals" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Breeding animals";
            lb_comboWords.Show();
        }
        private void xuiButton_wildAnimal_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "animal" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            System.Data.DataTable dt_sheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "wild animals" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Wild animals";
            lb_comboWords.Show();
        }
        private void xuiButton_Pets_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "animal" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            System.Data.DataTable dt_sheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "pets" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Pets";
            lb_comboWords.Show();
        }
        private void xuiButton_AnimalGroups_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "animal" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            System.Data.DataTable dt_sheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "animal groups" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Animal groups";
            lb_comboWords.Show();
        }
        #endregion

        #region Economic&ForeignTrade
        private void button_ComboWord2_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "economicAndForeignTrade" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Economic And Foreign Trade" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Economic And Foreign Trade";
            lb_comboWords.Show();
        }

        private void button_ComboWord2_MouseEnter(object sender, EventArgs e)
        {
            bt_Economic_ForeignTrade.FlatStyle = FlatStyle.Popup;
        }

        private void button_ComboWord2_MouseLeave(object sender, EventArgs e)
        {
            bt_Economic_ForeignTrade.FlatStyle = FlatStyle.Flat;
        }
        #endregion

        #region IrregularVerbs
        private void button_ComboWord3_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "Irregular Verb" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Irregular Verb" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Irregular Verb";
            lb_comboWords.Show();
        }

        private void button_ComboWord3_MouseEnter(object sender, EventArgs e)
        {
            bt_irregularverb.FlatStyle = FlatStyle.Popup;
        }

        private void button_ComboWord3_MouseLeave(object sender, EventArgs e)
        {
            bt_irregularverb.FlatStyle = FlatStyle.Flat;
        }
        #endregion

        #region InformationTechnology
        private void button_ComboWord4_MouseDown(object sender, MouseEventArgs e)
        {
            if (flowLayoutPanel_ComboWord4.Size == flowLayoutPanel_ComboWord4.MaximumSize)
            {
                flowLayoutPanel_ComboWord4.Size = flowLayoutPanel_ComboWord4.MinimumSize;
            }
            else { flowLayoutPanel_ComboWord4.Size = flowLayoutPanel_ComboWord4.MaximumSize; }
        }

        private void button_ComboWord4_MouseEnter(object sender, EventArgs e)
        {
            bt_IT.FlatStyle = FlatStyle.Popup;
        }

        private void button_ComboWord4_MouseLeave(object sender, EventArgs e)
        {
            bt_IT.FlatStyle = FlatStyle.Flat;
        }
        private void xuiButton_numeralSystems_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "IT" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Numeral Systems" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Numeral Systems";
            lb_comboWords.Show();
        }

        private void xuiButton_branches_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "IT" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Branches" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Branches";
            lb_comboWords.Show();
        }

        private void xuiButton_computerConstruction_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "IT" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Computer Construction" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Computer construction";
            lb_comboWords.Show();
        }

        private void xuiButton_commonWords_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "IT" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Common Words" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Common words";
            lb_comboWords.Show();
        }

        private void xuiButton_Terminologies_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "IT" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Terminologies" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Terminologies";
            lb_comboWords.Show();
        }
        #endregion

        #region Vegetables
        private void button_ComboWord5_MouseDown(object sender, MouseEventArgs e)
        {
            if (flowLayoutPanel_ComboWord5.Size == flowLayoutPanel_ComboWord5.MaximumSize)
            {
                flowLayoutPanel_ComboWord5.Size = flowLayoutPanel_ComboWord5.MinimumSize;
            }
            else { flowLayoutPanel_ComboWord5.Size = flowLayoutPanel_ComboWord5.MaximumSize; }
        }

        private void button_ComboWord5_MouseEnter(object sender, EventArgs e)
        {
            bt_vegetables.FlatStyle = FlatStyle.Popup;
        }

        private void button_ComboWord5_MouseLeave(object sender, EventArgs e)
        {
            bt_vegetables.FlatStyle = FlatStyle.Flat;
        }

        private void xuiButton_mushrooms_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "Vegetable" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Mushrooms" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Mushrooms";
            lb_comboWords.Show();
        }

        private void xuiButton_vegetables_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "Vegetable" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Vegetables" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Vegetables";
            lb_comboWords.Show();
        }

        private void xuiButton_Herbs_Spices_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "Vegetable" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Herbs and spices" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Herbs and spices";
            lb_comboWords.Show();
        }

        private void xuiButton_fruits_MouseDown(object sender, MouseEventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\resources\\vocabulary\\" + "Vegetable" + ".xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);
            conn.Open();

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + "Fruits" + "$]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Fruits";
            lb_comboWords.Show();
        }
        #endregion


        private void xuiButton_Back_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            xuiButton_Back.Hide();
            lb_comboWords.Hide();
        }
    }
}
