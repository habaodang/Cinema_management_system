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
using System.Runtime.InteropServices;
namespace CinemaManagementSystem
{
    public partial class RegForm : Form
    {

        string conn = @"Data Source=.;Initial Catalog=CinemaDB;Integrated Security=True";
        public RegForm()
        {
            InitializeComponent(); 
            SetWindowRounding(this.Handle);
        }
        private void SetWindowRounding(IntPtr handle)
        {
            int DWMWA_WINDOW_CORNER_PREFERENCE = 33;
            int DWMWCP_ROUND = 2;
            DwmSetWindowAttribute(handle, DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_ROUND, sizeof(int));
        }

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private void btreg_signin_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
        private void reg_ShowPw_CheckedChanged(object sender, EventArgs e)
        {
            txtnewpw.PasswordChar = reg_ShowPw.Checked ? '\0' :'*';
            txtConfirmpw.PasswordChar = reg_ShowPw.Checked ? '\0' : '*';

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btreg_Click(object sender, EventArgs e)
        {
            if (txtreg_username.Text =="" || txtnewpw.Text =="" || txtConfirmpw.Text =="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtnewpw.Text != txtConfirmpw .Text)
            {
                MessageBox.Show("Mật khẩu nhập lại phải giống mật khẩu", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtnewpw.Text.Length < 8)
            {
                MessageBox.Show("Phải có kí tự đặc biệt, hoa, thường, số và trên 8 kí tự!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string checkUsername = "SELECT * FROM USERS WHERE username = @usern";
                    using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", txtreg_username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(txtreg_username.Text.Substring(0,1).ToUpper() 
                                + txtreg_username.Text.Substring(1) + " đã tồn tại ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users( username, password,role, status, date_reg)"
                                + "VALUES(@usern, @pass,@role,@status, @date)";
                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", txtreg_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", txtnewpw.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Staff");
                                cmd.Parameters.AddWithValue("@status", "Active");
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Đăng ký thành công", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 loginForm = new Form1();
                                loginForm.Show();
                                this.Hide();

                            }
                        }
                    }
                }
            }
        }

       
    }
}
