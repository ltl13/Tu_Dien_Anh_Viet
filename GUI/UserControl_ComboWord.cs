using BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_ComboWord : UserControl {
        DataSet dataSet;

        public UserControl_ComboWord() {
            InitializeComponent();
            xuiButton_Back.Hide();
            dataGridView.Hide();
            lb_comboWords.Hide();
        }

        private void ResetSize(FlowLayoutPanel p) {
            if (p != flowLayoutPanel_ComboWord1) { flowLayoutPanel_ComboWord1.Size = flowLayoutPanel_ComboWord1.MinimumSize; }
            if (p != flowLayoutPanel_ComboWord2) { flowLayoutPanel_ComboWord2.Size = flowLayoutPanel_ComboWord2.MinimumSize; }
            if (p != flowLayoutPanel_ComboWord3) { flowLayoutPanel_ComboWord3.Size = flowLayoutPanel_ComboWord3.MinimumSize; }
            if (p != flowLayoutPanel_ComboWord4) { flowLayoutPanel_ComboWord4.Size = flowLayoutPanel_ComboWord4.MinimumSize; }
            if (p != flowLayoutPanel_ComboWord5) { flowLayoutPanel_ComboWord5.Size = flowLayoutPanel_ComboWord5.MinimumSize; }
        }

        #region Animal
        private void button_ComboWord1_MouseDown(object sender, MouseEventArgs e) {
            dataSet = ComboWordBUS.Instance.GetDataSet("animal");
            ResetSize(flowLayoutPanel_ComboWord1);
            if (flowLayoutPanel_ComboWord1.Size == flowLayoutPanel_ComboWord1.MaximumSize) {
                flowLayoutPanel_ComboWord1.Size = flowLayoutPanel_ComboWord1.MinimumSize;
            }
            else { flowLayoutPanel_ComboWord1.Size = flowLayoutPanel_ComboWord1.MaximumSize; }
        }

        private void button_ComboWord1_MouseEnter(object sender, EventArgs e) {
            bt_animal.FlatStyle = FlatStyle.Popup;
        }
        private void button_ComboWord1_MouseLeave(object sender, EventArgs e) {
            bt_animal.FlatStyle = FlatStyle.Flat;
        }

        private void xuiButton_Birds_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["birds"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Birds";
            lb_comboWords.Show();
        }
        private void xuiButton_insects_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["insects"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Insects";
            lb_comboWords.Show();
        }
        private void xuiButton_marines_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["marines"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Marines";
            lb_comboWords.Show();
        }
        private void xuiButton_mammals_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["mammals"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Mammals";
            lb_comboWords.Show();
        }
        private void xuiButton_breedingAnimals_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["breeding animals"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Breeding animals";
            lb_comboWords.Show();
        }
        private void xuiButton_wildAnimal_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["wild animals"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Wild animals";
            lb_comboWords.Show();
        }
        private void xuiButton_Pets_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["pets"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Pets";
            lb_comboWords.Show();
        }
        private void xuiButton_AnimalGroups_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["animal groups"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Animal groups";
            lb_comboWords.Show();
        }
        #endregion

        #region Economic&ForeignTrade
        private void button_ComboWord2_MouseDown(object sender, MouseEventArgs e) {
            ResetSize(flowLayoutPanel_ComboWord2);
            dataSet = ComboWordBUS.Instance.GetDataSet("economicAndForeignTrade");
            dataGridView.DataSource = dataSet.Tables["Economic And Foreign Trade"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Economic And Foreign Trade";
            lb_comboWords.Show();
        }

        private void button_ComboWord2_MouseEnter(object sender, EventArgs e) {
            bt_Economic_ForeignTrade.FlatStyle = FlatStyle.Popup;
        }

        private void button_ComboWord2_MouseLeave(object sender, EventArgs e) {
            bt_Economic_ForeignTrade.FlatStyle = FlatStyle.Flat;
        }
        #endregion

        #region IrregularVerbs
        private void button_ComboWord3_MouseDown(object sender, MouseEventArgs e) {
            ResetSize(flowLayoutPanel_ComboWord3);
            dataSet = ComboWordBUS.Instance.GetDataSet("irregularVerb");
            dataGridView.DataSource = dataSet.Tables["Irregular Verb"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Irregular Verb";
            lb_comboWords.Show();
        }

        private void button_ComboWord3_MouseEnter(object sender, EventArgs e) {
            bt_irregularverb.FlatStyle = FlatStyle.Popup;
        }

        private void button_ComboWord3_MouseLeave(object sender, EventArgs e) {
            bt_irregularverb.FlatStyle = FlatStyle.Flat;
        }
        #endregion

        #region InformationTechnology
        private void button_ComboWord4_MouseDown(object sender, MouseEventArgs e) {
            dataSet = ComboWordBUS.Instance.GetDataSet("it");
            ResetSize(flowLayoutPanel_ComboWord4);
            if (flowLayoutPanel_ComboWord4.Size == flowLayoutPanel_ComboWord4.MaximumSize) {
                flowLayoutPanel_ComboWord4.Size = flowLayoutPanel_ComboWord4.MinimumSize;
            }
            else { flowLayoutPanel_ComboWord4.Size = flowLayoutPanel_ComboWord4.MaximumSize; }
        }

        private void button_ComboWord4_MouseEnter(object sender, EventArgs e) {
            bt_IT.FlatStyle = FlatStyle.Popup;
        }

        private void button_ComboWord4_MouseLeave(object sender, EventArgs e) {
            bt_IT.FlatStyle = FlatStyle.Flat;
        }
        private void xuiButton_numeralSystems_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["Numeral Systems"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Numeral Systems";
            lb_comboWords.Show();
        }

        private void xuiButton_branches_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["Branches"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Branches";
            lb_comboWords.Show();
        }

        private void xuiButton_computerConstruction_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["Computer Construction"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Computer construction";
            lb_comboWords.Show();
        }

        private void xuiButton_commonWords_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["Common Words"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Common words";
            lb_comboWords.Show();
        }

        private void xuiButton_Terminologies_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["Terminologies"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Terminologies";
            lb_comboWords.Show();
        }
        #endregion

        #region Vegetables
        private void button_ComboWord5_MouseDown(object sender, MouseEventArgs e) {
            dataSet = ComboWordBUS.Instance.GetDataSet("vegetables");
            ResetSize(flowLayoutPanel_ComboWord5);
            if (flowLayoutPanel_ComboWord5.Size == flowLayoutPanel_ComboWord5.MaximumSize) {
                flowLayoutPanel_ComboWord5.Size = flowLayoutPanel_ComboWord5.MinimumSize;
            }
            else { flowLayoutPanel_ComboWord5.Size = flowLayoutPanel_ComboWord5.MaximumSize; }
        }

        private void button_ComboWord5_MouseEnter(object sender, EventArgs e) {
            bt_vegetables.FlatStyle = FlatStyle.Popup;
        }

        private void button_ComboWord5_MouseLeave(object sender, EventArgs e) {
            bt_vegetables.FlatStyle = FlatStyle.Flat;
        }

        private void xuiButton_mushrooms_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["Mushrooms"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Mushrooms";
            lb_comboWords.Show();
        }

        private void xuiButton_vegetables_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["Vegetables"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Vegetables";
            lb_comboWords.Show();
        }

        private void xuiButton_Herbs_Spices_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["Herbs and spices"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Herbs and spices";
            lb_comboWords.Show();
        }

        private void xuiButton_fruits_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables["Fruits"];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = "Fruits";
            lb_comboWords.Show();
        }
        #endregion


        private void xuiButton_Back_Click(object sender, EventArgs e) {
            dataGridView.Hide();
            xuiButton_Back.Hide();
            lb_comboWords.Hide();
        }

        void dataGridViewFormat() {
            for (int i = 0; i < dataGridView.RowCount; i++) {
                if (i % 2 == 0) {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
                else {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                }
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e) {
            dataGridView.Sort(this.dataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

            foreach (DataGridViewColumn column in dataGridView.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFormat();
        }

        private void dataGridView_MouseWheel(object sender, MouseEventArgs e) {
            if (e.Delta > 0 && dataGridView.FirstDisplayedScrollingRowIndex > 0) {
                dataGridView.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0) {
                dataGridView.FirstDisplayedScrollingRowIndex++;
            }
        }
    }
}
