﻿using System;
using System.Collections;

namespace HasTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable MyHash = new Hashtable(); // khởi tạo 1 Hashtable rỗng
            Hashtable MyHash2 = new Hashtable(5); // khởi tạo 1 Hashtable và chỉ định Capacity ban đầu là 5
            /*
            * Khởi tạo 1 Hashtable có kích thước bằng với MyHash2.
            * Sao chép toàn độ phần tử trong MyHash2 vào MyHash3.
            */
            Hashtable MyHash3 = new Hashtable(MyHash2);
            // Tạo một Hashtable đơn giản với 3 phần tử
            Hashtable hash = new Hashtable();
            hash.Add("A", "quân1");
            hash.Add("B", "quân2");
            hash.Add("C", "quân3");
            Console.WriteLine(hash['A']);

            
            /* 
             * Duyệt qua các phần tử trong Hashtable.
            * Vì mỗi phần tử là 1 DictionaryEntry nên ta chỉ định kiểu dữ liệu cho item là DictionaryEntry luôn.
             * Thử in ra màn hình cặp Key - Value của mỗi phần tử được duyệt.
             */
           foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);   
            }
            // In ra màn hình giá trị Value trong 1 Key không tồn tại.
            Console.WriteLine(hash["VT"]);

            // Để chắc chắn là null ta thử kiểm tra bằng điều kiện if.
            if (hash["VT"] == null)
            {
                Console.WriteLine("Key 'VT' is not exists");
            }

            // Thử in ra số phần tử ban đầu của Hashtable
            Console.WriteLine("\nCount: " + hash.Count);
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            // thực hiện gán giá trị cho 1 Key không tồn tại.
            hash["D"] = "quan4";

            // thực hiện in lại số phần tử của Hashtable để thấy sự thay đổi.
            Console.WriteLine("\nCount: " + hash.Count);
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
    }
}
