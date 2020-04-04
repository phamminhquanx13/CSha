using System;
using System.Linq;

namespace nhanvien
{
    class Program
    {
        struct NHAN_VIEN
        {
            public string Ho_ten;
            public bool Gioi_tinh;
            public DateTime Ng_sinh;
            public int Muc_luong;
        }

        static void Main(string[] args)
        {
            NHAN_VIEN[] Nv;
            //Khai báo mảng Nhân viên Nv_1, Nv_2
            NHAN_VIEN[] Nv_1, Nv_2;
            //Nhập liệu cho Nv
            Console.Write("So luong nhan vien:");
            int n = int.Parse(Console.ReadLine());
            Nv = new NHAN_VIEN[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + "\nHo ten:");
                Nv[i].Ho_ten = Console.ReadLine();
                Console.Write("Gioi tinh:");
                Nv[i].Gioi_tinh = bool.Parse(Console.ReadLine());
                Console.Write("Ngay sinh:");
                Nv[i].Ng_sinh = DateTime.Parse(Console.ReadLine());
                Console.Write("Muc luong:");
                Nv[i].Muc_luong = int.Parse(Console.ReadLine());
            }

            Nv_1 = Nv.Where(x => x.Gioi_tinh == true).ToArray();

             Nv_2 = Nv.Where(x => (DateTime.Today.Year - x.Ng_sinh.Year
            >= 20 && DateTime.Today.Year - x.Ng_sinh.Year <= 40)).ToArray();
           
            string chuoi =
           "\n========================================\nDanh sach nhan vien nam";
            for (int i = 0; i < Nv_1.Length; i++)
            {
                chuoi += "\nHo ten:" + Nv_1[i].Ho_ten;
                chuoi += "\nGioi tinh:" + Nv_1[i].Gioi_tinh;
                chuoi += "\nNgay sinh:" + Nv_1[i].Ng_sinh;
                chuoi += "\nMuc luong:" + Nv_1[i].Muc_luong;
            }
            chuoi += "\n\nDanh sach nhan vien co tuoi tu 20 den 40\n";
            for (int i = 0; i < Nv_2.Length; i++)
            {
                chuoi += "\nHo ten:" + Nv_2[i].Ho_ten;
                chuoi += "\nGioi tinh:" + Nv_2[i].Gioi_tinh;
                chuoi += "\nNgay sinh:" + Nv_2[i].Ng_sinh;
                chuoi += "\nMuc luong:" + Nv_2[i].Muc_luong;
            }
            Console.Write(chuoi);
            Console.ReadLine();
        }
    }
}
