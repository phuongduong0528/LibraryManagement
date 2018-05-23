namespace LibMan
{
    partial class tThongKeSach
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
            this.ketquaTkDgv = new System.Windows.Forms.DataGridView();
            this.loaiThongKeCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ketquaTkDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ketquaTkDgv
            // 
            this.ketquaTkDgv.AllowUserToAddRows = false;
            this.ketquaTkDgv.AllowUserToDeleteRows = false;
            this.ketquaTkDgv.BackgroundColor = System.Drawing.Color.White;
            this.ketquaTkDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ketquaTkDgv.Location = new System.Drawing.Point(9, 44);
            this.ketquaTkDgv.Margin = new System.Windows.Forms.Padding(0);
            this.ketquaTkDgv.Name = "ketquaTkDgv";
            this.ketquaTkDgv.ReadOnly = true;
            this.ketquaTkDgv.Size = new System.Drawing.Size(928, 494);
            this.ketquaTkDgv.TabIndex = 0;
            // 
            // loaiThongKeCbx
            // 
            this.loaiThongKeCbx.FormattingEnabled = true;
            this.loaiThongKeCbx.Items.AddRange(new object[] {
            "Sách mượn nhiều",
            "Số lượng sách theo thể loại",
            "Số lượng sách theo tác giả"});
            this.loaiThongKeCbx.Location = new System.Drawing.Point(136, 9);
            this.loaiThongKeCbx.Margin = new System.Windows.Forms.Padding(0);
            this.loaiThongKeCbx.Name = "loaiThongKeCbx";
            this.loaiThongKeCbx.Size = new System.Drawing.Size(182, 29);
            this.loaiThongKeCbx.TabIndex = 1;
            this.loaiThongKeCbx.SelectedIndexChanged += new System.EventHandler(this.loaiThongKeCbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mục thống kê";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(320, 5);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 37);
            this.button5.TabIndex = 12;
            this.button5.Text = "In kết quả";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loaiThongKeCbx);
            this.Controls.Add(this.ketquaTkDgv);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tThongKeSach";
            this.Text = "tThongKeSach";
            ((System.ComponentModel.ISupportInitialize)(this.ketquaTkDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ketquaTkDgv;
        private System.Windows.Forms.ComboBox loaiThongKeCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}