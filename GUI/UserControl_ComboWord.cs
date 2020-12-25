using BUS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_ComboWord : UserControl {
        DataSet dataSet;

        public UserControl_ComboWord() {
            InitializeComponent();
        }

        private void UserControl_ComboWord_Load(object sender, EventArgs e) {
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
            dataSet = ComboWordBUS.Instance.GetDataSet("Animal");
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
            dataGridView.DataSource = dataSet.Tables[xuiButton_Birds.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_Birds.ButtonText;
            lb_comboWords.Show();
        }
        private void xuiButton_insects_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_insects.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_insects.ButtonText;
            lb_comboWords.Show();
        }
        private void xuiButton_marines_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_marines.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_marines.ButtonText;
            lb_comboWords.Show();
        }
        private void xuiButton_mammals_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_marines.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_marines.ButtonText;
            lb_comboWords.Show();
        }
        private void xuiButton_breedingAnimals_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_breedingAnimals.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_breedingAnimals.ButtonText;
            lb_comboWords.Show();
        }
        private void xuiButton_wildAnimal_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_wildAnimal.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_wildAnimal.ButtonText;
            lb_comboWords.Show();
        }
        private void xuiButton_Pets_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_Pets.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_Pets.ButtonText;
            lb_comboWords.Show();
        }
        private void xuiButton_AnimalGroups_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_AnimalGroups.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_AnimalGroups.ButtonText;
            lb_comboWords.Show();
        }
        #endregion

        #region Economic&ForeignTrade
        private void button_ComboWord2_MouseDown(object sender, MouseEventArgs e) {
            ResetSize(flowLayoutPanel_ComboWord2);
            dataSet = ComboWordBUS.Instance.GetDataSet(bt_Economic_ForeignTrade.Text);
            dataGridView.DataSource = dataSet.Tables[bt_Economic_ForeignTrade.Text];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = bt_Economic_ForeignTrade.Text;
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
            dataSet = ComboWordBUS.Instance.GetDataSet("Irregular Verbs");
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
            dataSet = ComboWordBUS.Instance.GetDataSet(bt_IT.Text);
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
            dataGridView.DataSource = dataSet.Tables[xuiButton_numeralSystems.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_numeralSystems.ButtonText;
            lb_comboWords.Show();
        }

        private void xuiButton_branches_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_branches.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_branches.ButtonText;
            lb_comboWords.Show();
        }

        private void xuiButton_computerConstruction_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_computerConstruction.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_computerConstruction.ButtonText;
            lb_comboWords.Show();
        }

        private void xuiButton_commonWords_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_commonWords.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_commonWords.ButtonText;
            lb_comboWords.Show();
        }

        private void xuiButton_Terminologies_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_Terminologies.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_Terminologies.ButtonText;
            lb_comboWords.Show();
        }
        #endregion

        #region Vegetables
        private void button_ComboWord5_MouseDown(object sender, MouseEventArgs e) {
            dataSet = ComboWordBUS.Instance.GetDataSet(bt_vegetables.Text);
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
            dataGridView.DataSource = dataSet.Tables[xuiButton_mushrooms.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_mushrooms.ButtonText;
            lb_comboWords.Show();
        }

        private void xuiButton_vegetables_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_vegetables.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_vegetables.ButtonText;
            lb_comboWords.Show();
        }

        private void xuiButton_Herbs_Spices_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_Herbs_Spices.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_Herbs_Spices.ButtonText;
            lb_comboWords.Show();
        }

        private void xuiButton_fruits_MouseDown(object sender, MouseEventArgs e) {
            dataGridView.DataSource = dataSet.Tables[xuiButton_fruits.ButtonText];
            dataGridView.Show();
            xuiButton_Back.Show();
            lb_comboWords.Text = xuiButton_fruits.ButtonText;
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

        private void dataGridView_DataSourceChanged(object sender, EventArgs e) {
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

        private void dataGridView_VisibleChanged(object sender, EventArgs e) {
            if (dataGridView.Visible == true) {
                metroTextBox_Filter.Visible = true;
            }
            else {
                metroTextBox_Filter.Text = string.Empty;
                metroTextBox_Filter.Visible = false;
            }
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dataGridView.Columns[e.ColumnIndex].Name != "Id") {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(metroTextBox_Filter.Text.Trim())) {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(metroTextBox_Filter.Text.Trim().ToLower());
                    // IF search text is exists inside grid cell then startIndexInCellValue value will be greater then 0 or equal to 0  
                    if (startIndexInCellValue >= 0) {
                        e.Handled = true;
                        e.PaintBackground(e.CellBounds, true);
                        //the highlite rectangle  
                        Rectangle hl_rect = new Rectangle();
                        hl_rect.Y = e.CellBounds.Y + 2;
                        hl_rect.Height = e.CellBounds.Height - 5;
                        //find the size of the text before the search word in grid cell data.  
                        String sBeforeSearchword = gridCellValue.Substring(0, startIndexInCellValue);
                        //size of the search word in the grid cell data  
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, metroTextBox_Filter.Text.Trim().Length);
                        Size s1 = TextRenderer.MeasureText(e.Graphics, sBeforeSearchword, e.CellStyle.Font, e.CellBounds.Size);
                        Size s2 = TextRenderer.MeasureText(e.Graphics, sSearchWord, e.CellStyle.Font, e.CellBounds.Size);
                        if (s1.Width > 5) {
                            hl_rect.X = e.CellBounds.X + s1.Width - 5;
                            hl_rect.Width = s2.Width - 6;
                        }
                        else {
                            hl_rect.X = e.CellBounds.X + 2;
                            hl_rect.Width = s2.Width - 6;
                        }
                        //color for showing highlighted text in grid cell  
                        SolidBrush hl_brush;
                        hl_brush = new SolidBrush(Color.Yellow);
                        //paint the background behind the search word  
                        e.Graphics.FillRectangle(hl_brush, hl_rect);
                        hl_brush.Dispose();
                        e.PaintContent(e.CellBounds);
                    }
                }
            }
        }

        private void metroTextBox_Filter_KeyUp(object sender, KeyEventArgs e) {
            string Query = "";
            if (metroTextBox_Filter.Text != string.Empty) {
                for (int i = 0; i < dataGridView.Columns.Count - 1; i++) {
                    Query += "[" + dataGridView.Columns[i].HeaderText + "] like '%" + metroTextBox_Filter.Text.Trim() + "%' or ";
                }
                Query += "[" + dataGridView.Columns[dataGridView.Columns.Count - 1].HeaderText + "] like '%" + metroTextBox_Filter.Text.Trim() + "%'";
            }
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = Query;
            dataGridView_DataSourceChanged(sender, e);
        }
    }
}
