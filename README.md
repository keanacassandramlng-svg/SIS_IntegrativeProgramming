using System;

class Program
{
    static void Main()
    {
       
        string name = "";
        string birthday = "";
        string address = "";
        string contact = "";
        string studentNumber = "";
        string status = "None";

        bool hasApplied = false;

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
                if (hasApplied)
                {
                    Console.WriteLine("Student already applied.");
                    continue;
                }

                Console.Write("Enter Name: ");
                name = Console.ReadLine();

                Console.Write("Enter Birthday: ");
                birthday = Console.ReadLine();

                Console.Write("Enter Address: ");
                address = Console.ReadLine();

                Console.Write("Enter Contact Number: ");
                contact = Console.ReadLine();

                studentNumber = "2024-00104-BM-0";
                status = "Applicant";
                hasApplied = true;

                Console.WriteLine("Application successful!");
                Console.WriteLine("Generated Student Number: " + studentNumber);
            }

            
            else if (choice == "2")
            {
                if (!hasApplied)
                {
                    Console.WriteLine("No application found.");
                }
                else
                {
                    Console.Write("Enter Name: ");
                    string inputName = Console.ReadLine();

                    Console.Write("Enter Student Number: ");
                    string inputNumber = Console.ReadLine();

                    if (inputName == name && inputNumber == studentNumber)
                    {
                        if (status == "Applicant")
                        {
                            status = "Enrolled";
                            Console.WriteLine("Student enrolled successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Student cannot enroll. Current status: " + status);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect name or student number.");
                    }
                }
            }

            
            else if (choice == "3")
            {
                if (status == "Enrolled")
                {
                    status = "Deactivated";
                    Console.WriteLine("Student account deactivated.");
                }
                else
                {
                    Console.WriteLine("Only enrolled students can be deactivated.");
                }
            }

            
            else if (choice == "4")
            {
                if (status == "Enrolled")
                {
                    status = "Graduated";
                    Console.WriteLine("Congratulations! Student graduated.");
                }
                else
                {
                    Console.WriteLine("Only enrolled students can graduate.");
                }
            }

            
            else if (choice == "5")
            {
                if (status == "Enrolled")
                {
                    status = "On Leave";
                    Console.WriteLine("Student is now on leave of absence.");
                }
                else
                {
                    Console.WriteLine("Only enrolled students can file leave.");
                }
            }

            
            else if (choice == "6")
            {
                if (!hasApplied)
                {
                    Console.WriteLine("No student record found.");
                }
                else
                {
                    Console.WriteLine("\n===== STUDENT INFORMATION =====");
                    Console.WriteLine("Student Number: " + studentNumber);
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Birthday: " + birthday);
                    Console.WriteLine("Address: " + address);
                    Console.WriteLine("Contact: " + contact);
                    Console.WriteLine("Status: " + status);
                }
            }

            
            else if (choice == "7")
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice.");
        }
        }
    }
}
