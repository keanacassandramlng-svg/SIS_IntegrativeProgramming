using SISProject.Services;
using System;

namespace SISProject.MainProgram
{
    class Program
    {
        static void Main()
        {
            var studentService = new StudentService();

            while (true)
            {
                Console.WriteLine("\n===== STUDENT INFORMATION SYSTEM =====");
                Console.WriteLine("1. Apply");
                Console.WriteLine("2. Enroll");
                Console.WriteLine("3. Deactivate");
                Console.WriteLine("4. Graduate");
                Console.WriteLine("5. Leave of Absence");
                Console.WriteLine("6. Show Student Info");
                Console.WriteLine("7. Exit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Birthday: ");
                    string birthday = Console.ReadLine();

                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();

                    Console.Write("Enter Contact: ");
                    string contact = Console.ReadLine();

                    var student = studentService.Apply(name, birthday, address, contact);
                    Console.WriteLine($"Application successful! Student Number: {student.StudentNumber}");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Student Number: ");
                    string number = Console.ReadLine();

                    if (studentService.Enroll(name, number))
                        Console.WriteLine("Student enrolled successfully!");
                    else
                        Console.WriteLine("Cannot enroll. Check name/student number or status.");
                }
                else if (choice == "3")
                {
                    Console.Write("Enter Student Number: ");
                    string number = Console.ReadLine();

                    if (studentService.Deactivate(number))
                        Console.WriteLine("Student deactivated.");
                    else
                        Console.WriteLine("Cannot deactivate. Must be enrolled.");
                }
                else if (choice == "4")
                {
                    Console.Write("Enter Student Number: ");
                    string number = Console.ReadLine();

                    if (studentService.Graduate(number))
                        Console.WriteLine("Student graduated!");
                    else
                        Console.WriteLine("Cannot graduate. Must be enrolled.");
                }
                else if (choice == "5")
                {
                    Console.Write("Enter Student Number: ");
                    string number = Console.ReadLine();

                    if (studentService.LeaveOfAbsence(number))
                        Console.WriteLine("Student is now on leave.");
                    else
                        Console.WriteLine("Cannot take leave. Must be enrolled.");
                }
                else if (choice == "6")
                {
                    Console.Write("Enter Student Number: ");
                    string number = Console.ReadLine();

                    var student = studentService.GetStudent(number);
                    if (student != null)
                    {
                        Console.WriteLine($"\nStudent Number: {student.StudentNumber}");
                        Console.WriteLine($"Name: {student.Name}");
                        Console.WriteLine($"Birthday: {student.Birthday}");
                        Console.WriteLine($"Address: {student.Address}");
                        Console.WriteLine($"Contact: {student.Contact}");
                        Console.WriteLine($"Status: {student.Status}");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                }
                else if (choice == "7")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }
}
