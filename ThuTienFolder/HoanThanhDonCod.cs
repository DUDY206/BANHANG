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
namespace BANHANG.ThuTienFolder
{
    public partial class HoanThanhDonCod : Form
    {
        public HoanThanhDonCod()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        private void dsDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dsBanHang = new DataTable();
            if (sdtNguoiMua.Text.Trim() != "")
            {
                dsBanHang = con.GetDataInfo("SELECT BANHANG.ID,NGUOIBAN.TEN,NGUOIMUA.TEN,NGAYBAN FROM BANHANG INNER JOIN NGUOIMUA ON BANHANG.NGUOIMUA_ID = NGUOIMUA.ID INNER JOIN NGUOIBAN ON BANHANG.NGUOIBAN_ID = NGUOIBAN.ID WHERE NGUOIMUA.SDT = '"+sdtNguoiMua.Text+"' AND BANHANG.TRANGTHAI = 0");
            }
            else
            {
                dsBanHang = con.GetDataInfo("SELECT BANHANG.ID,NGUOIBAN.TEN,NGUOIMUA.TEN,NGAYBAN FROM BANHANG INNER JOIN NGUOIMUA ON BANHANG.NGUOIMUA_ID = NGUOIMUA.ID INNER JOIN NGUOIBAN ON BANHANG.NGUOIBAN_ID = NGUOIBAN.ID WHERE BANHANG.TRANGTHAI = 0");
            }
            dgv_dsDonHang.DataSource = dsBanHang;

            if (dsBanHang.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay don hang");
            }
            else
            {
                dgv_dsDonHang.DataSource = dsBanHang;
                dgv_dsDonHang.Columns["NGAYBAN"].DefaultCellStyle.Format = "dd-MM-yyyy";
                if (dgv_dsDonHang.Columns.Count == 4)
                {
                    dgv_dsDonHang.Columns.Add("CHITIET", "CHI TIET");
                }
                DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
                dgvcCheckBox.HeaderText = "HOAN TAT";
                dgvcCheckBox.Name = "XOA";

                if (dgv_dsDonHang.Columns.Count == 5)
                {
                    dgv_dsDonHang.Columns.Add(dgvcCheckBox);
                }
                for (int i = 0; i < dgv_dsDonHang.Rows.Count; i++)
                {
                    dgv_dsDonHang.Rows[i].Cells["CHITIET"].Value = con.LayDanhSachHangDaBan("select hang.ten,phieuxuat.soluong from phieuxuat inner join hang on phieuxuat.hang_id = hang.id where phieuxuat.mabanhang = " + dgv_dsDonHang.Rows[i].Cells["id"].Value + "");
                }
                dgv_dsDonHang.Columns["CHITIET"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv_dsDonHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_dsDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv_dsDonHang.Columns["ID"].ReadOnly = true;
                dgv_dsDonHang.Columns[1].ReadOnly = true;
                dgv_dsDonHang.Columns[2].ReadOnly = true;
                dgv_dsDonHang.Columns["NGAYBAN"].ReadOnly = true;
                dgv_dsDonHang.Columns["CHITIET"].ReadOnly = true;
                dgv_dsDonHang.Columns["XOA"].ReadOnly = false;

                for (int i = 0; i < dgv_dsDonHang.Rows.Count; i++)
                {
                    dgv_dsDonHang.Rows[i].Cells["XOA"].Value = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "";
            for (int i = 0; i < dgv_dsDonHang.Rows.Count; i++)
            {
                if ((bool)dgv_dsDonHang.Rows[i].Cells["XOA"].Value == true)
                {
                    string idBanHang = dgv_dsDonHang.Rows[i].Cells["ID"].Value.ToString();
                    query += "UPDATE BANHANG SET TRANGTHAI = 1 WHERE ID = " + idBanHang + " \n";

                }

            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("", "XÁC NHẬN HOAN THANH", buttons);

            if (result == DialogResult.Yes)
            {
                con.ExecuteQuery(query);
                MessageBox.Show(query + "HOAN THANH DON HANG THANH CONG");
            }
        }
    }
}
