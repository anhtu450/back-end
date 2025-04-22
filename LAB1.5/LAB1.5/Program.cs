//using LAB1._5;
//using System.Collections.Generic;

//public class Program
//{
//    //Bước 3: Mở Program.cs tạo danh sách sinh viên như sau
//    public static List<Student> student = new()
//    {
//        new() { studentId = "1", studentName = "Nguyen Van A", age = 20, phone = "0333912821", address = "Hà Nội" },
//        new() { studentId = "2", studentName = "Nguyen Van B", age = 20, phone = "0333912822", address = "Phú Thọ" },
//        new() { studentId = "3", studentName = "Nguyen Van C", age = 20, phone = "0333912823", address = "Thái Bình" },
//        new() { studentId = "4", studentName = "Nguyen Van D", age = 20, phone = "0333912824", address = "Hưng Yên" },
//        new() { studentId = "5", studentName = "Nguyen Van E", age = 20, phone = "0333912825", address = "Hà Nội" },
//    };
//    //Bước 4: Xây dựng các hàm hiển thị, thêm, sửa, xoá sinh viên
//    public static bool addStudent(Student student)
//    {
//        try
//        {
//            bool isExist = Program.student.Where(x => x.studentId == student.studentId).Count() > 0;
//            if (isExist)
//                throw new Exception("Sinh viên đã tồn tại!");
//            Program.student.Add(student);
//            return true;
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//            return false;
//        }
//    }
//    public static bool editStudent(Student student)
//    {
//        foreach (var item in Program.student)
//        {
//            if (item.studentId == student.studentId)
//            {
//                item.studentName = student.studentName;
//                item.age = student.age;
//                item.address = student.address;
//                item.phone = student.phone;
//                return true;
//            }
//        }
//        return false;
//    }
//    public static bool deleteStudent(Student studentToDelete)
//    {
//        try
//        {
//            var studentToRemove = Program.student.FirstOrDefault(s => s.studentId == studentToDelete.studentId);
//            if (studentToRemove != null)
//            {
//                Program.student.Remove(studentToRemove);
//                return true;
//            }
//            return false;
//        }
//        catch
//        {
//            return false;
//        }
//    }
//    public static void getStudents()
//    {
//        Console.WriteLine("ID\tNAME\t\tAGE\tPHONE\t\tADDRESS");
//        foreach (var item in Program.student)
//        {
//            Console.WriteLine($"{item.studentId}\t{item.studentName}\t{item.age}\t{item.phone}\t{item.address}");
//        }
//    }
//    //Bước 5: Xây dựng hàm thông báo và hiển thị menu
//    public static void alert(bool isSuccess, string action)
//    {
//        string message = isSuccess ? $"{action} thành công!" : $"{action} thất bại!";
//        Console.WriteLine(message);
//        Console.WriteLine("Press any key to continue...");
//        Console.ReadLine();
//    }
//    public static void getMenu()
//    {
//        int n;
//        do
//        {
//            Console.Clear();
//            Console.WriteLine("-----------------------Quản lý sinh viên-----------------------");

//            getStudents();
//            Console.WriteLine("---------------------------------------------------------------");

//            Console.WriteLine("\t1. Thêm sinh viên");
//            Console.WriteLine("\t2. Sửa sinh viên");
//            Console.WriteLine("\t3. Xoá sinh viên");
//            Console.WriteLine("\t4. Thoát");
//            do
//            {
//                Console.Write("- Mời bạn chọn chức năng: ");
//                n = int.Parse(Console.ReadLine());
//            } while (n > 4 || n < 1);
//            switch (n)
//            {
//                case 1:
//                    {
//                        Student student = new Student(); 
//                        Console.Write("- Nhập ID: ");
//                        student.studentId = Console.ReadLine();
//                        Console.Write("- Nhập họ tên: ");
//                        student.studentName = Console.ReadLine();
//                        Console.Write("- Nhập tuổi: ");
//                        student.age = int.Parse(Console.ReadLine()); 
//                        Console.Write("- Nhập địa chỉ: ");
//                        student.address = Console.ReadLine();
//                        Console.Write("- Nhập số điện thoại: ");
//                        student.phone = Console.ReadLine();
//                        alert(addStudent(student), "Thêm");
//                    }
//                    break;
//                case 2:
//                    {
//                        Console.Write("- Chọn ID sinh viên muốn sửa: ");
//                        string id = Console.ReadLine();
//                        Student student = Program.student.First(x => x.studentId == id); 
//                        Console.Write("- Nhập họ tên: ");
//                        student.studentName = Console.ReadLine();
//                        Console.Write("- Nhập tuổi: ");
//                        student.age = int.Parse(Console.ReadLine()); 
//                        Console.Write("- Nhập địa chỉ: ");
//                        student.address = Console.ReadLine();
//                        Console.Write("- Nhập số điện thoại: ");
//                        student.phone = Console.ReadLine();
//                        alert(editStudent(student), "Sửa");
//                    }
//                    break;
//                case 3:
//                    {
//                        Console.Write("- Chọn ID sinh viên muốn xoá: ");
//                        string id = Console.ReadLine();
//                        alert(deleteStudent(Program.student.First(x => x.studentId == id)), "Xoá"); 
//                    }
//                    break;
//                default:
//                    break;
//            }
//        } while (n != 4);
//    }
//    //Bước 6: Gọi hàm hiển thị menu
//    static void Main(string[] args)
//    {
//        //Config Console Output được Tiếng Việt
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        getMenu();
//    }
//}
