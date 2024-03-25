using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class Sach : TaiLieu
    {
        public string tenTG { get; set; }
        public int soTrang { get; set; }
        public int maDM { get; set; }

        public Sach(int maXB, string tenTL, string nhaPH, string tenTG, int soTrang, int maDM) : base(maXB, tenTL, nhaPH)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
            this.maDM = maDM;
        }

        public override void Display()
        {
            Console.WriteLine($"|MaXB: {maXB}| Tên: {tenTL}| NhaPH: {nhaPH}| TenTG: {tenTG}| SoTrang: {soTrang} |MaDM: {maDM}");
        }

    }
}
