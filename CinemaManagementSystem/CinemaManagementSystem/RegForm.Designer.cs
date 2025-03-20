namespace CinemaManagementSystem
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.btreg_signin = new System.Windows.Forms.Button();
            this.btreg = new System.Windows.Forms.Button();
            this.reg_ShowPw = new System.Windows.Forms.CheckBox();
            this.txtnewpw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtreg_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmpw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btreg_signin
            // 
            this.btreg_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(39)))));
            this.btreg_signin.FlatAppearance.BorderSize = 0;
            this.btreg_signin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.btreg_signin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.btreg_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreg_signin.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreg_signin.ForeColor = System.Drawing.Color.Black;
            this.btreg_signin.Location = new System.Drawing.Point(16, 517);
            this.btreg_signin.Name = "btreg_signin";
            this.btreg_signin.Size = new System.Drawing.Size(341, 47);
            this.btreg_signin.TabIndex = 13;
            this.btreg_signin.Text = "Đăng nhập ngay";
            this.btreg_signin.UseVisualStyleBackColor = false;
            this.btreg_signin.Click += new System.EventHandler(this.btreg_signin_Click);
            // 
            // btreg
            // 
            this.btreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(39)))));
            this.btreg.FlatAppearance.BorderSize = 0;
            this.btreg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.btreg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.btreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreg.ForeColor = System.Drawing.Color.Black;
            this.btreg.Location = new System.Drawing.Point(16, 422);
            this.btreg.Name = "btreg";
            this.btreg.Size = new System.Drawing.Size(341, 47);
            this.btreg.TabIndex = 14;
            this.btreg.Text = "TẠO TÀI KHOẢN";
            this.btreg.UseVisualStyleBackColor = false;
            this.btreg.Click += new System.EventHandler(this.btreg_Click);
            // 
            // reg_ShowPw
            // 
            this.reg_ShowPw.AutoSize = true;
            this.reg_ShowPw.Location = new System.Drawing.Point(16, 387);
            this.reg_ShowPw.Name = "reg_ShowPw";
            this.reg_ShowPw.Size = new System.Drawing.Size(113, 20);
            this.reg_ShowPw.TabIndex = 12;
            this.reg_ShowPw.Text = "Xem mật khẩu";
            this.reg_ShowPw.UseVisualStyleBackColor = true;
            this.reg_ShowPw.CheckedChanged += new System.EventHandler(this.reg_ShowPw_CheckedChanged);
            // 
            // txtnewpw
            // 
            this.txtnewpw.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpw.Location = new System.Drawing.Point(15, 252);
            this.txtnewpw.Name = "txtnewpw";
            this.txtnewpw.PasswordChar = '*';
            this.txtnewpw.Size = new System.Drawing.Size(341, 30);
            this.txtnewpw.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(139, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tạo tài khoản mới";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tạo mật khẩu";
            // 
            // txtreg_username
            // 
            this.txtreg_username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreg_username.Location = new System.Drawing.Point(15, 172);
            this.txtreg_username.Name = "txtreg_username";
            this.txtreg_username.Size = new System.Drawing.Size(341, 30);
            this.txtreg_username.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tài khoản, Email hoặc số điện thoại";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "ĐĂNG KÝ TÀI KHOẢN MỚI";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(341, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 21);
            this.close.TabIndex = 9;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Xác thực mật khẩu";
            // 
            // txtConfirmpw
            // 
            this.txtConfirmpw.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmpw.Location = new System.Drawing.Point(15, 338);
            this.txtConfirmpw.Name = "txtConfirmpw";
            this.txtConfirmpw.PasswordChar = '*';
            this.txtConfirmpw.Size = new System.Drawing.Size(341, 30);
            this.txtConfirmpw.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "CineVerse";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(374, 582);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btreg_signin);
            this.Controls.Add(this.btreg);
            this.Controls.Add(this.reg_ShowPw);
            this.Controls.Add(this.txtConfirmpw);
            this.Controls.Add(this.txtnewpw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtreg_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(181)))), ((int)(((byte)(213)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btreg_signin;
        private System.Windows.Forms.Button btreg;
        private System.Windows.Forms.CheckBox reg_ShowPw;
        private System.Windows.Forms.TextBox txtnewpw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtreg_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmpw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}