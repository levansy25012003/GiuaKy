using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class TaiLieu
    {
        public int maXB { get; set; }
        public string tenTL { get; set; }
        public string nhaPH { get; set; }

        public TaiLieu() { }
        public TaiLieu(int maXB, string tenTL, string nhaPH)
        {
            this.maXB = maXB;
            this.tenTL = tenTL;
            this.nhaPH = nhaPH;
        }
        public virtual void Display()
        {
            Console.WriteLine($"|MaXB: {maXB}| Tên: {tenTL}| NhaPH: {nhaPH}");
        }


    }
}
