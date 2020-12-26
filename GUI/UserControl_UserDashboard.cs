using BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_UserDashboard : UserControl {
        Form_Main father;
        DataGridView dataGridView;

        public UserControl_UserDashboard(Form_Main fMain) {
            InitializeComponent();
            father = fMain;
        }

        private void UserControl_UserDashboard_VisibleChanged(object sender, EventArgs e) {
            switch (father.Choice) {
                case 1:
                    UpdateInfo();
                    break;
                case 2:
                    FindUser();
                    break;
                case 3:
                    ListAccount();
                    break;
                case 4:
                    DeleteAccount();
                    break;
            }
        }

        private void UpdateInfo() {
            label_Title.Text = father.xuiButton_UpdateInfo.ButtonText.ToUpper();

            label_Password.Visible = true;
            label_NewPass.Visible = true;
            label_NewPassConfirm.Visible = true;
            label_Name.Visible = true;
            textBox_Password.Visible = true;
            textBox_NewPass.Visible = true;
            textBox_Confirm.Visible = true;
            textBox_Name.Visible = true;
        }

        private void FindUser() {
            label_Title.Text = father.xuiButton_FindUser.ButtonText.ToUpper();
        }

        private void ListAccount() {
            label_Title.Text = father.xuiButton_ListAccount.ButtonText.ToUpper();

            label_Password.Visible = false;
            label_NewPass.Visible = false;
            label_NewPassConfirm.Visible = false;
            label_Name.Visible = false;
            textBox_Password.Visible = false;
            textBox_NewPass.Visible = false;
            textBox_Confirm.Visible = false;
            textBox_Name.Visible = false;
            button_Save.Visible = false;
            button_Upload.Visible = false;
            pictureBox_UserPic.Visible = false;

            InitDataGridView();
            dataGridView.DataSource = AccountBUS.Instance.GetListAccount();
            panel_Footer.Controls.Add(dataGridView);
            
            
        }

        private void DeleteAccount() {
            label_Title.Text = father.xuiButton_DeleteAccount.ButtonText.ToUpper();
        }

        private void InitDataGridView() {
            this.dataGridView = new DataGridView();

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();

            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BorderStyle = BorderStyle.None;
            this.dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = DockStyle.Bottom;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new Point(0, 0);
            this.dataGridView.Margin = new Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 92;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.Height = 37;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.ScrollBars = ScrollBars.None;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new Size(650, 500);
            this.dataGridView.TabIndex = 2;
            //this.dataGridView.DataSourceChanged += new System.EventHandler(this.dataGridView_DataSourceChanged);
            //this.dataGridView.CellPainting += new DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            //this.dataGridView.VisibleChanged += new System.EventHandler(this.dataGridView_VisibleChanged);
            //this.dataGridView.MouseWheel += new MouseEventHandler(this.dataGridView_MouseWheel);
        }
    }
}
