namespace CinemaManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_login_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_login_pw = new System.Windows.Forms.TextBox();
            this.login_showpw = new System.Windows.Forms.CheckBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_login_signup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(342, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 21);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÀI KHOẢN ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản, Email hoặc số điện thoại";
            // 
            // txt_login_username
            // 
            this.txt_login_username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_username.Location = new System.Drawing.Point(16, 196);
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Size = new System.Drawing.Size(341, 30);
            this.txt_login_username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_login_pw
            // 
            this.txt_login_pw.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_pw.Location = new System.Drawing.Point(16, 276);
            this.txt_login_pw.Name = "txt_login_pw";
            this.txt_login_pw.PasswordChar = '*';
            this.txt_login_pw.Size = new System.Drawing.Size(341, 30);
            this.txt_login_pw.TabIndex = 2;
            // 
            // login_showpw
            // 
            this.login_showpw.AutoSize = true;
            this.login_showpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.login_showpw.Location = new System.Drawing.Point(16, 320);
            this.login_showpw.Name = "login_showpw";
            this.login_showpw.Size = new System.Drawing.Size(113, 20);
            this.login_showpw.TabIndex = 3;
            this.login_showpw.Text = "Xem mật khẩu";
            this.login_showpw.UseVisualStyleBackColor = true;
            this.login_showpw.CheckedChanged += new System.EventHandler(this.login_showpw_CheckedChanged);
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(39)))));
            this.btlogin.FlatAppearance.BorderSize = 0;
            this.btlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.btlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.ForeColor = System.Drawing.Color.Black;
            this.btlogin.Location = new System.Drawing.Point(16, 358);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(341, 47);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "ĐĂNG NHẬP";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tạo tài khoản mới";
            // 
            // bt_login_signup
            // 
            this.bt_login_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(39)))));
            this.bt_login_signup.FlatAppearance.BorderSize = 0;
            this.bt_login_signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.bt_login_signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.bt_login_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login_signup.ForeColor = System.Drawing.Color.Black;
            this.bt_login_signup.Location = new System.Drawing.Point(12, 446);
            this.bt_login_signup.Name = "bt_login_signup";
            this.bt_login_signup.Size = new System.Drawing.Size(341, 47);
            this.bt_login_signup.TabIndex = 4;
            this.bt_login_signup.Text = "Đăng ký tại đây";
            this.bt_login_signup.UseVisualStyleBackColor = false;
            this.bt_login_signup.Click += new System.EventHandler(this.bt_login_signup_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 30);
            this.label5.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "CineVerse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(374, 582);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_login_signup);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.login_showpw);
            this.Controls.Add(this.txt_login_pw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_login_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_login_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_login_pw;
        private System.Windows.Forms.CheckBox login_showpw;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_login_signup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}

