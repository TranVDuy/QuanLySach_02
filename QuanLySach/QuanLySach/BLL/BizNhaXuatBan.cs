using QuanLySach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.BLL
{
    class BizNhaXuatBan
    {
        public void Insert(NhaXuatban nxb)
        {

        }

        public List<NhaXuatban> ReadAll()
        {
            List<NhaXuatban> lst = new List<NhaXuatban> ();
            lst.Add(new NhaXuatban()
            {
                MaNhaXuatBan = 1,
                TenNhaXuatBan = "Nhà xuất bản tuổi trẻ tài cao"
            });
            lst.Add(new NhaXuatban()
            {
                MaNhaXuatBan = 2,
                TenNhaXuatBan = "Nhà xuất bản Kim Đồng"
            });
            lst.Add(new NhaXuatban()
            {
                MaNhaXuatBan = 3,
                TenNhaXuatBan = "Nhà xuất bản ABC"
            });
            lst.Add(new NhaXuatban()
            {
                MaNhaXuatBan = 4,
                TenNhaXuatBan = "Nhà xuất bản tuổi cao sức yếu"
            });

            return lst;
        }
    }
}
