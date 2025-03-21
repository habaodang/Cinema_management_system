namespace GUI
{
    partial class addMovieForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            addMovies_showPnl = new Panel();
            addMovies_showDGV = new DataGridView();
            addMovies_allMovieLbl = new Label();
            addMovies_controlPnl = new Panel();
            addMovies_clearBtn = new Button();
            addMovies_deleteBtn = new Button();
            addMovies_updateBtn = new Button();
            addMovies_addBtn = new Button();
            addMovies_capacityTxt = new TextBox();
            label6 = new Label();
            addMovies_importBtn = new Button();
            panel3 = new Panel();
            addMovies_PictBox = new PictureBox();
            addMovies_priceTxt = new TextBox();
            label5 = new Label();
            addMovies_genreCmbBox = new ComboBox();
            label4 = new Label();
            addMovies_movieNameTxt = new TextBox();
            label3 = new Label();
            addMovies_movieIDTxt = new TextBox();
            label2 = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            imageList3 = new ImageList(components);
            addMovies_showPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addMovies_showDGV).BeginInit();
            addMovies_controlPnl.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addMovies_PictBox).BeginInit();
            SuspendLayout();
            // 
            // addMovies_showPnl
            // 
            addMovies_showPnl.BackColor = Color.FromArgb(16, 24, 43);
            addMovies_showPnl.Controls.Add(addMovies_showDGV);
            addMovies_showPnl.Controls.Add(addMovies_allMovieLbl);
            addMovies_showPnl.Location = new Point(23, 24);
            addMovies_showPnl.Name = "addMovies_showPnl";
            addMovies_showPnl.Size = new Size(995, 263);
            addMovies_showPnl.TabIndex = 0;
            // 
            // addMovies_showDGV
            // 
            addMovies_showDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addMovies_showDGV.Location = new Point(24, 47);
            addMovies_showDGV.Name = "addMovies_showDGV";
            addMovies_showDGV.Size = new Size(958, 188);
            addMovies_showDGV.TabIndex = 1;
            addMovies_showDGV.CellContentClick += addMovies_showDGV_CellContentClick;
            // 
            // addMovies_allMovieLbl
            // 
            addMovies_allMovieLbl.AutoSize = true;
            addMovies_allMovieLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMovies_allMovieLbl.ForeColor = Color.White;
            addMovies_allMovieLbl.Location = new Point(12, 16);
            addMovies_allMovieLbl.Name = "addMovies_allMovieLbl";
            addMovies_allMovieLbl.Size = new Size(91, 25);
            addMovies_allMovieLbl.TabIndex = 0;
            addMovies_allMovieLbl.Text = "All Movie";
            // 
            // addMovies_controlPnl
            // 
            addMovies_controlPnl.BackColor = Color.FromArgb(16, 24, 43);
            addMovies_controlPnl.Controls.Add(addMovies_clearBtn);
            addMovies_controlPnl.Controls.Add(addMovies_deleteBtn);
            addMovies_controlPnl.Controls.Add(addMovies_updateBtn);
            addMovies_controlPnl.Controls.Add(addMovies_addBtn);
            addMovies_controlPnl.Controls.Add(addMovies_capacityTxt);
            addMovies_controlPnl.Controls.Add(label6);
            addMovies_controlPnl.Controls.Add(addMovies_importBtn);
            addMovies_controlPnl.Controls.Add(panel3);
            addMovies_controlPnl.Controls.Add(addMovies_priceTxt);
            addMovies_controlPnl.Controls.Add(label5);
            addMovies_controlPnl.Controls.Add(addMovies_genreCmbBox);
            addMovies_controlPnl.Controls.Add(label4);
            addMovies_controlPnl.Controls.Add(addMovies_movieNameTxt);
            addMovies_controlPnl.Controls.Add(label3);
            addMovies_controlPnl.Controls.Add(addMovies_movieIDTxt);
            addMovies_controlPnl.Controls.Add(label2);
            addMovies_controlPnl.ForeColor = Color.White;
            addMovies_controlPnl.Location = new Point(23, 308);
            addMovies_controlPnl.Name = "addMovies_controlPnl";
            addMovies_controlPnl.Size = new Size(995, 371);
            addMovies_controlPnl.TabIndex = 1;
            // 
            // addMovies_clearBtn
            // 
            addMovies_clearBtn.BackColor = Color.FromArgb(50, 33, 86);
            addMovies_clearBtn.Cursor = Cursors.Hand;
            addMovies_clearBtn.FlatStyle = FlatStyle.Flat;
            addMovies_clearBtn.Font = new Font("Segoe UI", 12F);
            addMovies_clearBtn.ForeColor = Color.White;
            addMovies_clearBtn.Location = new Point(646, 268);
            addMovies_clearBtn.Name = "addMovies_clearBtn";
            addMovies_clearBtn.Size = new Size(96, 40);
            addMovies_clearBtn.TabIndex = 18;
            addMovies_clearBtn.Text = "CLEAR";
            addMovies_clearBtn.UseVisualStyleBackColor = false;
            // 
            // addMovies_deleteBtn
            // 
            addMovies_deleteBtn.BackColor = Color.FromArgb(50, 33, 86);
            addMovies_deleteBtn.FlatStyle = FlatStyle.Flat;
            addMovies_deleteBtn.Font = new Font("Segoe UI", 12F);
            addMovies_deleteBtn.ForeColor = Color.White;
            addMovies_deleteBtn.Location = new Point(510, 268);
            addMovies_deleteBtn.Name = "addMovies_deleteBtn";
            addMovies_deleteBtn.Size = new Size(96, 40);
            addMovies_deleteBtn.TabIndex = 17;
            addMovies_deleteBtn.Text = "DELETE";
            addMovies_deleteBtn.UseVisualStyleBackColor = false;
            // 
            // addMovies_updateBtn
            // 
            addMovies_updateBtn.BackColor = Color.FromArgb(50, 33, 86);
            addMovies_updateBtn.FlatStyle = FlatStyle.Flat;
            addMovies_updateBtn.Font = new Font("Segoe UI", 12F);
            addMovies_updateBtn.ForeColor = Color.White;
            addMovies_updateBtn.Location = new Point(374, 268);
            addMovies_updateBtn.Name = "addMovies_updateBtn";
            addMovies_updateBtn.Size = new Size(96, 40);
            addMovies_updateBtn.TabIndex = 16;
            addMovies_updateBtn.Text = "UPDATE";
            addMovies_updateBtn.UseVisualStyleBackColor = false;
            // 
            // addMovies_addBtn
            // 
            addMovies_addBtn.BackColor = Color.FromArgb(50, 33, 86);
            addMovies_addBtn.Cursor = Cursors.Hand;
            addMovies_addBtn.FlatStyle = FlatStyle.Flat;
            addMovies_addBtn.Font = new Font("Segoe UI", 12F);
            addMovies_addBtn.ForeColor = Color.White;
            addMovies_addBtn.Location = new Point(238, 268);
            addMovies_addBtn.Name = "addMovies_addBtn";
            addMovies_addBtn.Size = new Size(96, 40);
            addMovies_addBtn.TabIndex = 14;
            addMovies_addBtn.Text = "ADD";
            addMovies_addBtn.UseVisualStyleBackColor = false;
            addMovies_addBtn.UseWaitCursor = true;
            // 
            // addMovies_capacityTxt
            // 
            addMovies_capacityTxt.Location = new Point(453, 129);
            addMovies_capacityTxt.Name = "addMovies_capacityTxt";
            addMovies_capacityTxt.Size = new Size(144, 23);
            addMovies_capacityTxt.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(363, 128);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 12;
            label6.Text = "Capacity";
            // 
            // addMovies_importBtn
            // 
            addMovies_importBtn.BackColor = Color.FromArgb(50, 33, 66);
            addMovies_importBtn.FlatStyle = FlatStyle.Flat;
            addMovies_importBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMovies_importBtn.ForeColor = Color.White;
            addMovies_importBtn.Location = new Point(817, 208);
            addMovies_importBtn.Name = "addMovies_importBtn";
            addMovies_importBtn.Size = new Size(115, 41);
            addMovies_importBtn.TabIndex = 11;
            addMovies_importBtn.Text = "Import";
            addMovies_importBtn.UseVisualStyleBackColor = false;
            addMovies_importBtn.Click += addMovies_importBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(addMovies_PictBox);
            panel3.Location = new Point(804, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 157);
            panel3.TabIndex = 10;
            // 
            // addMovies_PictBox
            // 
            addMovies_PictBox.BackColor = Color.White;
            addMovies_PictBox.Location = new Point(3, 3);
            addMovies_PictBox.Name = "addMovies_PictBox";
            addMovies_PictBox.Size = new Size(140, 157);
            addMovies_PictBox.TabIndex = 0;
            addMovies_PictBox.TabStop = false;
            // 
            // addMovies_priceTxt
            // 
            addMovies_priceTxt.Location = new Point(453, 91);
            addMovies_priceTxt.Name = "addMovies_priceTxt";
            addMovies_priceTxt.Size = new Size(144, 23);
            addMovies_priceTxt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(383, 90);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // addMovies_genreCmbBox
            // 
            addMovies_genreCmbBox.FormattingEnabled = true;
            addMovies_genreCmbBox.Items.AddRange(new object[] { "Education", "Comedy", "Drama", "Action", "Horror" });
            addMovies_genreCmbBox.Location = new Point(182, 163);
            addMovies_genreCmbBox.Name = "addMovies_genreCmbBox";
            addMovies_genreCmbBox.Size = new Size(144, 23);
            addMovies_genreCmbBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(112, 163);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 6;
            label4.Text = "Genre";
            // 
            // addMovies_movieNameTxt
            // 
            addMovies_movieNameTxt.Location = new Point(181, 128);
            addMovies_movieNameTxt.Name = "addMovies_movieNameTxt";
            addMovies_movieNameTxt.Size = new Size(144, 23);
            addMovies_movieNameTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(56, 128);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 4;
            label3.Text = "Movie Name";
            // 
            // addMovies_movieIDTxt
            // 
            addMovies_movieIDTxt.Location = new Point(182, 86);
            addMovies_movieIDTxt.Name = "addMovies_movieIDTxt";
            addMovies_movieIDTxt.Size = new Size(144, 23);
            addMovies_movieIDTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(88, 90);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Movie ID";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageSize = new Size(16, 16);
            imageList3.TransparentColor = Color.Transparent;
            // 
            // addMovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(addMovies_controlPnl);
            Controls.Add(addMovies_showPnl);
            Name = "addMovieForm";
            Size = new Size(1041, 698);
            Load += addMovieForm_Load;
            addMovies_showPnl.ResumeLayout(false);
            addMovies_showPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addMovies_showDGV).EndInit();
            addMovies_controlPnl.ResumeLayout(false);
            addMovies_controlPnl.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addMovies_PictBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel addMovies_showPnl;
        private Label addMovies_allMovieLbl;
        private Panel addMovies_controlPnl;
        private DataGridView addMovies_showDGV;
        private ComboBox addMovies_genreCmbBox;
        private Label label4;
        private TextBox addMovies_movieNameTxt;
        private Label label3;
        private TextBox addMovies_movieIDTxt;
        private Label label2;
        private Panel panel3;
        private PictureBox addMovies_PictBox;
        private TextBox addMovies_priceTxt;
        private Label label5;
        private ImageList imageList1;
        private ImageList imageList2;
        private ImageList imageList3;
        private Button addMovies_addBtn;
        private TextBox addMovies_capacityTxt;
        private Label label6;
        private Button addMovies_importBtn;
        private Button addMovies_clearBtn;
        private Button addMovies_deleteBtn;
        private Button addMovies_updateBtn;
    }
}
