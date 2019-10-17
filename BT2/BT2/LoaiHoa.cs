using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    class LoaiHoa:List<Hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa(string tenLoai)
        {
            TenLoai = tenLoai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }
        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("Hoa cúc")
                {
                  new Hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "donxuan.jpg", Mota = "Hoa cúc các màu: trắng, vàng cam" },
                  new Hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "honnhien.jpg", Mota = "Hoa anh đào màu: trắng, hồng" },
                  new Hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "tim.jpg", Mota = "Hoa cúc tím thủy chung" },

                },

                new LoaiHoa("Hoa cưới")
                {
                  new Hoa { TenHoa = "Dây tơ hồng", Gia = 25000, Hinh = "daytohong.jpg", Mota = "Hoa dây tơ hồng màu: trắng, vàng cam" },
                  new Hoa { TenHoa = "Cầu thủy tinh", Gia = 60000, Hinh = "cauthuytinh.jpg", Mota = "Hoa thủy tinh màu: trắng, hồng" },
                  new Hoa { TenHoa = "Duyên thầm", Gia = 45000, Hinh = "duyen.jpg", Mota = "Hoa tình duyên thủy chung" },
                }
            };
            Loaihoas = l;
        }
    }
}
