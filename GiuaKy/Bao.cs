using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class Bao : TaiLieu
    {
        public DateTime ngayPH { get; set; }
        public int maDM { get; set; }

        public Bao(int maXB, string tenTL, string nhaPH, DateTime ngayPH, int maDM) : base(maXB, tenTL, nhaPH)
        {
            this.ngayPH = ngayPH;
            this.maDM = maDM;
        }

        public override void Display()
        {
            Console.WriteLine($"|MaXB: {maXB}| Tên: {tenTL}| NhaPH: {nhaPH}| NgayPH: {ngayPH}| MaDM: {maDM}");
        }

    }
}
