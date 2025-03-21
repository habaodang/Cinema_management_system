using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CinemaManagementSystem
{
    public partial class Form1 : Form
    {
        string conn = @"Data Source=.;Initial Catalog=CinemaDB;Integrated Security=True";
    
        public Form1()
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

        private void bt_login_signup_Click(object sender, EventArgs e)
        {
            RegForm frm = new RegForm();
            frm.Show();
            this.Hide();

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if(Form1_username_Txt.Text == "" || Form1_pw_Txt.Text =="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else 
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
               
                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData,connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", Form1_username_Txt.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", Form1_pw_Txt.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminForm aForm = new AdminForm();
                            aForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                    }
                }
            }
        }

        private void login_showpw_CheckedChanged(object sender, EventArgs e)
        {
            Form1_pw_Txt.PasswordChar = Form1_showPw_ChkBox.Checked ? '\0' : '*';
        }

    }
}
