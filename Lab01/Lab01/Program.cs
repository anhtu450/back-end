using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Lab01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Config Console Output được tiếng việt
//            Console.OutputEncoding = Encoding.UTF8;
//            //1. Khai báo biến
//            int x1, x2, y1, y2;
//            //2. Nhập giá trị
//            Console.WriteLine("Nhập điểm A(x1, y1): ");
//            Console.Write("x1 = ");
//            x1 = int.Parse(Console.ReadLine());
//            Console.Write("y1 = ");
//            y1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Nhập điểm B(x2, y2): ");
//            Console.Write("x2 = ");
//            x2 = int.Parse(Console.ReadLine());
//            Console.Write("y2 = ");
//            y2 = int.Parse(Console.ReadLine());
//            //3. Tính khoảng cách
//            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//            //4. Xuất kết quả
//            Console.WriteLine($"Khoảng cách giữa điểm A({x1}, {y1}) với điểm B({ x2}, { y2}) là: {distance}");
//        }
//    }
//}
//Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo " Xin chào [tên], bạn [tuổi] tuổi".
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap ten cua ban: ");
//        string name = Console.ReadLine();
//        Console.WriteLine("Nhap tuoi cua ban: ");
//        int age = int.Parse(Console.ReadLine());
//        Console.WriteLine($"Xin chao {name}, ban {age} tuoi.");
//    }
//}
//Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng.
//class RectangleAreaCalculator
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap chieu dai: ");
//        double length = double.Parse(Console.ReadLine());
//        Console.WriteLine("Nhap chieu rong: ");
//        double width = double.Parse(Console.ReadLine());
//        double area = length * width;
//        Console.WriteLine($"Dien tich hinh chu nhat la: {area}");
//    }
//}
//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F Công thức: F = (C * 9/5) + 32
//class TemperatureConverter
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap nhiet do (do C): ");
//        double celsius = double.Parse(Console.ReadLine());
//        double fahrenheit = (celsius * 9 / 5) + 32;
//        Console.WriteLine($"Nhiet do {celsius} do C tuong duong voi {fahrenheit} do F.");
//    }
//}
//Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.
//class EvenOddChecker
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap mot so nguyen: ");
//        int number = int.Parse(Console.ReadLine());
//        if (number % 2 == 0)
//        {
//            Console.WriteLine($"{number} la so chan.");
//        }
//        else
//        {
//            Console.WriteLine($"{number} la so le.");
//        }
//    }
//}
//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
//class SumAndProductCalculator
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap so thu nhat: ");
//        int number1 = int.Parse(Console.ReadLine());
//        Console.WriteLine("Nhap so thu hai: ");
//        int number2 = int.Parse(Console.ReadLine());
//        int sum = number1 + number2;
//        int product = number1 * number2;
//        Console.WriteLine($"Tong: {sum}");
//        Console.WriteLine($"Tich: {product}");
//    }
//}
//Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.
//class NumberSignChecker
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap mot so: ");
//        double number = double.Parse(Console.ReadLine());
//        if (number > 0)
//        {
//            Console.WriteLine($"{number} la so duong.");
//        }
//        else if (number < 0)
//        {
//            Console.WriteLine($"{number} la so am.");
//        }
//        else
//        {
//            Console.WriteLine($"{number} la so khong.");
//        }
//    }
//}
//Bài 7:Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
//(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho 400).
//class LeapYearChecker
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap mot nam: ");
//        int year = int.Parse(Console.ReadLine());
//        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
//        {
//            Console.WriteLine($"{year} la nam nhuan.");
//        }
//        else
//        {
//            Console.WriteLine($"{year} khong phai la nam nhuan.");
//        }
//    }
//}
//Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.
//class MultiplicationTable
//{
//    static void Main()
//    {
//        Console.WriteLine("Bang cuu chuong:");
//        for (int i = 1; i <= 10; i++)
//        {
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.Write($"{i} x {j} = {i * j}\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
//class FactorialCalculator
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap mot so nguyen duong: ");
//        int n = int.Parse(Console.ReadLine());
//        long factorial = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            factorial *= i;
//        }
//        Console.WriteLine($"Giai thua cua {n} la: {factorial}");
//    }
//}
//Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
//class PrimeNumberChecker
//{
//    static void Main()
//    {
//        Console.WriteLine("Nhap mot so nguyen: ");
//        int number = int.Parse(Console.ReadLine());
//        bool isPrime = true;
//        if (number < 2)
//        {
//            isPrime = false;
//        }
//        else
//        {
//            for (int i = 2; i <= Math.Sqrt(number); i++)
//            {
//                if (number % i == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }
//        }
//        if (isPrime)
//        {
//            Console.WriteLine($"{number} la so nguyen to.");
//        }
//        else
//        {
//            Console.WriteLine($"{number} khong phai la so nguyen to.");
//        }
//    }
//}