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
using BANHANG.ThongKeFolder;
namespace BANHANG
{
    public partial class MENUCHINH : Form
    {
        public MENUCHINH()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            NHAPHANG nHAPHANG = new NHAPHANG();
            nHAPHANG.Show();
        }
        public DataTable TransposeDataTable(DataTable dt)
        {
            DataTable transposedTable = new DataTable();

            DataColumn firstColumn = new DataColumn(dt.Columns[0].ColumnName);
            transposedTable.Columns.Add(firstColumn);

            //Add a column for each row in first data table
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataColumn dc = new DataColumn(dt.Rows[i][0].ToString());
                transposedTable.Columns.Add(dc);
            }

            for (int j = 1; j < dt.Columns.Count; j++)
            {
                DataRow dr = transposedTable.NewRow();
                dr[0] = dt.Columns[j].ColumnName;

                for (int k = 0; k < dt.Rows.Count; k++)
                {
                    dr[k + 1] = dt.Rows[k][j];
                }

                transposedTable.Rows.Add(dr);
            }

            return transposedTable;
        }

        private void MENUCHINH_Load(object sender, EventArgs e)
        {
            dgv_DanhMucHang.DataSource = TransposeDataTable(con.LaySoLuongHangTrongKho());
            dgv_DanhMucHang.Columns[0].Visible = false;
        }

        private void btn_XUATHANG_Click(object sender, EventArgs e)
        {
            XUATHANG_MENU xUATHANG = new XUATHANG_MENU();
            xUATHANG.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            QLMatHang qLMatHang = new QLMatHang();
            qLMatHang.Show();
        }

        private void btn_THONGKE_Click(object sender, EventArgs e)
        {
            ThongKeHang thongKeHang = new ThongKeHang();
            thongKeHang.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dgv_DanhMucHang.DataSource = TransposeDataTable(con.LaySoLuongHangTrongKho());
            dgv_DanhMucHang.Columns[0].Visible = false;
        }
    }
}
