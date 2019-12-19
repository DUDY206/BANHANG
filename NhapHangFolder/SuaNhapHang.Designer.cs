namespace BANHANG.NhapHang
{
    partial class SuaNhapHang
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
            this.cbx_NgayNhapHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNhapCu = new System.Windows.Forms.DataGridView();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.dgv_Sua = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_XacNhanSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapCu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sua)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_NgayNhapHang
            // 
            this.cbx_NgayNhapHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_NgayNhapHang.FormattingEnabled = true;
            this.cbx_NgayNhapHang.Location = new System.Drawing.Point(230, 38);
            this.cbx_NgayNhapHang.Name = "cbx_NgayNhapHang";
            this.cbx_NgayNhapHang.Size = new System.Drawing.Size(121, 21);
            this.cbx_NgayNhapHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ngày nhập hàng:";
            // 
            // dgvNhapCu
            // 
            this.dgvNhapCu.AllowUserToAddRows = false;
            this.dgvNhapCu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNhapCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapCu.Location = new System.Drawing.Point(59, 104);
            this.dgvNhapCu.Name = "dgvNhapCu";
            this.dgvNhapCu.ReadOnly = true;
            this.dgvNhapCu.Size = new System.Drawing.Size(284, 150);
            this.dgvNhapCu.TabIndex = 2;
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Location = new System.Drawing.Point(357, 36);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(198, 23);
            this.btn_HienThi.TabIndex = 3;
            this.btn_HienThi.Text = "HIỂN THỊ DS NHẬP HÀNG";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // dgv_Sua
            // 
            this.dgv_Sua.AllowUserToAddRows = false;
            this.dgv_Sua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sua.Location = new System.Drawing.Point(421, 104);
            this.dgv_Sua.Name = "dgv_Sua";
            this.dgv_Sua.Size = new System.Drawing.Size(292, 150);
            this.dgv_Sua.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = ">";
            // 
            // btn_XacNhanSua
            // 
            this.btn_XacNhanSua.Location = new System.Drawing.Point(421, 283);
            this.btn_XacNhanSua.Name = "btn_XacNhanSua";
            this.btn_XacNhanSua.Size = new System.Drawing.Size(292, 29);
            this.btn_XacNhanSua.TabIndex = 6;
            this.btn_XacNhanSua.Text = "SỬA NHẬP HÀNG";
            this.btn_XacNhanSua.UseVisualStyleBackColor = true;
            this.btn_XacNhanSua.Click += new System.EventHandler(this.btn_XacNhanSua_Click);
            // 
            // SuaNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 325);
            this.Controls.Add(this.btn_XacNhanSua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Sua);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.dgvNhapCu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_NgayNhapHang);
            this.Name = "SuaNhapHang";
            this.Text = "SuaNhapHang";
            this.Load += new System.EventHandler(this.SuaNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapCu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_NgayNhapHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNhapCu;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.DataGridView dgv_Sua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XacNhanSua;
    }
}