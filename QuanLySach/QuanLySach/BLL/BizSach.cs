using QuanLySach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.BLL
{
    class BizSach
    {
        public List<Sach> ReadAll()
        {
            List<Sach> list = new List<Sach>();
            Sach ss = new Sach();
            ss.MaSach = 1;
            ss.TieuDe = "Tin học đại cương";
            ss.DanhSachTacGia = "Nguyễn Quang Hưng, Trương Công Tuấn";
            ss.MaNhaXuatBan = 1;
            ss.NamXuatBan = 2001;

            list.Add(ss);

            ss = new Sach()
            {
                MaSach = 2,
                TieuDe = "Kiến trúc máy tính",
                DanhSachTacGia = "Đặng Thanh Chương",
                MaNhaXuatBan = 1,
                NamXuatBan = 2010
            };
            list.Add(ss);

           
            list.Add(new Sach()
            {
                MaSach = 3,
                TieuDe = "Phát triển ứng dụng Desktop",
                DanhSachTacGia = "Nguyễn Văn Trung",
                MaNhaXuatBan = 2,
                NamXuatBan = 2021
            });

            return list;
        }
        //public void Xoa(Sach s)
        //    throw new NotImplementedException();
        //{
        //}

        internal void Insert(Sach x)
        {
            
        }

        internal bool Xoa(Sach s)
        {
            //throw new NotImplementedException();
            return true;
        }
    }
}
