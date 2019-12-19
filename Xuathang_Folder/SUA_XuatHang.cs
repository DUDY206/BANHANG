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
namespace BANHANG.Xuathang_Folder
{
    public partial class SUA_XuatHang : Form
    {
        DataTable dsHangDaBan = new DataTable();
        DataGridView dgv_temp = new DataGridView();
        public SUA_XuatHang()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        private void SUA_XuatHang_Load(object sender, EventArgs e)
        {
            this.Controls.Add(dgv_temp);
            dgv_temp.Hide();
            tenNguoiGui.DataSource = con.LayDanhSachNguoiBan();
            tenNguoiGui.DisplayMember = "TEN";
            tenNguoiGui.ValueMember = "ID";

            dsHangDaBan = con.LayDanhSachHang();
            dgv_temp.Location = new Point(500, 0);
            dgv_temp.DataSource = dsHangDaBan;
            dgv_temp.AllowUserToAddRows = false;
            dgv_temp.Columns.Add("SOLUONG", "SO LUONG");
            dgv_temp.Columns.Add("GIABAN", "GIA BAN");
            dgv_temp.Columns[0].Visible = false;
            dgv_temp.Columns[1].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dsBanHang = new DataTable();
            if (sdtNguoiMua.Text.Trim() == "")
            {
                MessageBox.Show("Nhap sdt khach hang");
            }
            else
            {
                dsBanHang = con.GetDataInfo("SELECT BANHANG.ID,NGUOIBAN.TEN,NGUOIMUA.TEN,NGAYBAN FROM BANHANG INNER JOIN NGUOIMUA ON BANHANG.NGUOIMUA_ID = NGUOIMUA.ID INNER JOIN NGUOIBAN ON BANHANG.NGUOIBAN_ID = NGUOIBAN.ID WHERE NGUOIMUA.SDT = '" + sdtNguoiMua.Text + "' AND NGUOIBAN_ID = '" + tenNguoiGui.SelectedValue.ToString() + "' ORDER BY NGAYBAN");
                dataGridView1.DataSource = dsBanHang;

                if (dsBanHang.Rows.Count > 0)
                {
                    dataGridView1.Columns["NGAYBAN"].DefaultCellStyle.Format = "dd-MM-yyyy";
                    if (dataGridView1.Columns.Count == 4)
                    {
                        dataGridView1.Columns.Add("CHITIET", "CHI TIET");
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells["CHITIET"].Value = con.LayDanhSachHangDaBan("select hang.ten,phieuxuat.soluong from phieuxuat inner join hang on phieuxuat.hang_id = hang.id where phieuxuat.mabanhang = " + dataGridView1.Rows[i].Cells["id"].Value + "");

                    }
                    dataGridView1.Columns["CHITIET"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                else
                {
                    MessageBox.Show("Khong tim thay don hang");
                }
                
            }
            //MessageBox.Show(con.LayDanhSachHangDaBan("SELECT HANG.TEN,PHIEUXUAT.SOLUONG FROM PHIEUXUAT INNER JOIN HANG ON PHIEUXUAT.HANG_ID = HANG.ID WHERE PHIEUXUAT.MABANHANG = 4"));
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dsBanHang = new DataTable();
            dsBanHang = con.GetDataInfo("SELECT NGUOIBAN.ID,NGUOIMUA.SDT,NGUOIMUA.TEN,NGUOIMUA.DIACHI,THUTIEN.PHUONGTHUCTHANHTOAN,THUTIEN.SOTIEN,BANHANG.GIAMGIA,BANHANG.TRANGTHAI FROM BANHANG INNER JOIN NGUOIBAN ON BANHANG.NGUOIBAN_ID = NGUOIBAN.ID INNER JOIN NGUOIMUA ON BANHANG.NGUOIMUA_ID = NGUOIMUA.ID INNER JOIN THUTIEN ON BANHANG.ID = THUTIEN.BANHANG_ID WHERE THUTIEN.BANHANG_ID = " + dataGridView1.Rows[e.RowIndex].Cells["id"].Value + "");
            string idBanHang = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            string idNguoiGui = dsBanHang.Rows[0]["ID"].ToString();
            string sdtNguoiNhan_txt = dsBanHang.Rows[0]["SDT"].ToString();
            string tenNguoiNhan_txt = dsBanHang.Rows[0]["TEN"].ToString();
            string diaChiNguoiNhan = dsBanHang.Rows[0]["DIACHI"].ToString();
            string nganHang_txt = dsBanHang.Rows[0]["PHUONGTHUCTHANHTOAN"].ToString();
            string tienCoctxt = dsBanHang.Rows[0]["SOTIEN"].ToString();
            string giamGiatxt = dsBanHang.Rows[0]["GIAMGIA"].ToString();
            string trangthaibanhang = dsBanHang.Rows[0]["TRANGTHAI"].ToString();
            List<string> soLuongHangBan = new List<string>();
            List<string> giaBanHang = new List<string>();

            for (int i = 0; i < dgv_temp.Rows.Count; i++)
            {
                soLuongHangBan.Add(con.LaySoLuongHangPhieuXuat(idBanHang, dgv_temp.Rows[i].Cells["ID"].Value.ToString()));
                giaBanHang.Add(con.LayGiaHangPhieuXuat(idBanHang, dgv_temp.Rows[i].Cells["ID"].Value.ToString()));
                //MessageBox.Show(soLuongHangBan[i] + "-"+giaBanHang[i]);
            }
            XUATHANG xUATHANG = new XUATHANG(idBanHang, idNguoiGui, sdtNguoiNhan_txt, tenNguoiNhan_txt, diaChiNguoiNhan, nganHang_txt, tienCoctxt, giamGiatxt, soLuongHangBan,giaBanHang, false,trangthaibanhang);
            xUATHANG.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgv_temp.Columns.Count.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sdtNguoiMua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tenNguoiGui_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
