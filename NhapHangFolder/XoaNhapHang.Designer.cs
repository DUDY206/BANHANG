namespace BANHANG.NhapHangFolder
{
    partial class XoaNhapHang
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
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_NgayNhapHang = new System.Windows.Forms.ComboBox();
            this.dgvNhapCu = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapCu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Location = new System.Drawing.Point(368, 33);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(198, 23);
            this.btn_HienThi.TabIndex = 6;
            this.btn_HienThi.Text = "HIỂN THỊ DS NHẬP HÀNG";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn ngày nhập hàng:";
            // 
            // cbx_NgayNhapHang
            // 
            this.cbx_NgayNhapHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_NgayNhapHang.FormattingEnabled = true;
            this.cbx_NgayNhapHang.Location = new System.Drawing.Point(241, 35);
            this.cbx_NgayNhapHang.Name = "cbx_NgayNhapHang";
            this.cbx_NgayNhapHang.Size = new System.Drawing.Size(121, 21);
            this.cbx_NgayNhapHang.TabIndex = 4;
            // 
            // dgvNhapCu
            // 
            this.dgvNhapCu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNhapCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapCu.Location = new System.Drawing.Point(70, 78);
            this.dgvNhapCu.Name = "dgvNhapCu";
            this.dgvNhapCu.Size = new System.Drawing.Size(292, 150);
            this.dgvNhapCu.TabIndex = 7;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(70, 246);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(292, 29);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "XOA NHẬP HÀNG";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // XoaNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 313);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dgvNhapCu);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_NgayNhapHang);
            this.Name = "XoaNhapHang";
            this.Text = "XoaNhapHang";
            this.Load += new System.EventHandler(this.XoaNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapCu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_NgayNhapHang;
        private System.Windows.Forms.DataGridView dgvNhapCu;
        private System.Windows.Forms.Button btn_Xoa;
    }
}