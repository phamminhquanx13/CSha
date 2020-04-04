using System;

namespace Phamvitruycap
{
    class SinhVien
    {

        private string MASV;
        private string HoTen;
        private double DiemToan;
        private double DiemVan;

        /*
            Đây là phương thức truy vấn giá trị của thuộc tính MASV
            Vì thế phương thức sẽ trả về string (trùng với kiểu dữ liệu của thuộc tính MASV)
         */
        public string getMASV()
        {
            return MASV;
        }

        /*
            Đây là phương thức cập nhật giá trị cho thuộc tính DiemToan
            Vì thế phương thức có 1 tham số truyền vào kiểu double trùng với kiểu của DiemToan.
         */
        private double diemLy;
        public double DiemLy
        {
            get { return diemLy; }
            set { diemLy = value; }
        }

        public void setDiemToan(int diemtoan)
        {
            DiemToan = diemtoan;
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();
            SV1.DiemLy=8;
            Console.WriteLine(SV1.DiemLy);
        
        }
    }
}
