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
using System.Drawing.Printing;
namespace BANHANG
{
    public partial class XUATHANG : Form
    {
        public XUATHANG()
        {
            InitializeComponent();
            trangthai = true;
            button1.Visible = false;
            //them moi la true
            //update la false;

        }
        string idBanHang;
        string idNguoiGui ;
        string sdtNguoiGui_txt;
        string sdtNguoiNhan_txt;
        string tenNguoiNhan_txt ;
        string idNguoiNhan ;
        string diaChiNguoiNhan ;
        string nganHang_txt;
        string tienCoctxt ;
        string giamGiatxt;
        bool trangthai;
        string trangthaibanhang;
        //true la thanh toan het
        //false la coc truoc
        List<string> soLuongHangBan_cu;
        List<string> giaBanHang_cu;
        public XUATHANG(string idBanHang, string idNguoiGui, string sdtNguoiNhan_txt, string tenNguoiNhan_txt, string diaChiNguoiNhan, string nganHang_txt, string tienCoctxt, string giamGiatxt, List<string> soLuongHangBan, List<string> giaBanHang, bool trangthai, string trangthaibanhang)
        {
            InitializeComponent();
            
            //button1.Visible = true;
            this.idBanHang = idBanHang;
            dsNguoiBan = con.LayDanhSachNguoiBan();
            
            this.idNguoiGui = idNguoiGui;
            for (int i = 0; i < dsNguoiBan.Rows.Count; i++)
            {
                if (idNguoiGui == dsNguoiBan.Rows[i]["ID"])
                {
                    TenNguoiGui.SelectedIndex = i + 1;
                    break;
                }
            }
            this.sdtNguoiNhan.Text = sdtNguoiNhan_txt;
            this.TenNguoiNhan.Text = tenNguoiNhan_txt;
            this.DiaChi.Text = diaChiNguoiNhan;
            this.nganHang_txt = nganHang_txt;
            
            this.TienCoc.Value = int.Parse(tienCoctxt);
            this.giamGia.Value = int.Parse(giamGiatxt);
            

            this.soLuongHangBan_cu = soLuongHangBan;
            this.giaBanHang_cu = giaBanHang;
            //this.dgv_MuaHang.Hide();
            //this.dgv_MuaHang_cu = dgv_MuaHang;

            this.trangthaibanhang = trangthaibanhang;
            this.trangthai = trangthai;
        }

        Connection con = new Connection();
        BillDetails billDetails = new BillDetails();
        
