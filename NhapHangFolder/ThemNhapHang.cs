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
    public partial class NhapHang1 : Form
    {
        public NhapHang1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_1.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_2.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_3.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }
        Connection con = new Connection();
        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_hang1.DataSource = con.LayDanhSachHang();
            cbx_hang2.DataSource = con.LayDanhSachHang();
            cbx_hang3.DataSource = con.LayDanhSachHang();

            
            cbx_hang1.ValueMember = "ID";
            cbx_hang2.ValueMember = "ID";
            cbx_hang3.ValueMember = "ID";

            cbx_hang1.DisplayMember = "TEN";
            cbx_hang2.DisplayMember = "TEN";
            cbx_hang3.DisplayMember = "TEN";
        }
        private int TinhTong(DataGridView dgv)
        {
            int sum = 0;
            foreach (DataGridViewRow r in dgv.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value != null)
                    {
                        int num = 0;
                        try
                        {
                            num = int.Parse(c.Value.ToString());
                            if (num < 0)
                            {
                                c.Value = null;
                                num = 0;
                                MessageBox.Show("Không được nhập số ÂM");
                            }
                            else if (num > 100)
                            {
                                MessageBox.Show("CẢNH BÁO !!! Số lượng nhập quá 100");
                            }
                            sum += num;
                        }
                        catch
                        {
                            c.Value = null;
                            MessageBox.Show("Nhập sai số lượng");
                        }
                    }
                }
            }
            return sum;
        }
        private void dgv_1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Tong_1.Text = TinhTong(dgv_1).ToString();
        }
        private void dgv_2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Tong_2.Text = TinhTong(dgv_2).ToString();
        }
        private void dgv_3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Tong_3.Text = TinhTong(dgv_3).ToString();
        }
        int sl1, sl2, sl3;
        
        string query = "";
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            //truong hop may yeu
            //Tong_1.Text = TinhTong(dgv_1).ToString();
            //Tong_2.Text = TinhTong(dgv_2).ToString();
            //Tong_3.Text = TinhTong(dgv_3).ToString();
            query = "";
            sl1 = int.Parse(Tong_1.Text);
            sl2 = int.Parse(Tong_2.Text);
            sl3 = int.Parse(Tong_3.Text);
            string message = "";
            if (sl1 != 0)
            {
                message += cbx_hang1.Text + ": " + sl1.ToString() + " đôi\n";
                query += "INSERT INTO PHIEUNHAP VALUES(" + cbx_hang1.SelectedValue + "," + Tong_1.Text + ",0,0,GETDATE())\n";
            }
            if (sl2 != 0)
            {
                message += cbx_hang2.Text + ": " + sl2.ToString() + " đôi\n";
                query += "INSERT INTO PHIEUNHAP VALUES(" + cbx_hang2.SelectedValue + "," + Tong_2.Text + ",0,0,GETDATE())\n";

            }
            if (sl3 != 0)
            {
                message += cbx_hang3.Text + ": " + sl3.ToString() + " đôi\n";
                query += "INSERT INTO PHIEUNHAP VALUES(" + cbx_hang3.SelectedValue + "," + Tong_3.Text + ",0,0,GETDATE())\n";

            }
            string title = "XAC NHAN NHAP";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.ExecuteQuery(query);
                MessageBox.Show(query);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(con.NhapPhieuNhap());
        }

        
    }
}
