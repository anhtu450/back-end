using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Lab1._2
//{
//    internal class Program
//    {
//        static void NhapMang(int[] a, int n)
//        {
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"Nhap phan tu a[{i}]: ");
//                a[i] = int.Parse(Console.ReadLine());
//            }
//        }
//        public static void TinhTong(int[] a, int n)
//        {
//            int tong = 0;
//            for (int i = 0; i < n; i++)
//            {
//                tong += a[i];
//            }
//            Console.WriteLine($"Tong cac phan tu trong mang la: {tong}");
//        }
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            // Khai báo biến
//            int n;
//            // Nhập giá trị cho biến n
//            Console.Write("Nhap n: ");
//            n = int.Parse(Console.ReadLine());
//            // Khai báo và khởi tạo mảng số nguyên có n phần tử
//            int[] a = new int[n];
//            // Gọi hàm nhâp mảng
//            NhapMang(a, n);
//            // Gọi hàm tính tổng các phần tử trong mảng và in ra kết quả
//            TinhTong(a, n);
//        }
//    }
//}
//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
//class Program
//{
//    static int SumEvenNumbers(int[] numbers)
//    {
//        return numbers.Where(n => n % 2 == 0).Sum();
//    }

//    static void Main()
//    {
//        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        Console.WriteLine("Tong cac so chan: " + SumEvenNumbers(arr));
//    }
//}
//Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím.
//Viết hàm để kiểm tra xem một số có phải là số nguyên tố hay không,
//hiển thị chỉ số và giá trị của những phần tử là số nguyên tố trong mảng.
//class Program
//{
//    static bool IsPrime(int n)
//    {
//        if (n < 2)
//            return false;
//        for (int i = 2; i * i <= n; i++)
//        {
//            if (n % i == 0)
//                return false;
//        }
//        return true;
//    }

//    static void Main()
//    {
//        Console.Write("Nhap so luong phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i}: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Cac so nguyen to trong mang va chi so cua chung:");
//        for (int i = 0; i < n; i++)
//        {
//            if (IsPrime(arr[i]))
//            {
//                Console.WriteLine($"Chi so: {i}, Gia tri: {arr[i]}");
//            }
//        }
//    }
//}
//Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập từ bàn phím.
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap so luong phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = new int[n];
//        int positiveCount = 0, negativeCount = 0;

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            arr[i] = int.Parse(Console.ReadLine());

//            if (arr[i] > 0)
//                positiveCount++;
//            else if (arr[i] < 0)
//                negativeCount++;
//        }

//        Console.WriteLine($"So luong so dương: {positiveCount}");
//        Console.WriteLine($"So luong so am: {negativeCount}");
//    }
//}
//Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap so luong phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        int secondLargest = FindSecondLargest(arr);
//        Console.WriteLine($"So lon thu hai trong mang la: {secondLargest}");
//    }

//    static int FindSecondLargest(int[] arr)
//    {
//        int largest = int.MinValue;
//        int secondLargest = int.MinValue;

//        foreach (int num in arr)
//        {
//            {
//                secondLargest = num;
//            }
//            if (num > largest)
//            {
//                secondLargest = largest;
//                largest = num;
//            }
//            else if (num > secondLargest && num < largest)
//        }

//        if (secondLargest == int.MinValue)
//        {
//            Console.WriteLine("Mang không co so lon thu hai.");
//            return -1; // Trả về giá trị không hợp lệ nếu không có số lớn thứ hai
//        }

//        return secondLargest;
//    }
//}

//Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
//class Program
//{
//    static void Swap(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }
//    static void Main()
//    {
//        Console.Write("Nhap so a: ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Write("Nhap so b: ");
//        int b = int.Parse(Console.ReadLine());
//        Console.WriteLine($"Truoc khi hoan vi: a = {a}, b = {b}");
//        Swap(ref a, ref b);
//        Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
//    }
//}
//Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
//class Program
//{
//    static void SortArray(float[] arr)
//    {
//        Array.Sort(arr);
//    }
//    static void Main()
//    {
//        Console.Write("Nhap so luong phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());
//        float[] arr = new float[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i}: ");
//            arr[i] = float.Parse(Console.ReadLine());
//        }
//        SortArray(arr);
//        Console.WriteLine("Mang sau khi sap xep theo thu tu tang dan:");
//        foreach (float num in arr)
//        {
//            Console.Write(num + " ");
//        }
//    }
//}



