using System;

namespace IF_ELSE_Swich
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int int1, int2;
            Console.Write("\n\n");
            Console.Write("Chuong trinh C# kiem tra hai so co bang nhau khong:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap so thu nhat: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
                Console.WriteLine("{0} va {1} la bang nhau.\n", int1, int2);
            else
                Console.WriteLine("{0} va {1} la khong bang nhau.\n", int1, int2);

            Console.ReadKey();
            */
            //kiem tra chan le
            /* int num1, rem1;
            Console.Write("\n\n");
            Console.Write("Kiem tra chan le trong C#:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot so nguyen bat ky: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} la so chan.\n", num1);
            else
                Console.WriteLine("{0} la so le.\n", num1);

            
               int num;
            Console.Write("\n\n");
            Console.Write("Kiem tra am duong trong C#:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot so nguyen bat ky: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)

                Console.WriteLine("{0} la so duong.\n", num);
            else
                Console.WriteLine("{0} la so am. \n", num);

            Console.ReadKey();
            
            
            int canha, canhb, canhc;
            Console.Write("\n");
            Console.Write("Kiem tra tam giac deu, can, lech trong C#:\n");
            Console.Write("------------------------------------------");
            Console.Write("\n\n");



            Console.Write("Nhap canh a: ");
            canha = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap canh b: ");
            canhb = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap canh c: ");
            canhc = Convert.ToInt32(Console.ReadLine());



            if (canha == canhb && canhb == canhc)
            {
                Console.Write("Day la tam giac deu.\n");
            }
            else if (canha == canhb || canha == canhc || canhb == canhc)
            {
                Console.Write("Day la tam giac can.\n");
            }
            else
            {
                Console.Write("Day la tam giac lech.\n");
            }     

            Console.ReadKey();
            
              int chi_phi, doanh_thu, loi_nhuan;

            Console.Write("\n\n");
            Console.Write("Kiem tra loi nhuan hoac thua lo trong C#:\n");
            Console.Write("-----------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap chi phi: ");
            chi_phi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia ban: ");
            doanh_thu = Convert.ToInt32(Console.ReadLine());

            if (doanh_thu > chi_phi)
            {
                loi_nhuan = doanh_thu - chi_phi;
                Console.Write("\nBan thu duoc loi nhuan: {0}\n", loi_nhuan);
            }
            else if (chi_phi > doanh_thu)
            {
                loi_nhuan = chi_phi - doanh_thu;
                Console.Write("\nBan thua lo: {0}\n", loi_nhuan);
            }
            else
            {
                Console.Write("\nBan khong thu duoc loi nhuan nhung cung khong thua lo.\n");
            }            

              int cdigit;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de nhap so va hien thi so bang chu tuong ung:\n");
            Console.Write("-------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap mot so bat ky (0-9): ");
            cdigit = Convert.ToInt32(Console.ReadLine());

            switch (cdigit)
            {
                case 0:
                    Console.Write("So khong\n");
                    break;

                case 1:
                    Console.Write("So mot\n");
                    break;
                case 2:
                    Console.Write("So hai\n");
                    break;
                case 3:
                    Console.Write("So ba\n");
                    break;
                case 4:
                    Console.Write("So bon\n");
                    break;
                case 5:
                    Console.Write("So nam\n");
                    break;
                case 6:
                    Console.Write("So sau\n");
                    break;
                case 7:
                    Console.Write("So bay\n");
                    break;
                case 8:
                    Console.Write("So tam\n");
                    break;
                case 9:
                    Console.Write("So chin\n");
                    break;
                default:
                    Console.Write("Ban da nhap so khong hop le. Xin nhap lai!!!\n");
                    break;
            }               

            int monno;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de nhap thang va hien thi so ngay tuong ung:\n");
            Console.Write("--------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap thang trong nam: ");
            monno = Convert.ToInt32(Console.ReadLine());
            switch (monno)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("Thang co 31 ngay. \n");
                    break;
                case 2:
                    Console.Write("Thang Hai co 28 ngay. \n");
                    Console.Write("Trong nam nhuan: thang Hai co 29 ngay.\n");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.Write("Thang co 30 ngay. \n");
                    break;
                default:
                    Console.Write("Du lieu khong hop le. Xin ban thu lai!!!\n");
                    break;
            }      
              int lua_chon, r, l, w, b, h;
            double dien_tich = 0;

            Console.Write("\n");
            Console.Write("Chuong trinh C# duoi dang mot menu co cac lua chon de tinh dien tich:\n");
            Console.Write("--------------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Lua chon 1: tinh dien tich hinh tron\n");
            Console.Write("Lua chon 2: tinh dien tich hinh chu nhat\n");
            Console.Write("Lua chon 3: tinh dien tich hinh tam giac\n");
            Console.Write("Nhap lua chon cua ban: ");
            lua_chon = Convert.ToInt32(Console.ReadLine());

            switch (lua_chon)
            {
                case 1:
                    Console.Write("Nhap ban kinh hinh trong: ");
                    r = Convert.ToInt32(Console.ReadLine());
                    dien_tich = 3.14 * r * r;
                    break;
                case 2:
                    Console.Write("Nhap chieu dai HCN: ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap chieu rong HCN: ");
                    w = Convert.ToInt32(Console.ReadLine());
                    dien_tich = l * w;
                    break;
                case 3:
                    Console.Write("Nhap canh huyen tam giac:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap chieu cao tam giac:");
                    h = Convert.ToInt32(Console.ReadLine());
                    dien_tich = 0.5 * b * h;
                    break;
            }
            Console.Write("Dien tich hinh la: {0}\n", dien_tich);      
            \*/
            int num1, num2, opt;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de hien thi menu co cac lua chon\nde thuc hien cac phep toan co ban:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap so nguyen thu nhat: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen thu hai: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nDuoi day la cac lua chon:\n");
            Console.Write("1 - Phep cong.\n2 - Phep tru.\n3 - Phep nhan.\n4 - Phep chia.\n5 - Thoat.\n");
            Console.Write("\nNhap lua chon cua ban: ");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.Write("Tong hai so {0} va {1} la: {2}\n", num1, num2, num1 + num2);
                    break;

                case 2:
                    Console.Write("Hieu cua {0} va {1} la: {2}\n", num1, num2, num1 - num2);
                    break;

                case 3:
                    Console.Write("Tich cua {0} va {1} la: {2}\n", num1, num2, num1 * num2);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.Write("Neu so thu hai = 0 --> Khong thuc hien duoc phep chia cho so 0.\n");
                    }
                    else
                    {
                        Console.Write("Thuong cua {0} va {1} la: {2}\n", num1, num2, num1 / num2);
                    }
                    break;

                case 5:
                    break;

                default:
                    Console.Write("Nhap tuy chon ko hop le\n");
                    break;
            }                        
        }
        
    }
}
