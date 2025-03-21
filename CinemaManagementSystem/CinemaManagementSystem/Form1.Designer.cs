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
            this.Form1_username_Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Form1_pw_Txt = new System.Windows.Forms.TextBox();
            this.Form1_showPw_ChkBox = new System.Windows.Forms.CheckBox();
            this.Form1_Login_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Form1_sigBtn_Btn = new System.Windows.Forms.Button();
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
            this.close.Location = new System.Drawing.Point(373, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 21);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÀI KHOẢN ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản, Email hoặc số điện thoại";
            // 
            // Form1_username_Txt
            // 
            this.Form1_username_Txt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1_username_Txt.Location = new System.Drawing.Point(35, 231);
            this.Form1_username_Txt.Name = "Form1_username_Txt";
            this.Form1_username_Txt.Size = new System.Drawing.Size(341, 30);
            this.Form1_username_Txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            // 
            // Form1_pw_Txt
            // 
            this.Form1_pw_Txt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1_pw_Txt.Location = new System.Drawing.Point(35, 325);
            this.Form1_pw_Txt.Name = "Form1_pw_Txt";
            this.Form1_pw_Txt.PasswordChar = '*';
            this.Form1_pw_Txt.Size = new System.Drawing.Size(341, 30);
            this.Form1_pw_Txt.TabIndex = 2;
            // 
            // Form1_showPw_ChkBox
            // 
            this.Form1_showPw_ChkBox.AutoSize = true;
            this.Form1_showPw_ChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Form1_showPw_ChkBox.Location = new System.Drawing.Point(16, 381);
            this.Form1_showPw_ChkBox.Name = "Form1_showPw_ChkBox";
            this.Form1_showPw_ChkBox.Size = new System.Drawing.Size(113, 20);
            this.Form1_showPw_ChkBox.TabIndex = 3;
            this.Form1_showPw_ChkBox.Text = "Xem mật khẩu";
            this.Form1_showPw_ChkBox.UseVisualStyleBackColor = true;
            this.Form1_showPw_ChkBox.CheckedChanged += new System.EventHandler(this.login_showpw_CheckedChanged);
            // 
            // Form1_Login_Btn
            // 
            this.Form1_Login_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(39)))));
            this.Form1_Login_Btn.FlatAppearance.BorderSize = 0;
            this.Form1_Login_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.Form1_Login_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.Form1_Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form1_Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1_Login_Btn.ForeColor = System.Drawing.Color.Black;
            this.Form1_Login_Btn.Location = new System.Drawing.Point(35, 429);
            this.Form1_Login_Btn.Name = "Form1_Login_Btn";
            this.Form1_Login_Btn.Size = new System.Drawing.Size(341, 47);
            this.Form1_Login_Btn.TabIndex = 4;
            this.Form1_Login_Btn.Text = "ĐĂNG NHẬP";
            this.Form1_Login_Btn.UseVisualStyleBackColor = false;
            this.Form1_Login_Btn.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tạo tài khoản mới";
            // 
            // Form1_sigBtn_Btn
            // 
            this.Form1_sigBtn_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(39)))));
            this.Form1_sigBtn_Btn.FlatAppearance.BorderSize = 0;
            this.Form1_sigBtn_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.Form1_sigBtn_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.Form1_sigBtn_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form1_sigBtn_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1_sigBtn_Btn.ForeColor = System.Drawing.Color.Black;
            this.Form1_sigBtn_Btn.Location = new System.Drawing.Point(35, 531);
            this.Form1_sigBtn_Btn.Name = "Form1_sigBtn_Btn";
            this.Form1_sigBtn_Btn.Size = new System.Drawing.Size(341, 47);
            this.Form1_sigBtn_Btn.TabIndex = 4;
            this.Form1_sigBtn_Btn.Text = "Đăng ký tại đây";
            this.Form1_sigBtn_Btn.UseVisualStyleBackColor = false;
            this.Form1_sigBtn_Btn.Click += new System.EventHandler(this.bt_login_signup_Click);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(406, 617);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Form1_sigBtn_Btn);
            this.Controls.Add(this.Form1_Login_Btn);
            this.Controls.Add(this.Form1_showPw_ChkBox);
            this.Controls.Add(this.Form1_pw_Txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Form1_username_Txt);
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
        private System.Windows.Forms.TextBox Form1_username_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Form1_pw_Txt;
        private System.Windows.Forms.CheckBox Form1_showPw_ChkBox;
        private System.Windows.Forms.Button Form1_Login_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Form1_sigBtn_Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}

