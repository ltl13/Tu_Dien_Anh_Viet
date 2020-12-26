using BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_UserDashboard : UserControl {
        Form_Main father;
        DataGridView dataGridView = new DataGridView();

        public UserControl_UserDashboard(Form_Main fMain) {
            InitializeComponent();
            father = fMain;
        }

        private void UserControl_UserDashboard_VisibleChanged(object sender, EventArgs e) {
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
            dataGridView.Visible = false;
            textBox_Password.UseSystemPasswordChar = true;
            label_Password.Text = "Password:";

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
            pictureBox_UserPic.Visible = true;
            button_Save.Visible = true;
            button_Upload.Visible = true;
        }

        private void FindUser() {
            label_Title.Text = father.xuiButton_FindUser.ButtonText.ToUpper();
            label_Password.Text = "Nhập ID cần tìm:";
            label_Password.Visible = true;
            textBox_Password.Visible = true;
            textBox_Password.UseSystemPasswordChar = false;
        }

        private void ListAccount() {
            label_Title.Text = father.xuiButton_ListAccount.ButtonText.ToUpper();
            this.dataGridView.Visible = true;
            this.InitDataGridView();
            panel_Footer.Controls.Add(this.dataGridView);
            this.dataGridView.DataSource = AccountBUS.Instance.GetListAccount();
        }

        private void DeleteAccount() {
            label_Title.Text = father.xuiButton_DeleteAccount.ButtonText.ToUpper();
        }

        private void InitDataGridView() {
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BorderStyle = BorderStyle.None;
            this.dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.Info;
            this.dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            this.dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.DefaultCellStyle.BackColor = Color.White;
            this.dataGridView.DefaultCellStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dataGridView.DefaultCellStyle.BackColor = SystemColors.Highlight;
            this.dataGridView.DefaultCellStyle.SelectionBackColor = Color.Black;
            this.dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView.Dock = DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new Point(0, 0);
            this.dataGridView.Margin = new Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 92;
            this.dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView.RowsDefaultCellStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dataGridView.RowsDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            this.dataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            this.dataGridView.RowTemplate.Height = 37;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.ScrollBars = ScrollBars.None;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new Size(650, 415);
            this.dataGridView.DataSourceChanged += new EventHandler(this.dataGridView_DataSourceChanged);
            this.dataGridView.MouseWheel += new MouseEventHandler(this.dataGridView_MouseWheel);
        }

        private void dataGridView_DataSourceChanged(object sender, EventArgs e) {
            foreach (DataGridViewColumn column in this.dataGridView.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.Columns[0].FillWeight = 10;
            this.dataGridView.Columns[1].FillWeight = 40;
            this.dataGridView.Columns[2].FillWeight = 50;
            this.dataGridView.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridViewFormat();
        }

        void dataGridViewFormat() {
            for (int i = 0; i < this.dataGridView.RowCount; i++) {
                if (i % 2 == 0) {
                    this.dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else {
                    this.dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void dataGridView_MouseWheel(object sender, MouseEventArgs e) {
            if (e.Delta > 0 && this.dataGridView.FirstDisplayedScrollingRowIndex > 0) {
                this.dataGridView.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0) {
                this.dataGridView.FirstDisplayedScrollingRowIndex++;
            }
        }
    }
}
