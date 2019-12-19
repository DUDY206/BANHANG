namespace BANHANG.Xuathang_Folder
{
    partial class SUA_XuatHang
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
            this.tenNguoiGui = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sdtNguoiMua = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten nguoi ban:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tenNguoiGui
            // 
            this.tenNguoiGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tenNguoiGui.FormattingEnabled = true;
            this.tenNguoiGui.Location = new System.Drawing.Point(140, 24);
            this.tenNguoiGui.Name = "tenNguoiGui";
            this.tenNguoiGui.Size = new System.Drawing.Size(121, 21);
            this.tenNguoiGui.TabIndex = 1;
            this.tenNguoiGui.SelectedIndexChanged += new System.EventHandler(this.tenNguoiGui_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SDT nguoi mua:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sdtNguoiMua
            // 
            this.sdtNguoiMua.Location = new System.Drawing.Point(140, 56);
            this.sdtNguoiMua.Name = "sdtNguoiMua";
            this.sdtNguoiMua.Size = new System.Drawing.Size(121, 20);
            this.sdtNguoiMua.TabIndex = 3;
            this.sdtNguoiMua.TextChanged += new System.EventHandler(this.sdtNguoiMua_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "TIM KIEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(690, 269);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // SUA_XuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sdtNguoiMua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenNguoiGui);
            this.Controls.Add(this.label1);
            this.Name = "SUA_XuatHang";
            this.Text = "SUA_XuatHang";
            this.Load += new System.EventHandler(this.SUA_XuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tenNguoiGui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sdtNguoiMua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}