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
    public partial class XOA_XuatHang : Form
    {
        public XOA_XuatHang()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
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
                    DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
                    dgvcCheckBox.HeaderText = "LUA CHON XOA";
                    dgvcCheckBox.Name = "XOA";
                    
                    if (dataGridView1.Columns.Count == 5)
                    {
                        dataGridView1.Columns.Add(dgvcCheckBox);
                    }
                    //TRA VE CHI TIET CAC LOAI HANG DA BAN TRONG BANHANG_TABLE
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells["CHITIET"].Value = con.LayDanhSachHangDaBan("select hang.ten,phieuxuat.soluong from phieuxuat inner join hang on phieuxuat.hang_id = hang.id where phieuxuat.mabanhang = " + dataGridView1.Rows[i].Cells["id"].Value + "");
                    }
                    
                    dataGridView1.Columns["CHITIET"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dataGridView1.Columns["ID"].ReadOnly = true;
                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[2].ReadOnly = true;
                    dataGridView1.Columns["NGAYBAN"].ReadOnly = true;
                    dataGridView1.Columns["CHITIET"].ReadOnly = true;
                    dataGridView1.Columns["XOA"].ReadOnly = false ;

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells["XOA"].Value = false;
                    }
                }
                else
                {
                    MessageBox.Show("Khong tim thay don hang");
                }

            }
        }

        private void XOA_XuatHang_Load(object sender, EventArgs e)
        {
            tenNguoiGui.DataSource = con.LayDanhSachNguoiBan();
            tenNguoiGui.DisplayMember = "TEN";
            tenNguoiGui.ValueMember = "ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells["XOA"].Value == true)
                {
                    string idBanHang = dataGridView1.Rows[i].Cells["ID"].Value.ToString();
                    int soluongphieuxuat = int.Parse((con.GetDataInfo("select count(*) from PHIEUXUAT where PHIEUXUAT.MABANHANG = "+ idBanHang + "")).Rows[0][0].ToString());
                    int soluongthutien = int.Parse((con.GetDataInfo("select count(*) from THUTIEN where THUTIEN.BANHANG_ID = " + idBanHang + "")).Rows[0][0].ToString());

                    for (int j = 0; j < soluongphieuxuat; j++)
                    {
                        query += "DELETE top(1) FROM PHIEUXUAT WHERE MABANHANG = '" + idBanHang + "'\n";
                    }
                    for (int j = 0; j < soluongthutien; j++)
                    {
                        query += "DELETE top(1) FROM THUTIEN where BANHANG_ID = '" + idBanHang + "'\n";
                    }
                    query += "DELETE FROM BANHANG WHERE BANHANG.ID = " + idBanHang + " \n";

                }

            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("", "XÁC NHẬN XOA", buttons);

            if (result == DialogResult.Yes)
            {
                con.ExecuteQuery(query);
                MessageBox.Show("XOA THÀNH CÔNG");
            }
        }
    }
}
