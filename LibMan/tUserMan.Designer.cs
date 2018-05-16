namespace LibMan
{
    partial class tUserMan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbTK1 = new System.Windows.Forms.TextBox();
            this.nhaplaiBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.nhapBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.danhsachDgDgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuRbt = new System.Windows.Forms.RadioButton();
            this.namRbt = new System.Windows.Forms.RadioButton();
            this.msvTxb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hanthethuvienDtp = new System.Windows.Forms.DateTimePicker();
            this.ngaysinhDtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.diachiTxb = new System.Windows.Forms.TextBox();
            this.sdtTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hotenTxb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachDgDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtbTK1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.nhaplaiBtn);
            this.groupBox2.Controls.Add(this.xoaBtn);
            this.groupBox2.Controls.Add(this.suaBtn);
            this.groupBox2.Controls.Add(this.nhapBtn);
            this.groupBox2.Location = new System.Drawing.Point(8, 202);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(930, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã độc giả",
            "Mã sinh viên",
            "Tên sinh viên"});
            this.comboBox1.Location = new System.Drawing.Point(711, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tìm kiếm";
            // 
            // txtbTK1
            // 
            this.txtbTK1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTK1.ForeColor = System.Drawing.Color.Silver;
            this.txtbTK1.Location = new System.Drawing.Point(514, 31);
            this.txtbTK1.Margin = new System.Windows.Forms.Padding(2);
            this.txtbTK1.Name = "txtbTK1";
            this.txtbTK1.Size = new System.Drawing.Size(198, 29);
            this.txtbTK1.TabIndex = 0;
            this.txtbTK1.TextChanged += new System.EventHandler(this.txtbTK1_TextChanged);
            this.txtbTK1.Enter += new System.EventHandler(this.txtbTK1_Enter);
            this.txtbTK1.Leave += new System.EventHandler(this.txtbTK1_Leave);
            // 
            // nhaplaiBtn
            // 
            this.nhaplaiBtn.BackColor = System.Drawing.Color.Teal;
            this.nhaplaiBtn.FlatAppearance.BorderSize = 0;
            this.nhaplaiBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nhaplaiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nhaplaiBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhaplaiBtn.ForeColor = System.Drawing.Color.White;
            this.nhaplaiBtn.Image = global::LibMan.Properties.Resources.if_Artboard_1_1790660;
            this.nhaplaiBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nhaplaiBtn.Location = new System.Drawing.Point(324, 21);
            this.nhaplaiBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nhaplaiBtn.Name = "nhaplaiBtn";
            this.nhaplaiBtn.Size = new System.Drawing.Size(100, 48);
            this.nhaplaiBtn.TabIndex = 13;
            this.nhaplaiBtn.Text = "Nhập lại";
            this.nhaplaiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nhaplaiBtn.UseVisualStyleBackColor = false;
            this.nhaplaiBtn.Click += new System.EventHandler(this.nhaplaiBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.BackColor = System.Drawing.Color.Teal;
            this.xoaBtn.FlatAppearance.BorderSize = 0;
            this.xoaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xoaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoaBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.ForeColor = System.Drawing.Color.White;
            this.xoaBtn.Image = global::LibMan.Properties.Resources.if_delete_file_85306;
            this.xoaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoaBtn.Location = new System.Drawing.Point(219, 21);
            this.xoaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(100, 48);
            this.xoaBtn.TabIndex = 13;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xoaBtn.UseVisualStyleBackColor = false;
            // 
            // suaBtn
            // 
            this.suaBtn.BackColor = System.Drawing.Color.Teal;
            this.suaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.suaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suaBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaBtn.ForeColor = System.Drawing.Color.White;
            this.suaBtn.Image = global::LibMan.Properties.Resources.if_compose_1055085;
            this.suaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suaBtn.Location = new System.Drawing.Point(116, 21);
            this.suaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(100, 48);
            this.suaBtn.TabIndex = 11;
            this.suaBtn.Text = "Sửa";
            this.suaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.suaBtn.UseVisualStyleBackColor = false;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click);
            // 
            // nhapBtn
            // 
            this.nhapBtn.BackColor = System.Drawing.Color.Teal;
            this.nhapBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nhapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nhapBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapBtn.ForeColor = System.Drawing.Color.White;
            this.nhapBtn.Image = global::LibMan.Properties.Resources.if_sign_add_2990683;
            this.nhapBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nhapBtn.Location = new System.Drawing.Point(14, 21);
            this.nhapBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nhapBtn.Name = "nhapBtn";
            this.nhapBtn.Size = new System.Drawing.Size(100, 48);
            this.nhapBtn.TabIndex = 9;
            this.nhapBtn.Text = "Nhập";
            this.nhapBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nhapBtn.UseVisualStyleBackColor = false;
            this.nhapBtn.Click += new System.EventHandler(this.nhapBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.danhsachDgDgv);
            this.groupBox3.Location = new System.Drawing.Point(8, 287);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(932, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // danhsachDgDgv
            // 
            this.danhsachDgDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.danhsachDgDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhsachDgDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.danhsachDgDgv.Location = new System.Drawing.Point(6, 17);
            this.danhsachDgDgv.Margin = new System.Windows.Forms.Padding(2);
            this.danhsachDgDgv.Name = "danhsachDgDgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhsachDgDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.danhsachDgDgv.RowTemplate.Height = 24;
            this.danhsachDgDgv.Size = new System.Drawing.Size(922, 229);
            this.danhsachDgDgv.TabIndex = 0;
            this.danhsachDgDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachDgDgv_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuRbt);
            this.groupBox1.Controls.Add(this.namRbt);
            this.groupBox1.Controls.Add(this.msvTxb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.hanthethuvienDtp);
            this.groupBox1.Controls.Add(this.ngaysinhDtp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.diachiTxb);
            this.groupBox1.Controls.Add(this.sdtTxb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hotenTxb);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(930, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            // 
            // nuRbt
            // 
            this.nuRbt.AutoSize = true;
            this.nuRbt.Location = new System.Drawing.Point(281, 110);
            this.nuRbt.Name = "nuRbt";
            this.nuRbt.Size = new System.Drawing.Size(49, 25);
            this.nuRbt.TabIndex = 25;
            this.nuRbt.Text = "Nữ";
            this.nuRbt.UseVisualStyleBackColor = true;
            // 
            // namRbt
            // 
            this.namRbt.AutoSize = true;
            this.namRbt.Checked = true;
            this.namRbt.Location = new System.Drawing.Point(156, 108);
            this.namRbt.Name = "namRbt";
            this.namRbt.Size = new System.Drawing.Size(62, 25);
            this.namRbt.TabIndex = 25;
            this.namRbt.TabStop = true;
            this.namRbt.Text = "Nam";
            this.namRbt.UseVisualStyleBackColor = true;
            // 
            // msvTxb
            // 
            this.msvTxb.Location = new System.Drawing.Point(587, 38);
            this.msvTxb.Margin = new System.Windows.Forms.Padding(2);
            this.msvTxb.Name = "msvTxb";
            this.msvTxb.Size = new System.Drawing.Size(302, 29);
            this.msvTxb.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mã sinh viên";
            // 
            // hanthethuvienDtp
            // 
            this.hanthethuvienDtp.CustomFormat = "dd/MM/yyyy";
            this.hanthethuvienDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hanthethuvienDtp.Location = new System.Drawing.Point(587, 110);
            this.hanthethuvienDtp.Margin = new System.Windows.Forms.Padding(2);
            this.hanthethuvienDtp.Name = "hanthethuvienDtp";
            this.hanthethuvienDtp.Size = new System.Drawing.Size(302, 29);
            this.hanthethuvienDtp.TabIndex = 22;
            this.hanthethuvienDtp.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // ngaysinhDtp
            // 
            this.ngaysinhDtp.CustomFormat = "dd/MM/yyyy";
            this.ngaysinhDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaysinhDtp.Location = new System.Drawing.Point(156, 72);
            this.ngaysinhDtp.Margin = new System.Windows.Forms.Padding(2);
            this.ngaysinhDtp.Name = "ngaysinhDtp";
            this.ngaysinhDtp.Size = new System.Drawing.Size(285, 29);
            this.ngaysinhDtp.TabIndex = 20;
            this.ngaysinhDtp.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(454, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hạn thẻ thư viện";
            // 
            // diachiTxb
            // 
            this.diachiTxb.Location = new System.Drawing.Point(156, 140);
            this.diachiTxb.Margin = new System.Windows.Forms.Padding(2);
            this.diachiTxb.Name = "diachiTxb";
            this.diachiTxb.Size = new System.Drawing.Size(285, 29);
            this.diachiTxb.TabIndex = 5;
            // 
            // sdtTxb
            // 
            this.sdtTxb.Location = new System.Drawing.Point(587, 72);
            this.sdtTxb.Margin = new System.Windows.Forms.Padding(2);
            this.sdtTxb.Name = "sdtTxb";
            this.sdtTxb.Size = new System.Drawing.Size(302, 29);
            this.sdtTxb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ tên";
            // 
            // hotenTxb
            // 
            this.hotenTxb.Location = new System.Drawing.Point(156, 36);
            this.hotenTxb.Margin = new System.Windows.Forms.Padding(2);
            this.hotenTxb.Name = "hotenTxb";
            this.hotenTxb.Size = new System.Drawing.Size(285, 29);
            this.hotenTxb.TabIndex = 0;
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
            this.button1.Location = new System.Drawing.Point(829, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tUserMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "tUserMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý độc giả";
            this.Load += new System.EventHandler(this.tUserMan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachDgDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbTK1;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button nhapBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView danhsachDgDgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker hanthethuvienDtp;
        private System.Windows.Forms.DateTimePicker ngaysinhDtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox diachiTxb;
        private System.Windows.Forms.TextBox sdtTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hotenTxb;
        private System.Windows.Forms.TextBox msvTxb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton nuRbt;
        private System.Windows.Forms.RadioButton namRbt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button nhaplaiBtn;
        private System.Windows.Forms.Button button1;
    }
}