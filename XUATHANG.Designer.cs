namespace BANHANG
{
    partial class XUATHANG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TenNguoiGui = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TenNguoiNhan = new System.Windows.Forms.TextBox();
            this.sdtNguoiNhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_MuaHang = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.nganHang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_XUATHANG = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tongTien = new System.Windows.Forms.Label();
            this.TienCoc = new System.Windows.Forms.NumericUpDown();
            this.giamGia = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.TEST = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MuaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TienCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIEU XUAT HANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nguoi gui:";
            // 
            // TenNguoiGui
            // 
            this.TenNguoiGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TenNguoiGui.FormattingEnabled = true;
            this.TenNguoiGui.Location = new System.Drawing.Point(193, 73);
            this.TenNguoiGui.Name = "TenNguoiGui";
            this.TenNguoiGui.Size = new System.Drawing.Size(161, 21);
            this.TenNguoiGui.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nguoi nhan:";
            // 
            // TenNguoiNhan
            // 
            this.TenNguoiNhan.Location = new System.Drawing.Point(193, 127);
            this.TenNguoiNhan.Name = "TenNguoiNhan";
            this.TenNguoiNhan.Size = new System.Drawing.Size(161, 20);
            this.TenNguoiNhan.TabIndex = 5;
            // 
            // sdtNguoiNhan
            // 
            this.sdtNguoiNhan.Location = new System.Drawing.Point(193, 100);
            this.sdtNguoiNhan.Name = "sdtNguoiNhan";
            this.sdtNguoiNhan.Size = new System.Drawing.Size(161, 20);
            this.sdtNguoiNhan.TabIndex = 7;
            this.sdtNguoiNhan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SDT Nguoi nhan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dia chi:";
            // 
            // dgv_MuaHang
            // 
            this.dgv_MuaHang.AllowUserToAddRows = false;
            this.dgv_MuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MuaHang.Location = new System.Drawing.Point(389, 73);
            this.dgv_MuaHang.Name = "dgv_MuaHang";
            this.dgv_MuaHang.RowHeadersVisible = false;
            this.dgv_MuaHang.Size = new System.Drawing.Size(313, 162);
            this.dgv_MuaHang.TabIndex = 11;
            this.dgv_MuaHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MuaHang_CellEndEdit);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngân hàng:\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nganHang
            // 
            this.nganHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nganHang.FormattingEnabled = true;
            this.nganHang.Items.AddRange(new object[] {
            "TIEN MAT",
            "VietinBank",
            "VietComBank",
            "TechComBank"});
            this.nganHang.Location = new System.Drawing.Point(193, 264);
            this.nganHang.Name = "nganHang";
            this.nganHang.Size = new System.Drawing.Size(161, 21);
            this.nganHang.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giam gia:";
            // 
            // DiaChi
            // 
            this.DiaChi.Location = new System.Drawing.Point(193, 153);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(161, 82);
            this.DiaChi.TabIndex = 17;
            this.DiaChi.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "So tien:\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(193, 241);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(45, 17);
            this.cbx1.TabIndex = 19;
            this.cbx1.Text = "Cọc";
            this.cbx1.UseVisualStyleBackColor = true;
            this.cbx1.CheckedChanged += new System.EventHandler(this.cbx1_CheckedChanged);
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.Location = new System.Drawing.Point(255, 241);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(99, 17);
            this.cbx2.TabIndex = 20;
            this.cbx2.Text = "Thanh toán hết";
            this.cbx2.UseVisualStyleBackColor = true;
            this.cbx2.CheckedChanged += new System.EventHandler(this.cbx2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "PT Thanh toan";
            // 
            // btn_XUATHANG
            // 
            this.btn_XUATHANG.Location = new System.Drawing.Point(389, 267);
            this.btn_XUATHANG.Name = "btn_XUATHANG";
            this.btn_XUATHANG.Size = new System.Drawing.Size(313, 28);
            this.btn_XUATHANG.TabIndex = 22;
            this.btn_XUATHANG.Text = "XUAT HANG";
            this.btn_XUATHANG.UseVisualStyleBackColor = true;
            this.btn_XUATHANG.Click += new System.EventHandler(this.btn_XUATHANG_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(557, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tong tien:";
            // 
            // tongTien
            // 
            this.tongTien.AutoSize = true;
            this.tongTien.Location = new System.Drawing.Point(619, 241);
            this.tongTien.Name = "tongTien";
            this.tongTien.Size = new System.Drawing.Size(41, 13);
            this.tongTien.TabIndex = 24;
            this.tongTien.Text = "label11";
            // 
            // TienCoc
            // 
            this.TienCoc.Location = new System.Drawing.Point(193, 292);
            this.TienCoc.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.TienCoc.Name = "TienCoc";
            this.TienCoc.Size = new System.Drawing.Size(161, 20);
            this.TienCoc.TabIndex = 26;
            this.TienCoc.ThousandsSeparator = true;
            // 
            // giamGia
            // 
            this.giamGia.Location = new System.Drawing.Point(193, 318);
            this.giamGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.giamGia.Name = "giamGia";
            this.giamGia.Size = new System.Drawing.Size(161, 20);
            this.giamGia.TabIndex = 27;
            this.giamGia.ThousandsSeparator = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_UPDATE_Click);
            // 
            // TEST
            // 
            this.TEST.Location = new System.Drawing.Point(12, 365);
            this.TEST.Name = "TEST";
            this.TEST.Size = new System.Drawing.Size(776, 106);
            this.TEST.TabIndex = 29;
            this.TEST.Text = "";
            // 
            // XUATHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.TEST);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.giamGia);
            this.Controls.Add(this.TienCoc);
            this.Controls.Add(this.tongTien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_XUATHANG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx2);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nganHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_MuaHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sdtNguoiNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TenNguoiNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TenNguoiGui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "XUATHANG";
            this.Text = "XUATHANG";
            this.Load += new System.EventHandler(this.XUATHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MuaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TienCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TenNguoiGui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TenNguoiNhan;
        private System.Windows.Forms.TextBox sdtNguoiNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_MuaHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox nganHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox DiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbx1;
        private System.Windows.Forms.CheckBox cbx2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_XUATHANG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tongTien;
        private System.Windows.Forms.NumericUpDown TienCoc;
        private System.Windows.Forms.NumericUpDown giamGia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TEST;
    }
}