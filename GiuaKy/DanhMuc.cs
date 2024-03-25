using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class DanhMuc
    {
        public int ID { get; set; }
        public string name { get; set; }

        public DanhMuc(int ID, string name) {
            this.ID = ID;
            this.name = name;
        }

        public static List<DanhMuc> getDsDanhMuc()
        {
            List<DanhMuc> list = new List<DanhMuc>();
            list.Add(new DanhMuc(1, "Sách"));
            list.Add(new DanhMuc(2, "Báo"));
            list.Add(new DanhMuc(3, "Tạp chí"));
            return list;
        }
    }
}
