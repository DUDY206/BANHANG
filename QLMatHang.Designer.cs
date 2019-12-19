namespace BANHANG
{
    partial class QLMatHang
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
            this.dsHang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dsHang
            // 
            this.dsHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsHang.Location = new System.Drawing.Point(28, 41);
            this.dsHang.Name = "dsHang";
            this.dsHang.Size = new System.Drawing.Size(513, 304);
            this.dsHang.TabIndex = 0;
            this.dsHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsHang_CellEndEdit);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "XAC NHAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dsHang);
            this.Name = "QLMatHang";
            this.Text = "QLMatHang";
            this.Load += new System.EventHandler(this.QLMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsHang;
        private System.Windows.Forms.Button button1;
    }
}