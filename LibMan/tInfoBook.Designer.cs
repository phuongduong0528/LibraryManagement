namespace LibMan
{
    partial class tInfoBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timkiemBtn = new System.Windows.Forms.Button();
            this.quyensachDgv = new System.Windows.Forms.DataGridView();
            this.tensachTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quyensachDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 68);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SÁCH ĐANG MƯỢN";
            // 
            // timkiemBtn
            // 
            this.timkiemBtn.BackColor = System.Drawing.Color.Teal;
            this.timkiemBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiemBtn.ForeColor = System.Drawing.Color.White;
            this.timkiemBtn.Location = new System.Drawing.Point(418, 113);
            this.timkiemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.timkiemBtn.Name = "timkiemBtn";
            this.timkiemBtn.Size = new System.Drawing.Size(92, 35);
            this.timkiemBtn.TabIndex = 31;
            this.timkiemBtn.Text = "Tim kiếm";
            this.timkiemBtn.UseVisualStyleBackColor = false;
            this.timkiemBtn.Click += new System.EventHandler(this.timkiemBtn_Click);
            // 
            // dataGridView1
            // 
            this.quyensachDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.quyensachDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quyensachDgv.Location = new System.Drawing.Point(9, 175);
            this.quyensachDgv.Margin = new System.Windows.Forms.Padding(2);
            this.quyensachDgv.Name = "dataGridView1";
            this.quyensachDgv.RowTemplate.Height = 24;
            this.quyensachDgv.Size = new System.Drawing.Size(688, 216);
            this.quyensachDgv.TabIndex = 32;
            // 
            // tensachTxb
            // 
            this.tensachTxb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensachTxb.Location = new System.Drawing.Point(158, 113);
            this.tensachTxb.Margin = new System.Windows.Forms.Padding(2);
            this.tensachTxb.Name = "tensachTxb";
            this.tensachTxb.Size = new System.Drawing.Size(228, 36);
            this.tensachTxb.TabIndex = 33;
            this.tensachTxb.TextChanged += new System.EventHandler(this.tensachTxb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tInfoBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tensachTxb);
            this.Controls.Add(this.quyensachDgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timkiemBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tInfoBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê sách đang mượn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quyensachDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button timkiemBtn;
        private System.Windows.Forms.DataGridView quyensachDgv;
        private System.Windows.Forms.TextBox tensachTxb;
        private System.Windows.Forms.Label label2;
    }
}