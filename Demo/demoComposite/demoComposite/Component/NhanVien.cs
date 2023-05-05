using System;
using System.Collections.Generic;
using System.Text;

namespace demoComposite.Component
{
    public abstract class NhanVien
    {
        protected int maNV;
        protected String hoTen;
        protected String viTri;
        protected String nhom;
        protected int doSau;

        public NhanVien(int maNV, String hoTen, String viTri, String nhom, int doSau)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.viTri = viTri;
            this.nhom = nhom;
            this.doSau = doSau;
        }
        public NhanVien() { }

        public abstract int layMaNhanVien();
        public abstract int layDoSau();
        public abstract void ThemNhanVien(NhanVien nv);
        public abstract void XoaNhanVien(int ma);
        public abstract Boolean kiemTraMaTrung(int ma);
        public abstract void HienThiNhanVien(int doSauTruyenVao);

    }
}
