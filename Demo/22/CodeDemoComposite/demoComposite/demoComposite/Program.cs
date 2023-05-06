using System;
using System.Text;
using demoComposite.Composite;
using demoComposite.Leaf;
using System.Collections.Generic;

using demoComposite.Client;

namespace demoComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            CongTy cty = new CongTy();
            cty.ThemDuLieuMacDinh();

            cty.HienThiNhanVien(10);

        }
    }
}
