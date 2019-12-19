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
namespace BANHANG.ThongKeFolder
{
    public partial class ThongKeHang : Form
    {
        public ThongKeHang()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        string thang;
        DataTable dsMaHang = new DataTable();
        DataTable hang = new DataTable();

        private void ThongKeHang_Load(object sender, EventArgs e)
        {
            dsMaHang = con.GetDataInfo("SELECT ID FROM HANG");
            hang.Columns.Add("TEN");
            hang.Columns.Add("SOLUONGBAN");
            hang.Columns.Add("SOLUONGCON");
            hang.Columns.Add("TIENDABAN");
            thang = DateTime.Now.ToString("MM");
            DienThongTinBang1(thang);
            DienThongTinBang2(thang);


        }
        private void DienThongTinBang2(string thang)
        {
            DataTable dsBanHang = con.LayChiTietDonBanHang(thang);
            dataGridView2.DataSource = dsBanHang;

            if (dsBanHang.Rows.Count > 0)
            {
                dataGridView2.Columns["ID"].Visible = false;
                dataGridView2.Columns["CHITIET"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView2.Columns["NGAYBAN"].DefaultCellStyle.Format = "dd-MM-yyyy";

                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                MessageBox.Show("KHONG CO DON HANG TRONG THANG");
            }
        }
        private void DienThongTinBang1(string thang)
        {
            DataTable temp = new DataTable();
            hang.Clear();
            for (int i = 0; i < dsMaHang.Rows.Count; i++)
            {
                string maHang = dsMaHang.Rows[i]["ID"].ToString();
                temp = con.GetDataInfo(" SELECT HANG.TEN,SUM(PHIEUXUAT.SOLUONG) AS SOLUONGBAN,(SELECT SOLUONG FROM HANG WHERE HANG.ID = " + maHang + ") AS SOLUONGCON,SUM(PHIEUXUAT.SOLUONG*PHIEUXUAT.GIABAN) AS SOTIENDABAN FROM BANHANG INNER JOIN PHIEUXUAT ON BANHANG.ID = PHIEUXUAT.MABANHANG INNER JOIN HANG ON PHIEUXUAT.HANG_ID = HANG.ID WHERE MONTH(BANHANG.NGAYBAN) = " + thang + " AND PHIEUXUAT.HANG_ID = " + maHang + " GROUP BY HANG.TEN");
                if (temp.Rows.Count != 0)
                {
                    hang.Rows.Add(temp.Rows[0].ItemArray);

                }
            }
            if (hang.Rows.Count != 0)
            {
                dataGridView1.DataSource = hang;
                long tong = 0;
                for(int i = 0; i < dataGridView1.Rows.Count;i++)
                {
                    tong += int.Parse(dataGridView1.Rows[i].Cells["TIENDABAN"].Value.ToString());
                    dataGridView1.Rows[i].Cells["TIENDABAN"].Value = string.Format("{0:#,#.#############################}", int.Parse(dataGridView1.Rows[i].Cells["TIENDABAN"].Value.ToString()));
                }
                test.Text = string.Format("{0:#,#.#############################}", tong);
            }
            else
            {
                MessageBox.Show("KHONG CO LICH SU MUA HANG");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DienThongTinBang1(comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DienThongTinBang2(comboBox2.Text);
        }
    }
}
