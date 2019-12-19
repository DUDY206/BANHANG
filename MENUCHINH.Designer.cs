namespace BANHANG
{
    partial class MENUCHINH
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_NHAPHANG = new System.Windows.Forms.Button();
            this.btn_XUATHANG = new System.Windows.Forms.Button();
            this.btn_THONGKE = new System.Windows.Forms.Button();
            this.dgv_DanhMucHang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TEST_ = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NHAPHANG
            // 
            this.btn_NHAPHANG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NHAPHANG.Location = new System.Drawing.Point(94, 128);
            this.btn_NHAPHANG.Name = "btn_NHAPHANG";
            this.btn_NHAPHANG.Size = new System.Drawing.Size(341, 34);
            this.btn_NHAPHANG.TabIndex = 0;
            this.btn_NHAPHANG.Text = "QUAN LY NHAP HANG";
            this.btn_NHAPHANG.UseVisualStyleBackColor = true;
            this.btn_NHAPHANG.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_XUATHANG
            // 
            this.btn_XUATHANG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XUATHANG.Location = new System.Drawing.Point(94, 178);
            this.btn_XUATHANG.Name = "btn_XUATHANG";
            this.btn_XUATHANG.Size = new System.Drawing.Size(341, 34);
            this.btn_XUATHANG.TabIndex = 1;
            this.btn_XUATHANG.Text = "QUAN LY XUAT HANG";
            this.btn_XUATHANG.UseVisualStyleBackColor = true;
            this.btn_XUATHANG.Click += new System.EventHandler(this.btn_XUATHANG_Click);
            // 
            // btn_THONGKE
            // 
            this.btn_THONGKE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_THONGKE.Location = new System.Drawing.Point(94, 228);
            this.btn_THONGKE.Name = "btn_THONGKE";
            this.btn_THONGKE.Size = new System.Drawing.Size(341, 34);
            this.btn_THONGKE.TabIndex = 2;
            this.btn_THONGKE.Text = "THONG KE HANG HOA";
            this.btn_THONGKE.UseVisualStyleBackColor = true;
            this.btn_THONGKE.Click += new System.EventHandler(this.btn_THONGKE_Click);
            // 
            // dgv_DanhMucHang
            // 
            this.dgv_DanhMucHang.AllowUserToAddRows = false;
            this.dgv_DanhMucHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhMucHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_DanhMucHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_DanhMucHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhMucHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_DanhMucHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhMucHang.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_DanhMucHang.GridColor = System.Drawing.SystemColors.Menu;
            this.dgv_DanhMucHang.Location = new System.Drawing.Point(72, 296);
            this.dgv_DanhMucHang.Name = "dgv_DanhMucHang";
            this.dgv_DanhMucHang.ReadOnly = true;
            this.dgv_DanhMucHang.RowHeadersVisible = false;
            this.dgv_DanhMucHang.Size = new System.Drawing.Size(389, 71);
            this.dgv_DanhMucHang.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(94, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "QUAN LY MAT HANG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TEST_
            // 
            this.TEST_.AutoSize = true;
            this.TEST_.Location = new System.Drawing.Point(27, 24);
            this.TEST_.Name = "TEST_";
            this.TEST_.Size = new System.Drawing.Size(35, 13);
            this.TEST_.TabIndex = 5;
            this.TEST_.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MENUCHINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 379);
            this.Controls.Add(this.TEST_);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_DanhMucHang);
            this.Controls.Add(this.btn_THONGKE);
            this.Controls.Add(this.btn_XUATHANG);
            this.Controls.Add(this.btn_NHAPHANG);
            this.Name = "MENUCHINH";
            this.Text = "MENUCHINH";
            this.Load += new System.EventHandler(this.MENUCHINH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NHAPHANG;
        private System.Windows.Forms.Button btn_XUATHANG;
        private System.Windows.Forms.Button btn_THONGKE;
        private System.Windows.Forms.DataGridView dgv_DanhMucHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TEST_;
        private System.Windows.Forms.Timer timer1;
    }
}