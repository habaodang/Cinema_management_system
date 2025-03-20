namespace CinemaManagementSystem
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btReport = new System.Windows.Forms.Button();
            this.btFB = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.btTicket = new System.Windows.Forms.Button();
            this.btFilm = new System.Windows.Forms.Button();
            this.btStaff = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardForm1 = new CinemaManagementSystem.DashboardForm();
            this.staff1 = new CinemaManagementSystem.Staff();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btReport);
            this.panel1.Controls.Add(this.btFB);
            this.panel1.Controls.Add(this.btUser);
            this.panel1.Controls.Add(this.btTicket);
            this.panel1.Controls.Add(this.btFilm);
            this.panel1.Controls.Add(this.btStaff);
            this.panel1.Controls.Add(this.btLogout);
            this.panel1.Controls.Add(this.btDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 751);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(260, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 53);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(772, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome, Hồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cinema Management System";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(1005, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(21, 20);
            this.Close.TabIndex = 5;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.staff1);
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(260, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 698);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CinemaManagementSystem.Properties.Resources.user_setting;
            this.pictureBox2.Location = new System.Drawing.Point(736, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btReport
            // 
            this.btReport.FlatAppearance.BorderSize = 0;
            this.btReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReport.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReport.ForeColor = System.Drawing.Color.White;
            this.btReport.Image = global::CinemaManagementSystem.Properties.Resources.report;
            this.btReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReport.Location = new System.Drawing.Point(12, 552);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(300, 44);
            this.btReport.TabIndex = 1;
            this.btReport.Text = "THỐNG KÊ, BÁO CÁO";
            this.btReport.UseVisualStyleBackColor = true;
            // 
            // btFB
            // 
            this.btFB.FlatAppearance.BorderSize = 0;
            this.btFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFB.ForeColor = System.Drawing.Color.White;
            this.btFB.Image = global::CinemaManagementSystem.Properties.Resources.fast_food__1_;
            this.btFB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFB.Location = new System.Drawing.Point(12, 485);
            this.btFB.Name = "btFB";
            this.btFB.Size = new System.Drawing.Size(276, 44);
            this.btFB.TabIndex = 1;
            this.btFB.Text = "SẢN PHẨM FB";
            this.btFB.UseVisualStyleBackColor = true;
            // 
            // btUser
            // 
            this.btUser.FlatAppearance.BorderSize = 0;
            this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUser.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUser.ForeColor = System.Drawing.Color.White;
            this.btUser.Image = global::CinemaManagementSystem.Properties.Resources.rating__1_;
            this.btUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUser.Location = new System.Drawing.Point(12, 298);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(260, 44);
            this.btUser.TabIndex = 1;
            this.btUser.Text = "NGƯỜI DÙNG";
            this.btUser.UseVisualStyleBackColor = true;
            // 
            // btTicket
            // 
            this.btTicket.FlatAppearance.BorderSize = 0;
            this.btTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTicket.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTicket.ForeColor = System.Drawing.Color.White;
            this.btTicket.Image = global::CinemaManagementSystem.Properties.Resources.movies__1_;
            this.btTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTicket.Location = new System.Drawing.Point(12, 423);
            this.btTicket.Name = "btTicket";
            this.btTicket.Size = new System.Drawing.Size(204, 44);
            this.btTicket.TabIndex = 1;
            this.btTicket.Text = "VÉ";
            this.btTicket.UseVisualStyleBackColor = true;
            // 
            // btFilm
            // 
            this.btFilm.FlatAppearance.BorderSize = 0;
            this.btFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFilm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilm.ForeColor = System.Drawing.Color.White;
            this.btFilm.Image = global::CinemaManagementSystem.Properties.Resources.film_roll;
            this.btFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFilm.Location = new System.Drawing.Point(13, 360);
            this.btFilm.Name = "btFilm";
            this.btFilm.Size = new System.Drawing.Size(247, 44);
            this.btFilm.TabIndex = 1;
            this.btFilm.Text = "PHIM";
            this.btFilm.UseVisualStyleBackColor = true;
            // 
            // btStaff
            // 
            this.btStaff.FlatAppearance.BorderSize = 0;
            this.btStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStaff.ForeColor = System.Drawing.Color.White;
            this.btStaff.Image = global::CinemaManagementSystem.Properties.Resources.teamwork;
            this.btStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStaff.Location = new System.Drawing.Point(12, 232);
            this.btStaff.Name = "btStaff";
            this.btStaff.Size = new System.Drawing.Size(276, 44);
            this.btStaff.TabIndex = 1;
            this.btStaff.Text = "NHÂN VIÊN";
            this.btStaff.UseVisualStyleBackColor = true;
            // 
            // btLogout
            // 
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Image = global::CinemaManagementSystem.Properties.Resources.logout__1_;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(12, 685);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(242, 44);
            this.btLogout.TabIndex = 1;
            this.btLogout.Text = "ĐĂNG XUẤT";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btDashboard
            // 
            this.btDashboard.FlatAppearance.BorderSize = 0;
            this.btDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.ForeColor = System.Drawing.Color.White;
            this.btDashboard.Image = global::CinemaManagementSystem.Properties.Resources.speedometer;
            this.btDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDashboard.Location = new System.Drawing.Point(12, 153);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Size = new System.Drawing.Size(260, 44);
            this.btDashboard.TabIndex = 1;
            this.btDashboard.Text = "DASHBOARD";
            this.btDashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1045, 698);
            this.dashboardForm1.TabIndex = 0;
            // 
            // staff1
            // 
            this.staff1.Location = new System.Drawing.Point(0, 0);
            this.staff1.Name = "staff1";
            this.staff1.Size = new System.Drawing.Size(1041, 698);
            this.staff1.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 751);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDashboard;
        private System.Windows.Forms.Button btFB;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btFilm;
        private System.Windows.Forms.Button btStaff;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btTicket;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Panel panel3;
        private DashboardForm dashboardForm1;
        private Staff staff1;
    }
}