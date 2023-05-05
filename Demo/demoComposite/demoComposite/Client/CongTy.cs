using System;
using System.Collections.Generic;
using System.Text;

using System.Windows;
using demoComposite.Composite;
using demoComposite.Leaf;

namespace demoComposite.Client
{
    public class CongTy
    {
        public CongTy() { }

        ThuMucCongTy thuMucQuanLy = new ThuMucCongTy(-1, "Người giữ thư mục quản lý", "Thư mục quản lý", "ThuMucQuanLy", 0);
        ThuMucCongTy thuMucLapTrinhVien = new ThuMucCongTy(-2, "Người giữ thư mục nhân viên", "Thư mục nhân viên", "ThuMucLapTrinhVien", 1);

        public void ThemDuLieuMacDinh()
        {
            // Thêm quản lý
            thuMucQuanLy.ThemNhanVien(new QuanLy(1, "LXT5", "SEO Manager", "QuanLy", 0));
            thuMucQuanLy.ThemNhanVien(new QuanLy(2, "LXT6", "CEO", "QuanLy", 0));
            thuMucQuanLy.ThemNhanVien(new QuanLy(3, "LXT7", "Manager1", "QuanLy", 0));
            thuMucQuanLy.ThemNhanVien(new QuanLy(4, "LXT8", "Manager2", "QuanLy", 0));

            // Thêm lập trình viên
            thuMucLapTrinhVien.ThemNhanVien(new LapTrinhVien(11, "LHD1", "Pro Developer", "LapTrinhVien", 1));
            thuMucLapTrinhVien.ThemNhanVien(new LapTrinhVien(12, "LHD2", "Developer", "LapTrinhVien", 1));
            thuMucLapTrinhVien.ThemNhanVien(new LapTrinhVien(13, "LHD3", "Pro Developer", "LapTrinhVien", 1));
            thuMucLapTrinhVien.ThemNhanVien(new LapTrinhVien(14, "LHD4", "Developer", "LapTrinhVien", 1));

            // Đưa thư mục nhân viên vào thư mục quản lý
            thuMucQuanLy.ThemNhanVien(thuMucLapTrinhVien);
        }

        public void HienThiThemNhanVien(int kyTuCay, int doSauThucHien)
        {
            bool ketThuc = false;
            while (!ketThuc)
            {
                Console.WriteLine("Nhập mã nhân viên: ");
                int maNV;
                do
                {
                    try
                    {
                        do
                        {
                            maNV = int.Parse(Console.ReadLine());
                            if (thuMucQuanLy.kiemTraMaTrung(maNV) || thuMucLapTrinhVien.kiemTraMaTrung(maNV))
                            {
                                Console.WriteLine("Mã nhân viên đã tồn tại! Mời nhập lại mã nhân viên khác !!!: ");
                            }
                        } while (thuMucQuanLy.kiemTraMaTrung(maNV) || thuMucLapTrinhVien.kiemTraMaTrung(maNV));
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Mời nhập lại !!!");
                    }
                } while (true);
                Console.WriteLine("Nhập họ tên nhân viên: ");
                String hoTen = Console.ReadLine().Trim();
                Console.WriteLine("Nhập vị trí nhân viên: ");
                String viTri = Console.ReadLine().Trim();
                bool ketThucNhapNhom = false;
                while(!ketThucNhapNhom)
                {
                    Console.WriteLine("Nhập nhóm nhân viên: ");
                    String nhom;
                    do
                    {
                        try
                        {
                            if(doSauThucHien == 0)
                            {
                                do
                                {
                                    nhom = Console.ReadLine().Trim();
                                    Console.WriteLine(nhom);
                                    if (!(nhom == "QuanLy"))
                                    {
                                        Console.WriteLine("Đang ở độ sâu 0 thuộc nhóm QuanLy ! Mời nhập lại: ");
                                    }
                                } while (!(nhom == "QuanLy"));
                                break;
                            }
                            if (doSauThucHien == 1)
                            {
                                do
                                {
                                    nhom = Console.ReadLine().Trim();
                                    Console.WriteLine(nhom);
                                    if (!(nhom == "LapTrinhVien"))
                                    {
                                        Console.WriteLine("Đang ở độ sâu 1 thuộc nhóm LapTrinhVien ! Mời nhập lại: ");
                                    }
                                } while (!(nhom == "LapTrinhVien"));
                                break;
                            }

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Mời nhập lại !!!");
                        }
                    } while (true);
                    if(doSauThucHien == 0)
                        thuMucQuanLy.ThemNhanVien(new QuanLy(maNV, hoTen, viTri, nhom, 0));
                    if(doSauThucHien == 1)
                        thuMucLapTrinhVien.ThemNhanVien(new LapTrinhVien(maNV, hoTen, viTri, nhom, 1));
                    Console.Clear();
                    thuMucQuanLy.HienThiNhanVien(kyTuCay);
                    ketThucNhapNhom = true;
                    ketThuc = true;
                }    
                
            }
        }