        DataTable dsNguoiNhan = new DataTable();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dsNguoiNhan = con.LayDanhSachNguoiMua(sdtNguoiNhan.Text);
            //dgv_MuaHang.DataSource = dsNguoiGui;
            if(dsNguoiNhan.Rows.Count != 0)
            {
                TenNguoiNhan.Text = dsNguoiNhan.Rows[0]["TEN"].ToString();
                DiaChi.Text = dsNguoiNhan.Rows[0]["DIACHI"].ToString();
                idNguoiNhan = dsNguoiNhan.Rows[0]["ID"].ToString();
            }
            else
            {
                TenNguoiNhan.Text = "";
                DiaChi.Text = "";
                idNguoiNhan = "";
            }
        }
        DataTable dsHang;
        DataTable dsNguoiBan = new DataTable();
        private void XUATHANG_Load(object sender, EventArgs e)
        {
            dsHang = con.LayDanhSachHang();
            dsNguoiBan = con.LayDanhSachNguoiBan();
            TenNguoiGui.DataSource = dsNguoiBan;
            TenNguoiGui.DisplayMember = "TEN";
            TenNguoiGui.ValueMember = "ID";
            nganHang.SelectedIndex = 0;
            dgv_MuaHang.DataSource = dsHang;
            dgv_MuaHang.Columns.Add("SOLUONG","SO LUONG");
            dgv_MuaHang.Columns.Add("GIABAN","GIA BAN");
            dgv_MuaHang.Columns[0].Visible = false;
            dgv_MuaHang.AllowUserToAddRows = false;

            dgv_MuaHang.Columns[1].ReadOnly = true;

            if(trangthai == false)
            {
                for(int i = 0;i< TenNguoiGui.Items.Count;i++)
                {
                    if (dsNguoiBan.Rows[i]["ID"].ToString() == idNguoiGui)
                    {
                        TenNguoiGui.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < this.dgv_MuaHang.Rows.Count; i++)
                {
                    this.dgv_MuaHang.Rows[i].Cells[2].Value = soLuongHangBan_cu[i];
                    this.dgv_MuaHang.Rows[i].Cells[3].Value = giaBanHang_cu[i];
                }
                for (int i = 0; i < 4; i++)
                {
                    if (nganHang.Items[i].ToString() == nganHang_txt)
                    {
                        nganHang.SelectedIndex = i;
                    }
                }
                if(trangthaibanhang == "True")
                {
                    cbx2.Checked = true;
                }
                else
                {
                    cbx1.Checked = true ;
                }
                int tong = 0;
                for (int i = 0; i < dgv_MuaHang.Rows.Count; i++)
                {
                    if (dgv_MuaHang.Rows[i].Cells[2].Value != "" && dgv_MuaHang.Rows[i].Cells[3].Value != "")
                    {
                        tong += int.Parse(dgv_MuaHang.Rows[i].Cells[2].Value.ToString().Trim()) * int.Parse(dgv_MuaHang.Rows[i].Cells[3].Value.ToString().Trim());
                    }

                }
                tongTien.Text = string.Format("{0:#,#.#############################}", tong);
                btn_XUATHANG.Text = "CAP NHAT";
                btn_XUATHANG.Click -= btn_XUATHANG_Click;
                btn_XUATHANG.Click += btn_UPDATE_Click;
            }

        }
        private int xor_op(bool p1,bool p2)
        {
            if (p1 == true && p2 == true)
            {
                return 1;

            }
            else if(p1==false && p2 == false)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            cbx2.Checked = !cbx1.Checked;
        }

        private void cbx2_CheckedChanged(object sender, EventArgs e)
        {
            cbx1.Checked = !cbx2.Checked;
        }
        bool soLuongHangNhap;
        private bool kiemtradayduthongtin()
        {
            idNguoiGui = TenNguoiGui.SelectedValue.ToString();
            sdtNguoiGui_txt = con.getOneStringInfo("SELECT SDT FROM NGUOIBAN WHERE ID = "+ idNguoiGui + "");
            MessageBox.Show(idNguoiGui + ":" + sdtNguoiGui_txt);
            sdtNguoiNhan_txt = sdtNguoiNhan.Text.Trim();
            tenNguoiNhan_txt = TenNguoiNhan.Text.Trim();
            idNguoiNhan = "";
            diaChiNguoiNhan = DiaChi.Text.Trim();
            nganHang_txt = nganHang.Text;
            tienCoctxt = TienCoc.Value.ToString();
            giamGiatxt = giamGia.Value.ToString();
            if (dsNguoiNhan.Rows.Count != 0)
            {
                idNguoiNhan = dsNguoiNhan.Rows[0]["ID"].ToString();
            }


            bool dsThongTinHangNhap = true;
            int dsThongTinHangNhap_null = 0;
            //KIEM TRA NULL TRONG BANG
            for (int i = 0; i < dsHang.Rows.Count; i++)
            {
                if (xor_op(dgv_MuaHang.Rows[i].Cells[2].Value == null, dgv_MuaHang.Rows[i].Cells[3].Value == null) == 0)
                {
                    //TRUONG HOP 1 TRONG 2 COT NULL
                    MessageBox.Show("Hang hoa nhap vao khong hop le");
                    dsThongTinHangNhap = false;
                    break;
                }
                else if (xor_op(dgv_MuaHang.Rows[i].Cells[2].Value == null, dgv_MuaHang.Rows[i].Cells[3].Value == null) == 1)
                {
                    //DEM SO DONG NULL
                    dsThongTinHangNhap_null++;
                }
            }
            //KIEM TRA SO LUONG
            soLuongHangNhap = true;
            for (int i = 0; i < dgv_MuaHang.Rows.Count; i++)
            {
                if (dgv_MuaHang.Rows[i].Cells[2].Value != null && dgv_MuaHang.Rows[i].Cells[3].Value != null)
                {
                    {
                        if(trangthai == true)
                        {
                            if (int.Parse(con.GetListDataInt("select soluong - " + dgv_MuaHang.Rows[i].Cells[2].Value.ToString() + " from HANG where ID = " + dgv_MuaHang.Rows[i].Cells[0].Value.ToString() + "")[0]) < 0)
                            {
                                soLuongHangNhap = false;
                                MessageBox.Show("SO LUONG HANG CO SAN KHONG DU");
                                break;
                            }
                        }
                        else
                        {
                            string soluongcu;
                            if (giaBanHang_cu[i] != "")
                            {
                                soluongcu = giaBanHang_cu[i];
                            }
                            else
                            {
                                soluongcu = "0";
                            }

                            string soluongmoi;
                            if (dgv_MuaHang.Rows[i].Cells[2].Value.ToString() != "")
                            {
                                soluongmoi = dgv_MuaHang.Rows[i].Cells[2].Value.ToString();
                            }
                            else
                            {
                                soluongmoi = "0";
                            }

                            if(soluongmoi != "0")
                            {
                                if (int.Parse(con.GetListDataInt("select soluong - " + soluongmoi + " + "+ soluongcu + " from HANG where ID = " + dgv_MuaHang.Rows[i].Cells[0].Value.ToString() + "")[0]) < 0)
                                {
                                    soLuongHangNhap = false;
                                }
                            }
                        }
                    }
                }
            }
            return (idNguoiGui == "" || sdtNguoiNhan_txt == "" || tenNguoiNhan_txt == "" || diaChiNguoiNhan == "" || nganHang_txt == "" || tienCoctxt == "" || giamGiatxt == "" || (cbx1.Checked == false && cbx2.Checked == false) || dsThongTinHangNhap == false || dsThongTinHangNhap_null == dgv_MuaHang.Rows.Count);
        }
        private void btn_XUATHANG_Click(object sender, EventArgs e)
        {
            if (kiemtradayduthongtin()) 
            {
                MessageBox.Show("Phai dien day du thong tin");
            }
            else if(soLuongHangNhap == true)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("???????", "XAC NHAN PHIEU XUAT", buttons);
                if (result == DialogResult.Yes)
                {
                    string query = "";
                    if (idNguoiNhan == "")
                    {
                        query += "INSERT INTO NGUOIMUA VALUES('" + tenNguoiNhan_txt + "','" + sdtNguoiNhan_txt + "','" + diaChiNguoiNhan + "')\n";
                        con.ExecuteQuery(query);
                        query = "";
                        idNguoiNhan = con.getOneID("SELECT ident_current('NGUOIMUA')");
                        //THEM NGUOI MUA

                    }

                    query += "INSERT INTO BANHANG VALUES(" + idNguoiGui + "," + idNguoiNhan + "," + giamGiatxt + ",GETDATE(),";
                    if (cbx1.Checked == true)
                    {
                        query += "0)\n";
                    }
                    else
                    {
                        query += "1)\n";
                    }
                    con.ExecuteQuery(query);
                    query = "";
                    //THEM BANHANG

                    idBanHang = con.getOneID("SELECT ident_current('BANHANG')");
                    query += "INSERT INTO THUTIEN VALUES(" + idBanHang + ",'" + nganHang_txt + "','" + tienCoctxt + "',GETDATE())\n";

                    //THEM THU TIEN
                    for (int i = 0; i < dgv_MuaHang.Rows.Count; i++)
                    {
                        if (dgv_MuaHang.Rows[i].Cells[2].Value != null && dgv_MuaHang.Rows[i].Cells[3].Value != null)
                        {
                            query += "INSERT INTO PHIEUXUAT VALUES(" + dgv_MuaHang.Rows[i].Cells[0].Value.ToString().Trim() + "," + laysochinhxac(dgv_MuaHang.Rows[i].Cells[2].Value.ToString()) + "," + laysochinhxac(dgv_MuaHang.Rows[i].Cells[3].Value.ToString()) + "," + idBanHang + ")\n";
                        }
                    }
                    con.ExecuteQuery(query);
                    query = "";
                    BILL bill = new BILL(TenNguoiGui.Text, sdtNguoiGui_txt, tienCoctxt, tenNguoiNhan_txt, sdtNguoiNhan_txt, diaChiNguoiNhan);
                    bill.Show();
                    MessageBox.Show("THEM PHIEU XUAT THANG CONG");
                    ResetForm();
                }
                
            }
        }
        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            if (kiemtradayduthongtin())
            {
                MessageBox.Show("Phai dien day du thong tin 1");
            }
            else if (soLuongHangNhap == true)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("???????", "XAC NHAN PHIEU XUAT", buttons);
                if (result == DialogResult.Yes)
                {
                    string query = "";
                    if (idNguoiNhan == "")
                    {
                        query += "INSERT INTO NGUOIMUA VALUES('" + tenNguoiNhan_txt + "','" + sdtNguoiNhan_txt + "','" + diaChiNguoiNhan + "')\n";
                        con.ExecuteQuery(query);
                        idNguoiNhan = con.getOneID("SELECT ident_current('NGUOIMUA')");
                        query = "";

                        //THEM NGUOI MUA

                    }



                    query += "UPDATE BANHANG SET NGUOIBAN_ID = '"+ idNguoiGui + "',NGUOIMUA_ID = '"+ idNguoiNhan + "',GIAMGIA = '"+ giamGiatxt + "',TRANGTHAI = '";
                    if (cbx1.Checked == true)
                    {
                        query += "0'";
                    }
                    else
                    {
                        query += "1'";
                    }
                    query += " WHERE ID = " + idBanHang + "\n";
                    
                    //SUA BANHANG

                    query += "UPDATE THUTIEN SET PHUONGTHUCTHANHTOAN = '"+nganHang_txt+"',SOTIEN = '"+tienCoctxt+"' WHERE BANHANG_ID = '"+idBanHang+"' AND ID = (SELECT MIN(ID) FROM THUTIEN WHERE BANHANG_ID = '"+ idBanHang + "')\n";

                    //THEM THU TIEN -- 0k
                    for (int i = 0; i < dgv_MuaHang.Rows.Count; i++)
                    {
                        if (giaBanHang_cu[i] != "" && soLuongHangBan_cu[i] != "")
                        {
                            con.ExecuteQuery("DELETE top(1)  FROM PHIEUXUAT WHERE MABANHANG = '" + idBanHang + "'");
                        }
                    }
                    //XOA NHAP HANG CU

                    for (int i = 0; i < dgv_MuaHang.Rows.Count; i++)
                    {
                        if ((dgv_MuaHang.Rows[i].Cells[2].Value != null && dgv_MuaHang.Rows[i].Cells[3].Value != null) && (dgv_MuaHang.Rows[i].Cells[2].Value.ToString().Trim() != "" && dgv_MuaHang.Rows[i].Cells[3].Value.ToString().Trim() != ""))
                        {
                            query += "INSERT INTO PHIEUXUAT VALUES(" + dgv_MuaHang.Rows[i].Cells[0].Value.ToString().Trim() + "," + laysochinhxac(dgv_MuaHang.Rows[i].Cells[2].Value.ToString()) + "," + laysochinhxac(dgv_MuaHang.Rows[i].Cells[3].Value.ToString()) + "," + idBanHang + ")\n";
                        }
                    }

                    con.ExecuteQuery(query);

                    BILL bill = new BILL(TenNguoiGui.Text, sdtNguoiGui_txt, tienCoctxt, tenNguoiNhan_txt, sdtNguoiNhan_txt, diaChiNguoiNhan);
                    bill.Show();
                    MessageBox.Show("SUA PHIEU XUAT THANG CONG");
                    ResetForm();
                }

            }
        }
        private void ResetForm()
        {
            sdtNguoiNhan.Text = "";
            TenNguoiNhan.Text = "";
            DiaChi.Text = "";
            cbx1.Checked = false;
            cbx2.Checked = false;
            TienCoc.Value = 0;
            giamGia.Value = 0;
            for(int i = 0; i < dgv_MuaHang.Rows.Count; i++)
            {
                dgv_MuaHang.Rows[i].Cells[2].Value = null;
                dgv_MuaHang.Rows[i].Cells[3].Value = null;
            }
        }
        private string laysochinhxac(string so)
        {
            return so.Replace(",", "");
        }

        private void dgv_MuaHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int num = int.Parse(dgv_MuaHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (num < 0)
                {
                    MessageBox.Show("Khong duoc nhap so am");
                    dgv_MuaHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                }
                else
                {
                    int tong = 0;
                    for (int i = 0; i < dgv_MuaHang.Rows.Count; i++)
                    {
                        if ((dgv_MuaHang.Rows[i].Cells[2].Value != null && dgv_MuaHang.Rows[i].Cells[3].Value != null) && (dgv_MuaHang.Rows[i].Cells[2].Value.ToString().Trim() != "" && dgv_MuaHang.Rows[i].Cells[3].Value.ToString().Trim() != ""))
                        {
                            tong += int.Parse(dgv_MuaHang.Rows[i].Cells[2].Value.ToString().Trim()) * int.Parse(dgv_MuaHang.Rows[i].Cells[3].Value.ToString().Trim());
                        }
                    }
                    tongTien.Text = string.Format("{0:#,#.#############################}", tong);

                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
                MessageBox.Show("Du lieu nhap vao khong hop le");
                dgv_MuaHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            }
        }
    }

}
