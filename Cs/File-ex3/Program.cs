using System;
using System.IO;

namespace File_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = true;

            Console.WriteLine("\nDem so lan xuat hien cua chu cai trong File:");
            Console.WriteLine("-----------------------------------------------\n");
            Console.Write("Nhap ten file: ");
            string nameFile = Console.ReadLine();
            Console.Write("Nhap chu cai can dem: ");
            string letter = Console.ReadLine();

            StreamReader myfile;
            myfile = File.OpenText(nameFile);

            string line;
            int countLetter = 0;
            do
            {
                line = myfile.ReadLine();
                if (line != null)
                    for (int i = 0; i < line.Length; i++)
                        if (line.Substring(i, 1) == letter)
                            countLetter++;
            }
            while (line != null);
            myfile.Close();

            Console.WriteLine("So lan xuat hien cua chu cai trong file la: {0}", countLetter);

            if (debug)
                Console.ReadLine();

            Console.ReadKey();
            /*
            Console.WriteLine("\nSo sanh hai file trong C#:");
            Console.WriteLine("--------------------------\n");
            bool equal = true;

            FileStream myFile1;
            byte[] dataFile1;
            FileStream myFile2;
            byte[] dataFile2;

            Console.Write("Nhap ten cua file1: ");
            string fileName1 = Console.ReadLine();

            Console.Write("Nhap ten cua file2: ");
            string fileName2 = Console.ReadLine();

            if ((!File.Exists(fileName1)) || (!File.Exists(fileName2)))
            {
                Console.WriteLine("File1 va File2 khong ton tai!!!");
                return;
            }

            try
            {
                myFile1 = File.OpenRead(fileName1);
                dataFile1 = new byte[myFile1.Length];
                myFile1.Read(dataFile1, 0, (int)myFile1.Length);

                myFile2 = File.OpenRead(fileName2);
                dataFile2 = new byte[myFile2.Length];
                myFile2.Read(dataFile2, 0, (int)myFile2.Length);

                if (myFile1.Length == myFile2.Length) {
                    for (int i = 0; i < dataFile1.Length; i++) {
                        if (dataFile1[i] != dataFile2[i])
                        {
                            equal = false;
                        }
                        else {
                            equal = true;
                        }
                    }
                }
                if (equal)
                {
                    Console.WriteLine("{0} la dong nhat voi {1}", fileName1, fileName2);
                }
                else {
                    Console.WriteLine("{0} khong dong nhat {1}", fileName1, fileName2);
                }

                Console.ReadLine();

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}!!!", e.Message);
            }
            */
        }
    }
}
