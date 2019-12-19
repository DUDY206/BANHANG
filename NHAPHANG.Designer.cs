namespace BANHANG
{
    partial class NHAPHANG
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
            this.btn_ThemHang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_SuaNhapHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ThemHang
            // 
            this.btn_ThemHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHang.Location = new System.Drawing.Point(96, 12);
            this.btn_ThemHang.Name = "btn_ThemHang";
            this.btn_ThemHang.Size = new System.Drawing.Size(221, 41);
            this.btn_ThemHang.TabIndex = 0;
            this.btn_ThemHang.Text = "THÊM HÀNG MỚI";
            this.btn_ThemHang.UseVisualStyleBackColor = true;
            this.btn_ThemHang.Click += new System.EventHandler(this.btn_ThemHang_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(96, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "XÓA NHẬP HÀNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SuaNhapHang
            // 
            this.btn_SuaNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNhapHang.Location = new System.Drawing.Point(96, 72);
            this.btn_SuaNhapHang.Name = "btn_SuaNhapHang";
            this.btn_SuaNhapHang.Size = new System.Drawing.Size(221, 41);
            this.btn_SuaNhapHang.TabIndex = 2;
            this.btn_SuaNhapHang.Text = "SỬA NHẬP HÀNG";
            this.btn_SuaNhapHang.UseVisualStyleBackColor = true;
            this.btn_SuaNhapHang.Click += new System.EventHandler(this.btn_SuaNhapHang_Click);
            // 
            // MainOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 217);
            this.Controls.Add(this.btn_SuaNhapHang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ThemHang);
            this.Name = "MainOptions";
            this.Text = "MainOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ThemHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_SuaNhapHang;
    }
}