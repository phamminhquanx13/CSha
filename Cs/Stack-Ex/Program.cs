using System;
using System.Collections;
namespace Stack_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack MyStack = new Stack(); // khởi tạo 1 Stack rỗng
            Stack MyStack1 = new Stack(5); // khởi tạo 1 Stack và chỉ định sức chứa ban đầu là 5
            Stack MyStack2 = new Stack(); // khởi tạo 1 Stack rỗng
                                          // Bạn cũng có chỉ định sức chứa(Capacity) ngay lúc khởi tạo bằng cách thông qua constructor được hỗ trợ sẵn:
            Stack MyStack5 = new Stack(5); // khởi tạo 1 Stack và chỉ định sức chứa ban đầu là 5
            //Bạn cũng có thể khởi tạo 1 Stack chứa các phần tử được sao chép từ một danh sách khác:
            // khởi tạo 1 mảng bất kỳ
            ArrayList MyArray = new ArrayList();
            MyArray.Add(5);
            MyArray.Add(9);
            MyArray.Add(10);

            // Khởi tạo 1 Stack và sao chép giá trị của các phần tử từ MyArray vào Stack.
            Stack MyStack3 = new Stack(MyArray);

            // Tạo 1 Stack rỗng
            Stack MyStack7 = new Stack();

            // Thực hiện thêm vài phần tử vào Stack thông qua hàm Push.
            MyStack7.Push("A");
            MyStack7.Push("B");
            MyStack7.Push("C");

            // Thử sử dụng các phương thức của Stack.
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", MyStack7.Count);

            // Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Stack thì ta sẽ dùng Peek.
            Console.WriteLine(" Phan tu dau cua Stack la: {0}", MyStack7.Peek());

            // Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Stack.
            Console.WriteLine(" So phan tu cua Stack sau khi goi ham Peek: {0}", MyStack7.Count);

            // Thực hiện xoá các phần tử ra khỏi Stack.
            Console.WriteLine(" Popping...");
            int Length = MyStack7.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.Write(" " + MyStack7.Pop());
            }
            Console.WriteLine();

            // Kiểm tra lại số phần tử của Stack sau khi Pop
            Console.WriteLine(" So phan tu cua Stack sau khi Pop la: {0}", MyStack7.Count);
        }
    }
}
