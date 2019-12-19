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
namespace BANHANG.NhapHang
{
    public partial class SuaNhapHang : Form
    {
        public SuaNhapHang()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        private void SuaNhapHang_Load(object sender, EventArgs e)
        {
            cbx_NgayNhapHang.DataSource = con.LayDanhSachNgayNhapHang();
            cbx_NgayNhapHang.DisplayMember = "NGAYNHAP";
            cbx_NgayNhapHang.FormatString = "MM-dd-yyyy";

        }
        DataTable dsHangNhap = new DataTable();
        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();
            DataTable dsTenHang = con.LayDanhSachHang();
            dsHangNhap = con.LayDanhSachNhapHangTheoNgay(cbx_NgayNhapHang.Text);
            dgvNhapCu.DataSource = dsHangNhap;
            dgvNhapCu.Controls[0].Enabled = true; // Index zero is the horizontal scrollbar
            dgvNhapCu.Controls[1].Enabled = true; // Index one is the vertical scrollbar
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.Name = "TEN";
            cmb.HeaderText = "TEN";
            cmb.DataSource = dsTenHang;
            cmb.DisplayMember = "TEN";
            cmb.ValueMember = "ID";
            if(dgv_Sua.Columns.Count == 0)
            {
                dgv_Sua.Columns.Add(cmb);
                dgv_Sua.Columns.Add("SOLUONG", "SOLUONG");
            }
            for(int i = 0; i < dgvNhapCu.Rows.Count && dgv_Sua.Rows.Count< dgvNhapCu.Rows.Count; i++)
            {
                dgv_Sua.Rows.Add();
                for(int j = 0;j< dsTenHang.Rows.Count; j++)
                {
                    if(dsTenHang.Rows[j]["ID"].ToString() == dgvNhapCu.Rows[i].Cells[2].Value.ToString())
                    {
                        dgv_Sua.Rows[i].Cells["TEN"].Value = j+1;
                    }
                    dgv_Sua.Rows[i].Cells[1].Value = dgvNhapCu.Rows[i].Cells[1].Value;

                }
            }
            dgv_Sua.AllowUserToAddRows = false;


            dgvNhapCu.Columns[2].Visible = false;
            dgvNhapCu.Columns[3].Visible = false;

        }

        private void btn_XacNhanSua_Click(object sender, EventArgs e)
        {
            string query = "";
            for (int i = 0; i < dsHangNhap.Rows.Count; i++)
            {
                query += "UPDATE PHIEUNHAP SET SOLUONG = "+ dgv_Sua.Rows[i].Cells[1].Value.ToString() + ", HANG_ID = " + dgv_Sua.Rows[i].Cells[0].Value.ToString() + " WHERE PHIEUNHAP.ID = " + dgvNhapCu.Rows[i].Cells[3].Value.ToString() + " \n";
            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("", "XÁC NHẬN SỬA", buttons);

            if (result == DialogResult.Yes)
            {
                con.ExecuteQuery(query);
                MessageBox.Show(query +"\n"+ "SỬA THÀNH CÔNG");
            }
        }
    }
}
