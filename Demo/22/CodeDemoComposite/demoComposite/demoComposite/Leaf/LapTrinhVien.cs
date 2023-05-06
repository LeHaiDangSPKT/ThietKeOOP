using System;
using System.Collections.Generic;
using System.Text;

using demoComposite.Component;

namespace demoComposite.Leaf
{
    public class LapTrinhVien : NhanVien
    {
        public LapTrinhVien(int maNV, String hoTen, String viTri, String nhom, int doSau) : base(maNV, hoTen, viTri, nhom, doSau)
        {
        }
        
        public LapTrinhVien() { }

        public override int layMaNhanVien()
        {
            return this.maNV;
        }

        public override int layDoSau()
        {
            return this.doSau;
        }

        public override void ThemNhanVien(NhanVien nv)
        {
            Console.WriteLine("Không thể thực hiện chức năng này!");
        }

        public override void XoaNhanVien(int ma)
        {
            Console.WriteLine("Không thể thực hiện chức năng này!");
        }

        public override bool kiemTraMaTrung(int ma)
        {
            Console.WriteLine("Không thể thực hiện chức năng này!");
            return false;
        }

        public override void HienThiNhanVien(int doSauTruyenVao)
        {
            Console.WriteLine(new String('-', doSauTruyenVao) + "id: " + maNV);
            Console.WriteLine(new String('-', doSauTruyenVao) + "Tên: " + hoTen);
            Console.WriteLine(new String('-', doSauTruyenVao) + "Vị trí: " + viTri);
            Console.WriteLine(new String('-', doSauTruyenVao) + "Nhóm: " + nhom);
        }
    }
}
