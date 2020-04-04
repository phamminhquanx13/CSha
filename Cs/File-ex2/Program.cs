using System;
using System.IO;
namespace File_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nChuong trinh ghi file trong C#");
            Console.WriteLine("-----------------------------\n");
            string sentence = " ";
            StreamWriter myfile;
            myfile = File.CreateText("test.txt");
            do
            {
                Console.Write("Nhap mot cau text: ");
                sentence = Console.ReadLine();
                if (sentence.Length != 0)
                {
                    myfile.WriteLine(sentence);
                }
            }
            while (sentence.Length != 0);
            myfile.Close();

            Console.ReadKey();
            /*Console.WriteLine("\nChuyen noi dung file thanh chu hoa trong C#:");
            Console.WriteLine("-------------------------------------------\n");
            Console.Write("Nhap ten file ban dau: ");
            string fileName = Console.ReadLine();
            Console.Write("Nhap ten file 2: ");
            string fileName1 = Console.ReadLine();
            if (File.Exists(fileName))
            {
                StreamReader fileRw = File.OpenText(fileName);
                StreamWriter fileWr = File.CreateText(fileName1);
                string line;
                do
                {
                    line = fileRw.ReadLine();
                    if (line != null)
                        fileWr.WriteLine(line.ToUpper());
                }
                while (line != null);
                fileRw.Close();
                fileWr.Close();
            }

            Console.ReadKey();*/
        }
    }
}
