using System;

namespace Static_EX
{
    class MauSac
    {
        /* Giả sử màu chủ đạo là 1 chuỗi ký tự lưu tên màu tương ứng */
        public static string MauChuDao;
        /* Dùng static constructor để kiểm tra ngày hiện tại và khởi tạo giá trị cho biến tĩnh MauChuDao */
        static MauSac()
        {
            /* Khai báo đối tượng ngày giờ và lấy ngày giờ hiện tại của hệ thống */
            DateTime now = DateTime.Now;

            /* lấy ra thứ của ngày hiện tại và so sánh với 7 ngày trong tuần */
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    MauChuDao = "Black";
                    break;
                case DayOfWeek.Monday:
                    MauChuDao = "Blue";
                    break;
                case DayOfWeek.Saturday:
                    MauChuDao = "Green";
                    break;
                case DayOfWeek.Sunday:
                    MauChuDao = "Yellow";
                    break;
                case DayOfWeek.Thursday:
                    MauChuDao = "Pink";
                    break;
                case DayOfWeek.Tuesday:
                    MauChuDao = "Red";
                    break;
                case DayOfWeek.Wednesday:
                    MauChuDao = "Purple";
                    break;
            }
        }
    }


    class TienIch
    {
        /*
            Khai báo và định nghĩa 1 phương thức tính luỹ thừa 2 số nguyên
         */

        public static long LuyThua(int CoSo, int SoMu)
        {
            long KetQua = 1;
            for (int i = 0; i < SoMu; i++)
            {
                KetQua *= CoSo;
            }

            return KetQua;
        }
    }
    class Cat
    {
        private int weight;
        /*
            Khai báo property tương ứng với thuộc tính.
            Mặc dù trong bài này mình không sử dụng tới nhưng mình vẫn khai báo để nhắc các bạn nhớ tuân thủ tính đóng gói.
         */
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        /*
            Khai báo 1 biến static tên Count để chứa số lượng mèo hiện tại.
            Mỗi lần có 1 đối tượng được tạo ra thì ta sẽ tăng Count lên.
        */

        public static int Count = 0;
     
        public Cat()
        {
            weight = 20;
            height = 500;
            /* Vì constructor chỉ được gọi khi có đối tượng được tạo ra nên ta sẽ tăng Count ở đây */
            Count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("Hello World!");
            /*Console.WriteLine(" So luong meo ban dau: " + Cat.Count);
            Cat BlackCat = new Cat(); // Tạo ra con mèo đầu tiên

            Console.WriteLine(" So luong meo hien tai: " + Cat.Count);

            Cat WhiteCat = new Cat(); // Tạo ra con mèo thứ 2
            Console.WriteLine(" So luong meo hien tai: " + Cat.Count);
            */
            Console.WriteLine(TienIch.LuyThua(3, 3));
            /* In ra màn hình giá trị của thuộc tính màu chủ đạo */
            Console.WriteLine(" Mau chu dao cua hom nay: " + MauSac.MauChuDao);

        }
    }
}
