using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL1;
namespace BANHANG
{
    public partial class QLMatHang : Form
    {
        public QLMatHang()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        private void QLMatHang_Load(object sender, EventArgs e)
        {
            dsHang.AllowUserToAddRows = false;
            dsHang.DataSource = con.GetDataInfo(" select top 10 PHIEUNHAP.ID,HANG.TEN,PHIEUNHAP.SOLUONG,NGAYNHAP,GIANHAP,GIAPHANPHOI from PHIEUNHAP INNER JOIN HANG ON HANG.ID = PHIEUNHAP.HANG_ID ORDER BY NGAYNHAP DESC");
            dsHang.Columns["ID"].Visible = false;
            dsHang.Columns["TEN"].ReadOnly = true;
            dsHang.Columns["SOLUONG"].ReadOnly = true;
            dsHang.Columns["NGAYNHAP"].ReadOnly = true;
            dsHang.Columns["NGAYNHAP"].DefaultCellStyle.Format = "dd-MM-yyyy";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "";
            for(int i = 0; i < 10; i++)
            {
                query += " UPDATE PHIEUNHAP SET GIANHAP = '" + dsHang.Rows[i].Cells["GIANHAP"].Value.ToString() + "',GIAPHANPHOI='" + dsHang.Rows[i].Cells["GIAPHANPHOI"].Value.ToString() + "' WHERE PHIEUNHAP.ID = '" + dsHang.Rows[i].Cells["ID"].Value.ToString() + "'\n";
            }
            con.ExecuteQuery(query);
            MessageBox.Show(query);
        }

        private void dsHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int num = int.Parse(dsHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (num < 0)
                {
                    MessageBox.Show("Khong duoc nhap so am");
                    dsHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                MessageBox.Show("Du lieu nhap vao khong hop le");
                dsHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
            }
        }
    }
}
