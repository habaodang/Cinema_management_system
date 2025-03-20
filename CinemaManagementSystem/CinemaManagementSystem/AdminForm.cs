using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn đóng phiên làm việc không?", "Xác nhận đóng cửa sổ"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
