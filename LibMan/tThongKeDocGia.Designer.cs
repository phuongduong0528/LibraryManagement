﻿namespace LibMan
{
    partial class tThongKeDocGia
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
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loaiThongKeCbx = new System.Windows.Forms.ComboBox();
            this.ketquaTkDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ketquaTkDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(320, 4);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 37);
            this.button5.TabIndex = 16;
            this.button5.Text = "In kết quả";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mục thống kê";
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
            this.loaiThongKeCbx.TabIndex = 14;
            // 
            // ketquaTkDgv
            // 
            this.ketquaTkDgv.AllowUserToAddRows = false;
            this.ketquaTkDgv.AllowUserToDeleteRows = false;
            this.ketquaTkDgv.BackgroundColor = System.Drawing.Color.White;
            this.ketquaTkDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ketquaTkDgv.Location = new System.Drawing.Point(9, 43);
            this.ketquaTkDgv.Margin = new System.Windows.Forms.Padding(0);
            this.ketquaTkDgv.Name = "ketquaTkDgv";
            this.ketquaTkDgv.ReadOnly = true;
            this.ketquaTkDgv.Size = new System.Drawing.Size(928, 495);
            this.ketquaTkDgv.TabIndex = 13;
            // 
            // tThongKeDocGia
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
            this.Name = "tThongKeDocGia";
            this.Text = "tThongKeDocGia";
            this.Load += new System.EventHandler(this.tThongKeDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ketquaTkDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox loaiThongKeCbx;
        private System.Windows.Forms.DataGridView ketquaTkDgv;
    }
}