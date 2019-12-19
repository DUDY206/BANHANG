using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class BILL : Form
    {
        public BILL()
        {
            InitializeComponent();
        }

        public BILL(string txtnguoiGui, string txtsdtNguoiGui, string txttienCod, string txttenNguoiNhan, string txtsdtNguoiNhan, string txtdiaChiNguoiNhan)
        {
            InitializeComponent();
            nguoiGui.Text += txtnguoiGui;
            sdtNguoiGui.Text += txtsdtNguoiGui;
            tienCod.Text += txttienCod;
            tenNguoiNhan.Text += txttenNguoiNhan;
            sdtNguoiNhan.Text += txtsdtNguoiNhan;
            diaChiNguoiNhan.Text += txtdiaChiNguoiNhan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition pos = tableLayoutPanel1.GetCellPosition(button1);
            int height = tableLayoutPanel1.GetRowHeights()[pos.Row];
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(tableLayoutPanel1.Width, tableLayoutPanel1.Height- height);
            tableLayoutPanel1.DrawToBitmap(bmp, new Rectangle(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height - height));
            //pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
            printDialog1.ShowDialog();
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
