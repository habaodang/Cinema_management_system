using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_management_system
{
    public partial class AddStaffForm : Form

    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";
        public AddStaffForm()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            staffData sData=new staffData();
            List<staffData> listData = sData.staffDataListData();
            dataGridView1.DataSource = listData;
        }
        private void AddStaff_addBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect=new SqlConnection(conn))
                {
                    connect.Open();
                    string selectUsername = "SELECT * FROM users WHERE username=@usern";
                    using(SqlCommand checkUsern=new SqlCommand(selectUsername,connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern",AddStaff_username.Text.Trim());
                        SqlDataAdapter adapter=new SqlDataAdapter();
                        DataTable table=new DataTable();
                        adapter.Fill(table);
                        if(table.Rows.Count>=2)
                        {
                            MessageBox.Show(AddStaff_username.Text.Substring(0, 1).ToUpper() +
                                AddStaff_username.Text.Substring(1) + "is Existing Already","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSET INTO users (username,password,role,status,dat_ref) VALUES (@usern,@pass,@role,@status,@date)";
                            using (SqlCommand cmd = new SqlCommand(insertData,connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", AddStaff_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass",AddStaff_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Staff");
                                cmd.Parameters.AddWithValue("@status", AddStaff_status.SelectedItem.ToString());
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Added Succesfull", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();

                            }
                        }
                    }
                }
            }
        }
        public bool isEmpty()
        {
            if (AddStaff_username.Text == "" || AddStaff_password.Text == "" || AddStaff_status.SelectedIndex == -1)
            {
                return true;
            }else { return false; }
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                AddStaff_username.Text = row.Cells[1].Value.ToString();
                AddStaff_password.Text = row.Cells[2].Value.ToString();
                AddStaff_status.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        private void AddStaff_updateBtn_Click(object sender, EventArgs e)
        {
            if(isEmpty())
            {
                 MessageBox.Show("Empty fields","Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure want to update id: " + getID + "?", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Error))
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();
                        string selectUsername = "SELECT * FROM users WHERE username=@usern";
                        using (SqlCommand checkUsern = new SqlCommand(selectUsername, connect))
                        {
                            checkUsern.Parameters.AddWithValue("@usern", AddStaff_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                            DataTable table = new DataTable();

                            adapter.Fill(table);
                            if (table.Rows.Count >= 2)
                            {
                                MessageBox.Show(AddStaff_username.Text.Substring(0, 1).ToUpper() +
                                   AddStaff_username.Text.Substring(1) + "is Existing Already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string updateData = "UPDATE users SET username=@usern,password=@pass,status=@status WHERE id=@id";
                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", AddStaff_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", AddStaff_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", AddStaff_status.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@id", getID);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Update Succesfull", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                }
                            }
                        }
                    }

                }
                   
            }

        }
        public void clearFields()
        {
            AddStaff_username.Text = "";
            AddStaff_password.Text = "";
            AddStaff_status.SelectedIndex = -1;
        }

        private void AddStaff_deleteBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Empty fields","Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect=new SqlConnection(conn))
                {
                    connect.Open();
                    string updateData = "UPDATE users SET status=@status WHERE id=@id";
                    using(SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Deleted");
                        cmd.Parameters.AddWithValue("@id", getID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Deleted successfull","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        clearFields();
                    }
                }
            }
        }

        private void AddStaff_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
