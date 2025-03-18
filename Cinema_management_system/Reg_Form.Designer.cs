namespace Cinema_management_system
{
    partial class Reg_Form
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
            this.Close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_Username = new System.Windows.Forms.TextBox();
            this.reg_Pass = new System.Windows.Forms.TextBox();
            this.reg_cPass = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.reg_showPass = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(414, 38);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 22);
            this.Close.TabIndex = 0;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "REGISTRATION FORM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm password";
            // 
            // reg_Username
            // 
            this.reg_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Username.Location = new System.Drawing.Point(59, 163);
            this.reg_Username.Name = "reg_Username";
            this.reg_Username.Size = new System.Drawing.Size(355, 28);
            this.reg_Username.TabIndex = 5;
            // 
            // reg_Pass
            // 
            this.reg_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Pass.Location = new System.Drawing.Point(59, 229);
            this.reg_Pass.Name = "reg_Pass";
            this.reg_Pass.PasswordChar = '*';
            this.reg_Pass.Size = new System.Drawing.Size(355, 28);
            this.reg_Pass.TabIndex = 6;
            // 
            // reg_cPass
            // 
            this.reg_cPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_cPass.Location = new System.Drawing.Point(59, 302);
            this.reg_cPass.Name = "reg_cPass";
            this.reg_cPass.PasswordChar = '*';
            this.reg_cPass.Size = new System.Drawing.Size(355, 28);
            this.reg_cPass.TabIndex = 7;
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.Location = new System.Drawing.Point(123, 386);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(179, 44);
            this.reg_btn.TabIndex = 8;
            this.reg_btn.Text = "REGISTER";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // reg_showPass
            // 
            this.reg_showPass.AutoSize = true;
            this.reg_showPass.Location = new System.Drawing.Point(71, 350);
            this.reg_showPass.Name = "reg_showPass";
            this.reg_showPass.Size = new System.Drawing.Size(124, 20);
            this.reg_showPass.TabIndex = 9;
            this.reg_showPass.Text = "Show password";
            this.reg_showPass.UseVisualStyleBackColor = true;
            this.reg_showPass.CheckedChanged += new System.EventHandler(this.reg_showPass_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reg_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reg_showPass);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.reg_cPass);
            this.Controls.Add(this.reg_Pass);
            this.Controls.Add(this.reg_Username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reg_Form";
            this.Text = "Reg_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reg_Username;
        private System.Windows.Forms.TextBox reg_Pass;
        private System.Windows.Forms.TextBox reg_cPass;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.CheckBox reg_showPass;
        private System.Windows.Forms.Button button1;
    }
}