        public void HienThiXoaNhanVien(int kyTuCay, int doSauThucHien)
        {
            bool ketThuc = false;
            while (!ketThuc)
            {
                Console.WriteLine("Nhập mã nhân viên muốn xóa");
                int maNV;
                do
                {
                    try
                    {
                        if(doSauThucHien == 0)
                        {
                            do
                            {
                                Console.Write("Mời nhập lựa chọn: ");
                                maNV = int.Parse(Console.ReadLine());
                                if (!(thuMucQuanLy.kiemTraMaTrung(maNV)))
                                {
                                    Console.WriteLine("Mời nhập lại mã nhân viên !!!: ");
                                }
                            } while (!(thuMucQuanLy.kiemTraMaTrung(maNV)));
                            break;
                        }
                        if (doSauThucHien == 1)
                        {
                            do
                            {
                                Console.Write("Mời nhập lựa chọn: ");
                                maNV = int.Parse(Console.ReadLine());
                                if (!(thuMucLapTrinhVien.kiemTraMaTrung(maNV)))
                                {
                                    Console.WriteLine("Mời nhập lại mã nhân viên !!!: ");
                                }
                            } while (!(thuMucLapTrinhVien.kiemTraMaTrung(maNV)));
                            break;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Mời nhập lại !!!");
                    }
                } while (true);
                if(doSauThucHien == 0)
                    thuMucQuanLy.XoaNhanVien(maNV);
                if(doSauThucHien == 1)
                    thuMucLapTrinhVien.XoaNhanVien(maNV);
                Console.Clear();
                thuMucQuanLy.HienThiNhanVien(kyTuCay);
                ketThuc = true;
                break;
            }
        }

        public void HienThiNhanVien(int kyTuCay)
        {
            thuMucQuanLy.HienThiNhanVien(kyTuCay);

            bool ketThuc = false;
            while (!ketThuc)
            {
                int doSauThucHien;
                do
                {
                    try
                    {
                        do
                        {
                            Console.Write("Mời nhập độ sâu để thực hiện chức năng: ");
                            doSauThucHien = int.Parse(Console.ReadLine());
                            if (doSauThucHien < 0 || doSauThucHien > 1)
                            {
                                Console.WriteLine("Mời nhập lại độ sâu !!!: ");
                            }
                        } while (doSauThucHien < 0 || doSauThucHien > 1);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Mời nhập lại !!!");
                    }
                } while (true);

                bool ketThucChucNang = false;
                while (!ketThucChucNang)
                {
                    Console.WriteLine("\n=====================Độ sâu hiện tại: " + doSauThucHien + " =====================");
                    Console.WriteLine("\n=====================Chức năng=====================");
                    Console.WriteLine("1. Thêm nhân viên");
                    Console.WriteLine("2. Xóa nhân viên");
                    Console.WriteLine("3. Nhập lại độ sâu");
                    Console.WriteLine("0. Quay về");
                    int chonChucNang;
                    do
                    {
                        try
                        {
                            do
                            {
                                Console.Write("Mời nhập lựa chọn: ");
                                chonChucNang = int.Parse(Console.ReadLine());
                                if (chonChucNang < 0 || chonChucNang > 3)
                                {
                                    Console.WriteLine("Mời nhập lại chức năng !!!: ");
                                }
                            } while (chonChucNang < 0 || chonChucNang > 3);
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Mời nhập lại !!!");
                        }
                    } while (true);
                    switch (chonChucNang)
                    {
                        case 1:
                            this.HienThiThemNhanVien(kyTuCay, doSauThucHien);
                            Console.ReadKey(); break;
                        case 2:
                            this.HienThiXoaNhanVien(kyTuCay, doSauThucHien);
                            Console.ReadKey(); break;
                        case 3: ketThucChucNang = true; break;
                        case 0: ketThucChucNang = true; ketThuc = true; break;
                    }
                }
            }
        }
    }
}
