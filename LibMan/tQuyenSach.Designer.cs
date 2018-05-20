namespace LibMan
{
    partial class tQuyenSach
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
            this.quyensachDgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.motaRtb = new System.Windows.Forms.RichTextBox();
            this.tinhtrangsachCbx = new System.Windows.Forms.ComboBox();
            this.tensachLbl = new System.Windows.Forms.Label();
            this.theloaiLbl = new System.Windows.Forms.Label();
            this.tacgiaLbl = new System.Windows.Forms.Label();
            this.nxbLbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quyensachDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // quyensachDgv
            // 
            this.quyensachDgv.BackgroundColor = System.Drawing.Color.White;
            this.quyensachDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quyensachDgv.Location = new System.Drawing.Point(9, 194);
            this.quyensachDgv.Margin = new System.Windows.Forms.Padding(0);
            this.quyensachDgv.Name = "quyensachDgv";
            this.quyensachDgv.Size = new System.Drawing.Size(818, 270);
            this.quyensachDgv.TabIndex = 0;
            this.quyensachDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(14, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(701, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sửa tình trạng";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // motaRtb
            // 
            this.motaRtb.Location = new System.Drawing.Point(482, 51);
            this.motaRtb.Name = "motaRtb";
            this.motaRtb.Size = new System.Drawing.Size(336, 140);
            this.motaRtb.TabIndex = 21;
            this.motaRtb.Text = "";
            // 
            // tinhtrangsachCbx
            // 
            this.tinhtrangsachCbx.FormattingEnabled = true;
            this.tinhtrangsachCbx.Items.AddRange(new object[] {
            "OK",
            "Rách",
            "Mất"});
            this.tinhtrangsachCbx.Location = new System.Drawing.Point(482, 10);
            this.tinhtrangsachCbx.Name = "tinhtrangsachCbx";
            this.tinhtrangsachCbx.Size = new System.Drawing.Size(204, 29);
            this.tinhtrangsachCbx.TabIndex = 20;
            // 
            // tensachLbl
            // 
            this.tensachLbl.AutoSize = true;
            this.tensachLbl.Location = new System.Drawing.Point(25, 90);
            this.tensachLbl.Name = "tensachLbl";
            this.tensachLbl.Size = new System.Drawing.Size(68, 21);
            this.tensachLbl.TabIndex = 22;
            this.tensachLbl.Text = "Tên sách";
            // 
            // theloaiLbl
            // 
            this.theloaiLbl.AutoSize = true;
            this.theloaiLbl.Location = new System.Drawing.Point(25, 130);
            this.theloaiLbl.Name = "theloaiLbl";
            this.theloaiLbl.Size = new System.Drawing.Size(64, 21);
            this.theloaiLbl.TabIndex = 22;
            this.theloaiLbl.Text = "Thể loại";
            // 
            // tacgiaLbl
            // 
            this.tacgiaLbl.AutoSize = true;
            this.tacgiaLbl.Location = new System.Drawing.Point(25, 170);
            this.tacgiaLbl.Name = "tacgiaLbl";
            this.tacgiaLbl.Size = new System.Drawing.Size(56, 21);
            this.tacgiaLbl.TabIndex = 22;
            this.tacgiaLbl.Text = "Tác giả";
            // 
            // nxbLbl
            // 
            this.nxbLbl.AutoSize = true;
            this.nxbLbl.Location = new System.Drawing.Point(206, 170);
            this.nxbLbl.Name = "nxbLbl";
            this.nxbLbl.Size = new System.Drawing.Size(40, 21);
            this.nxbLbl.TabIndex = 22;
            this.nxbLbl.Text = "NXB";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(113, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 29);
            this.numericUpDown1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tình trạng";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(14, 7);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 34);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thêm mới";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // tQuyenSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 473);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.nxbLbl);
            this.Controls.Add(this.tacgiaLbl);
            this.Controls.Add(this.theloaiLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tensachLbl);
            this.Controls.Add(this.motaRtb);
            this.Controls.Add(this.tinhtrangsachCbx);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quyensachDgv);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tQuyenSach";
            this.Text = "tQuyenSach";
            this.Load += new System.EventHandler(this.tQuyenSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quyensachDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView quyensachDgv;
        private System.Windows.Forms.Button xemcutheBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox motaRtb;
        private System.Windows.Forms.ComboBox tinhtrangsachCbx;
        private System.Windows.Forms.Label tensachLbl;
        private System.Windows.Forms.Label theloaiLbl;
        private System.Windows.Forms.Label tacgiaLbl;
        private System.Windows.Forms.Label nxbLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}