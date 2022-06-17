using demo_windapp.Controllers;
using demo_windapp.Models;

namespace demo_windapp
{
    public partial class Form1 : Form
    {
        ActionControllers action = new ActionControllers();
        EmployeeModels backup = new EmployeeModels();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pnl_data.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.pnl_data.Enabled = false;
            this.dgv_data.DataSource = action.SearchAllData();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            this.pnl_data.Enabled = true;
            this.btn_confirm.Enabled = true;
            this.btn_update.Enabled = false;
            this.btn_delete.Enabled = false;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (!condToolbox()) { return; } // condition toolbox

            EmployeeModels data = getDataInsert();
            if (action.InsertData(data) == 200)
            {
                this.dgv_data.DataSource = action.SearchAllData();
            }

            this.clearToolbox();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!condToolbox()) { return; } // condition toolbox

            EmployeeModels update = getDataUpdate();
            if (action.Update(update) == 200)
            {
                this.dgv_data.DataSource = action.SearchAllData();
            }

            this.clearToolbox();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            EmployeeModels del = new EmployeeModels { Id = backup.Id };

            if (action.Delete(del) == 200)
            {
                this.dgv_data.DataSource = action.SearchAllData();
            }

            this.clearToolbox();
        }

        private void dgv_data_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.pnl_data.Enabled = true;
            this.btn_update.Enabled = true;
            this.btn_delete.Enabled = true;
            this.btn_confirm.Enabled = false;

            int nRow = dgv_data.CurrentCell.RowIndex;
            if (nRow != -1)
            {
                backup = getDataGridView(nRow);

                this.txt_name.Text = backup.Name;
                this.txt_age.Text = backup.Age.ToString();

                if (backup.Gender == "Male")
                {
                    this.rdo_male.Checked = true;
                }
                else if (backup.Gender == "Female")
                {
                    this.rdo_female.Checked = true;
                }
            }
        }

        private bool condToolbox()
        {
            if (string.IsNullOrEmpty(this.txt_name.Text.Trim()) || !action.IsNumeric(this.txt_age.Text.Trim()) || (!this.rdo_male.Checked && !this.rdo_female.Checked))
            {
                MessageBox.Show("data not complete");
                return false;
            }
            return true;
        }
        
        private EmployeeModels getDataInsert()
        {
            EmployeeModels dataView = new EmployeeModels
            {
                Name = this.txt_name.Text.Trim(),
                Age = Convert.ToInt32(this.txt_age.Text.Trim()),
                Gender = (this.rdo_male.Checked) ? "Male" : "Female"
            };
            return dataView;
        }

        private EmployeeModels getDataUpdate()
        {
            EmployeeModels dataUpdate = new EmployeeModels
            {
                Id = backup.Id,
                Name = this.txt_name.Text.Trim(),
                Age = Convert.ToInt32(this.txt_age.Text.Trim()),
                Gender = (this.rdo_male.Checked) ? "Male" : "Female"
            };
            return dataUpdate;
        }

        private EmployeeModels getDataGridView(int nRow)
        {
            EmployeeModels dataGridView = new EmployeeModels
            {
                Id = Convert.ToInt32(dgv_data.Rows[nRow].Cells["Id"].Value),
                Name = dgv_data.Rows[nRow].Cells["Name"].Value.ToString(),
                Age = Convert.ToInt32(dgv_data.Rows[nRow].Cells["Age"].Value),
                Gender = dgv_data.Rows[nRow].Cells["Gender"].Value.ToString()
            };
            return dataGridView;
        }

        private void clearToolbox()
        {
            this.txt_name.Clear();
            this.txt_age.Clear();
            this.rdo_female.Checked = false;
            this.rdo_male.Checked = false;
        }


    }
}