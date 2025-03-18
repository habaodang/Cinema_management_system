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
using System.Data;
using System.Data.SqlClient;
namespace Cinema_management_system
{
    public partial class Reg_Form : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\repos\Cinema_management_system\Cinema_management_system\movie.mdf;Integrated Security=True;Connect Timeout=30";
        public Reg_Form()
        {
            InitializeComponent();
        }

        private void reg_showPass_CheckedChanged(object sender, EventArgs e)
        {
            reg_Pass.PasswordChar = reg_showPass.Checked ? '\0' : '*';
            reg_cPass.PasswordChar = reg_showPass.Checked ? '\0' : '*';
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (reg_Username.Text == "" || reg_Pass.Text == "" || reg_cPass.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reg_Pass.Text != reg_cPass.Text)
            { 
                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(reg_Pass.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                { 
                    connect.Open();
                    string checkUsername = "SELECT * FROM users WHERE Username =@usern";
                    using (SqlCommand checkUsern=new SqlCommand(checkUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", reg_Username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        { 
                            MessageBox.Show(reg_Username.Text.Substring(0, 1).ToUpper() + reg_Username.Text.Substring(1) + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users(username, password,role,status,date_reg)"+
                                "VALUES(@usern, @pass,@role,@status,@date)";
                            DateTime today = DateTime.Today;

                            using(SqlCommand cmd =new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", reg_Username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", reg_Pass.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "staff");
                                cmd.Parameters.AddWithValue("@status", "active");
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registered Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                // Khi đăng kí thành công, chuyển sang form đăng nhập// form1 là form đăng nhập
                                Form1 login = new Form1();
                                login.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // form1 là form đăng nhập//
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
