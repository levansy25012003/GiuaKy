using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<DanhMuc> dsDanhMuc = DanhMuc.getDsDanhMuc();
            // 2.1 Thêm mới các danh sách
            List<TaiLieu> ds243 = new List<TaiLieu>
            {
                new Sach(1, "Lịch sử đảng", "Cộng sản", "Lê Văn Sỹ", 500, 1),
                new Sach(2, "Lịch sử đảng", "Cộng sản", "Lê Văn Sỹ", 500, 1),
                new Bao(3, "Triết học MAC", "Hồ Chí Minh", new DateTime(2024, 3, 15), 2),
                new Bao(4, "Triết học MAC", "Hồ Chí Minh", new DateTime(2024, 4, 15), 2),
                new TapChi(5, "Triết học MAC", "Hồ Chí Minh", 999, 3),
                new TapChi(6, "Triết học MAC", "Hồ Chí Minh", 888, 3)
            };

            // 2.2. Tìm theo danh mục 
            Console.WriteLine("Nhập Vào Danh mục: 1: Báo, 2: Sách, 3: Tạp chí: ");
            int maDanhMuc243 = int.Parse(Console.ReadLine());
            var result_243 = from tl in ds243
                             where tl is Bao && (tl as Bao).maDM == maDanhMuc243
                                || tl is Sach && (tl as Sach).maDM == maDanhMuc243
                                || tl is TapChi && (tl as TapChi).maDM == maDanhMuc243
                             select tl;

            Console.WriteLine("Các tài liệu trong danh mục:");
            foreach (var tl in result_243)
            {
                tl.Display();
            }

            // 2.3. Tìm Báo có ngày PH trong tháng 3/ 2024
            var baoTrongThang3 = from tl in ds243
                                 where tl is Bao && ((Bao)tl).ngayPH.Month == 3 && ((Bao)tl).ngayPH.Year == 2024
                                 select tl;
            

            Console.WriteLine("Các bài báo trong tháng 3/2024");
            foreach (var tl in baoTrongThang3)
            {
                tl.Display();
            }
            Console.ReadKey();

        }
    }
}
