using System;

namespace sinhnhat
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime Ng_s;
            string Thu = "";
            Console.Write("Nhap ngay sinh:");
            Ng_s = DateTime.Parse(Console.ReadLine());
            DateTime Ng_sn = new DateTime(DateTime.Today.Year,
           Ng_s.Month, Ng_s.Day);
            if (Ng_sn.DayOfWeek == DayOfWeek.Sunday)
                Thu = "Chu Nhat";
            else if (Ng_sn.DayOfWeek == DayOfWeek.Monday)
                Thu = "Thu Hai";
            else if (Ng_sn.DayOfWeek == DayOfWeek.Tuesday)
                Thu = "Thu Ba";
            else if (Ng_sn.DayOfWeek == DayOfWeek.Wednesday)
                Thu = "Thu Tu";
            else if (Ng_sn.DayOfWeek == DayOfWeek.Thursday)
                Thu = "Thu Nam";
            else if (Ng_sn.DayOfWeek == DayOfWeek.Friday)
                Thu = "Thu Sau";
            else if (Ng_sn.DayOfWeek == DayOfWeek.Saturday)
                Thu = "Thu Bay";
            string chuoi = "Ngay sinh nhat:" + Thu + " Ngay " +
           Ng_sn.Day + " Thang " + Ng_sn.Month + " Nam " + Ng_sn.Year;
            Console.Write(chuoi);
            Console.ReadLine();
        }
    }
}
