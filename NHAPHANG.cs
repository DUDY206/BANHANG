using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BANHANG.NhapHang;
using BANHANG.NhapHangFolder;
namespace BANHANG
{
    public partial class NHAPHANG : Form
    {
        public NHAPHANG()
        {
            InitializeComponent();
        }

        private void btn_ThemHang_Click(object sender, EventArgs e)
        {
            NhapHang1 formNhapHang = new NhapHang1();
            formNhapHang.Show();
        }

        private void btn_SuaNhapHang_Click(object sender, EventArgs e)
        {
            SuaNhapHang suaNhapHang = new SuaNhapHang();
            suaNhapHang.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XoaNhapHang xoaNhapHang = new XoaNhapHang();
            xoaNhapHang.Show();
        }
    }
}
