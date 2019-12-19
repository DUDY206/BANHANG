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
namespace BANHANG.NhapHangFolder
{
    public partial class XoaNhapHang : Form
    {
        public XoaNhapHang()
        {
            InitializeComponent();
        }
        Connection con = new Connection();

        private void XoaNhapHang_Load(object sender, EventArgs e)
        {
            cbx_NgayNhapHang.DataSource = con.LayDanhSachNgayNhapHang();
            cbx_NgayNhapHang.DisplayMember = "NGAYNHAP";
            cbx_NgayNhapHang.FormatString = "MM-dd-yyyy";
            DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
            dgvcCheckBox.HeaderText = "Select";

            dgvNhapCu.Columns.Add(dgvcCheckBox);

        }
        DataTable dsHangNhap = new DataTable();

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            dsHangNhap = con.LayDanhSachNhapHangTheoNgay(cbx_NgayNhapHang.Text);
            dgvNhapCu.DataSource = dsHangNhap;

            dgvNhapCu.Columns[3].Visible = false;
            dgvNhapCu.Columns[4].Visible = false;


            dgvNhapCu.Columns[2].ReadOnly = true;
            dgvNhapCu.Columns[1].ReadOnly = true;
            dgvNhapCu.AllowUserToAddRows = false;
            for (int i = 0; i < dsHangNhap.Rows.Count; i++)
            {
                dgvNhapCu.Rows[i].Cells[0].Value = false;
            }


        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string query = "";
            for (int i = 0; i < dsHangNhap.Rows.Count; i++)
            {
                //MessageBox.Show(dgvNhapCu.Rows[i].Cells[0].Value.ToString());
                if ((bool)dgvNhapCu.Rows[i].Cells[0].Value == true)
                {
                    query += "DELETE FROM PHIEUNHAP WHERE PHIEUNHAP.ID = " + dgvNhapCu.Rows[i].Cells["ID"].Value.ToString() + " \n";
                }

            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("", "XÁC NHẬN XOA", buttons);

            if (result == DialogResult.Yes)
            {
                con.ExecuteQuery(query);
                MessageBox.Show(query + "\n" + "XOA THÀNH CÔNG");
            }
        }
    }

    internal class DataGGridViewCheckBoxColumn
    {
    }
}
