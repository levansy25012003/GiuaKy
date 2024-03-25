using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class TapChi : TaiLieu
    {
        public int soPH { get; set; }
        public int maDM { get; set; }

        public TapChi(int maXB, string tenTL, string nhaPH, int soPH, int maDM ) : base( maXB,  tenTL, nhaPH)
        {
            this.soPH = soPH;
            this.maDM = maDM;
        }

        public override void Display()
        {
            Console.WriteLine($"|MaXB: {maXB}| Tên: {tenTL}| NhaPH: {nhaPH}| TenTG: {soPH} |MaDM: {maDM}");
        }

    }
}
