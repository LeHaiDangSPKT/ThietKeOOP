using System;
using System.Collections.Generic;
using System.Text;

using demoComposite.Component;
using demoComposite.Client;

namespace demoComposite.Composite
{
    public class ThuMucCongTy : NhanVien
    {
        List<NhanVien> danhSachNhanVien = new List<NhanVien>();

        public ThuMucCongTy(int maNV, String hoTen, String viTri, String nhom, int doSau) : base(maNV, hoTen, viTri, nhom, doSau)
        {
        }

        public ThuMucCongTy() { }

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
            try
            {
                danhSachNhanVien.Add(nv);
            }
            catch (Exception)
            {
                Console.WriteLine("Thêm bị lỗi!!!");
            }

        }

        public override void XoaNhanVien(int ma)
        {
            try
            {
                foreach (NhanVien nv in danhSachNhanVien)
                {
                    if (nv.layMaNhanVien() == ma)
                    {
                        danhSachNhanVien.Remove(nv);
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Không tìm thấy nhân viên");
            }

        }


        public override Boolean kiemTraMaTrung(int ma)
        {
            foreach (NhanVien nv in danhSachNhanVien)
            {
                if (nv.layMaNhanVien() == ma)
                    return true;
            }
            return false;
        }

        public override void HienThiNhanVien(int doSauTruyenVao)
        {
            Console.WriteLine("Độ sâu " + this.doSau);
            Console.WriteLine(new String('-', doSauTruyenVao) + "id: " + maNV);
            Console.WriteLine(new String('-', doSauTruyenVao) + "Tên: " + hoTen);
            Console.WriteLine(new String('-', doSauTruyenVao) + "Vị trí: " + viTri);
            Console.WriteLine(new String('-', doSauTruyenVao) + "Nhóm: " + nhom);
            foreach (NhanVien nv in danhSachNhanVien)
            {
                nv.HienThiNhanVien(doSauTruyenVao * 2);
            }
        }
    }
}
