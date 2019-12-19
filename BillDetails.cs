using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANHANG
{
    class BillDetails
    {
        public string tenNguoiGui;
        public string sdtNguoiGui;
        public string tienThuCod;
        public string tenNguoiNhan;
        public string sdtNguoiNhan;
        public string diachiNguoiNhan;

        public BillDetails(string tenNguoiGui, string sdtNguoiGui, string tienThuCod, string tenNguoiNhan, string sdtNguoiNhan, string diachiNguoiNhan)
        {
            this.tenNguoiGui = tenNguoiGui;
            this.sdtNguoiGui = sdtNguoiGui;
            this.tienThuCod = tienThuCod;
            this.tenNguoiNhan = tenNguoiNhan;
            this.sdtNguoiNhan = sdtNguoiNhan;
            this.diachiNguoiNhan = diachiNguoiNhan;
        }

        public BillDetails()
        {
        }
    }
}
