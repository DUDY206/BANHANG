using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BANHANG.Xuathang_Folder;
using BANHANG.ThuTienFolder;
namespace BANHANG
{
    public partial class XUATHANG_MENU : Form
    {
        public XUATHANG_MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XUATHANG xUATHANG = new XUATHANG();
            xUATHANG.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SUA_XuatHang sUA_XuatHang = new SUA_XuatHang();
            sUA_XuatHang.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XOA_XuatHang xOA_XuatHang = new XOA_XuatHang();
            xOA_XuatHang.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HoanThanhDonCod hoanThanhDonCod = new HoanThanhDonCod();
            hoanThanhDonCod.Show();
        }
    }
}
