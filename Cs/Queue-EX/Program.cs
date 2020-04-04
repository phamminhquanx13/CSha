using System;
using System.Collections;
namespace Queue_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue MyQueue = new Queue(); // khởi tạo 1 Queue rỗng
            Queue MyQueue2 = new Queue(5); // khởi tạo 1 Queue và chỉ định sức chứa ban đầu là 5
                                           // khởi tạo 1 mảng bất kỳ
            ArrayList MyArray = new ArrayList();
            MyArray.Add(5);
            MyArray.Add(9);
            MyArray.Add(10);

            // Khởi tạo 1 Queue và sao chép giá trị của các phần tử từ MyArray vào Queue.
            Queue MyQueue3 = new Queue(MyArray);


            // Tạo 1 Queue rỗng
            Queue MyQueue4 = new Queue();

            // Thực hiện thêm vài phần tử vào Queue thông qua hàm Enqueue.
            MyQueue4.Enqueue("A");
            MyQueue4.Enqueue("B");
            MyQueue4.Enqueue("C");

            // Thử sử dụng các phương thức của Queue.
            Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", MyQueue4.Count);

            // Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Queue thì ta sẽ dùng Peek.
            Console.WriteLine(" Phan tu dau cua Queue la: {0}", MyQueue4.Peek());

            // Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Queue.
            Console.WriteLine(" So phan tu cua Queue sau khi goi ham Peek: {0}", MyQueue4.Count);

            // Thực hiện xoá các phần tử ra khỏi Queue thông qua hàm Dequeue.
            Console.WriteLine(" Popping...");
            int Length = MyQueue4.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.Write(" " + MyQueue4.Dequeue());
            }
            Console.WriteLine();

            // Kiểm tra lại số phần tử của Queue sau khi Pop
            Console.WriteLine(" So phan tu cua Queue sau khi Pop la: {0}", MyQueue4.Count);


        }
    }
}
