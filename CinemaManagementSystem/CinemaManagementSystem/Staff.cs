using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace CinemaManagementSystem
{
    public partial class Staff : UserControl
    {
        string conn = @"Data Source=.;Initial Catalog=CinemaDB;Integrated Security=True";
        public Staff()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            StaffData sData = new StaffData();
            List<StaffData> listData = sData.staffDataLIstData();
            dataGridView1.DataSource = listData;
        }
        private void btAdd_Staff_Click(object sender, EventArgs e)
        {
            if(isEmpty())
            {
                MessageBox.Show("Thiếu trường dữ liệu", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string selectUsername = "SELECT * FROM users WHERE username = @usern";
                    using (SqlCommand checkUsern = new SqlCommand(selectUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", txtUsername_Staff.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);

                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(txtUsername_Staff.Text.Substring(0, 1).ToUpper()
                                + txtUsername_Staff.Text.Substring(1) + " đã tồn tại ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users( username, password,role, status, date_reg)"
                                + "VALUES(@usern, @pass,@role,@status, @date)";
                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", txtUsername_Staff.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", txtPw_Staff.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Staff");
                                cmd.Parameters.AddWithValue("@status",status_Staff.SelectedItem.ToString());

                                DateTime td = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", td);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm thành công", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                btClear_Staff_Click();
                            }
                        }
                    }
                }
            }
        }
        public bool isEmpty()
        {
            if (txtUsername_Staff.Text == "" || txtPw_Staff.Text == "" || status_Staff.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID =(int)row.Cells[0].Value;
                txtUsername_Staff.Text = row.Cells[1].Value.ToString();
                txtPw_Staff.Text = row.Cells[2].Value.ToString();
                status_Staff.SelectedItem = row.Cells[3].Value.ToString();

            }
        }

        private void btUpdate_Staff_Click(object sender, EventArgs e)
        {
            if(isEmpty())
            {

            }
        }

        private void btDelete_Staff_Click(object sender, EventArgs e)
        {

        }

        private void btClear_Staff_Click()
        {
            txtUsername_Staff.Text = "";
            txtPw_Staff.Text = "";
            status_Staff.SelectedIndex = -1;
        }
    }
}
