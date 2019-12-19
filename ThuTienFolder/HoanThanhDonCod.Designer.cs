namespace BANHANG.ThuTienFolder
{
    partial class HoanThanhDonCod
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
            this.dgv_dsDonHang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sdtNguoiMua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dsDonHang
            // 
            this.dgv_dsDonHang.AllowUserToAddRows = false;
            this.dgv_dsDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsDonHang.Location = new System.Drawing.Point(25, 54);
            this.dgv_dsDonHang.Name = "dgv_dsDonHang";
            this.dgv_dsDonHang.Size = new System.Drawing.Size(744, 329);
            this.dgv_dsDonHang.TabIndex = 0;
            this.dgv_dsDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsDonHang_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "TIM KIEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sdtNguoiMua
            // 
            this.sdtNguoiMua.Location = new System.Drawing.Point(127, 15);
            this.sdtNguoiMua.Name = "sdtNguoiMua";
            this.sdtNguoiMua.Size = new System.Drawing.Size(119, 20);
            this.sdtNguoiMua.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SDT nguoi mua:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "HOAN THANH DON HANG";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HoanThanhDonCod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sdtNguoiMua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_dsDonHang);
            this.Name = "HoanThanhDonCod";
            this.Text = "HoanThanhDonCod";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dsDonHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sdtNguoiMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}