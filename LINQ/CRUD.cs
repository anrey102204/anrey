using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    public class CRUD 
    {
        List<Employee> employees = new List <Employee> ();

        public int id, choice;
        public string name, position, newSalary;
        public double salary;

        public void Introduce()
        {
            while (true) 
            {
                Program.Option();
                Console.Write("Enter your Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        ADD();
                        break;
                    case 2:
                        Read();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice Please Choose another!!");
                        break;
                
                }
            
            }
        
        }
        public void ADD()
        {
            Console.WriteLine("\n _ADD Employee_ \n");
            Console.Write("Enter Employee ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Employee Position: ");
            position = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            salary = double.Parse(Console.ReadLine());

            if (!employees.Any(a => a.Id == id))
            {
                employees.Add(new Employee { Id = id, Name = name, Position = position, Salary = salary });
                Console.WriteLine("\nEmployee Added Successfully!!\n");
            }
            else
            {
                Console.WriteLine(" ID Already Exist!!");
            }


        }
        public void Read()
        {
            Console.WriteLine("\n _READ Employee_ \n");
            Program.viewallorReadone();
            Console.Write("Enter your Choice: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("\n_LIST OF EMPLOYEES_");
                Console.WriteLine("\tID  \tNAME  \tPOSITION  \tSALARY");
                foreach (var de in employees)
                {
                    Console.WriteLine($"\t{de.Id}.\t{de.Name}.\t{de.Position}.\t\t{de.Salary}");
                }

            }
            else if (choice == 2)
            {
                Console.Write("Search ID: ");
                id = int.Parse(Console.ReadLine());
                var employee = employees.FirstOrDefault(a => a.Id == id);
                if (employee != null) 
                {
                    Console.WriteLine("_Employee_");
                    Console.WriteLine("\tID  \tNAME  \tPOSITION  \tSALARY");
                    Console.WriteLine($"\t{employee.Id}.\t{employee.Name}.\t{employee.Position}.\t\t{employee.Salary}");
                }
                else 
                {
                    Console.WriteLine("Invalid Choice!!");
                }
            
            
            }
        }
        public void Update() 
        {
            Console.WriteLine("\n _UPDATE Employee_ \n");
            Console.Write("Enter Employee ID: ");
            id = int.Parse(Console.ReadLine());
            var employee = employees.FirstOrDefault(a => a.Id == id);

            if (employee != null)
            {
                Console.Write("Enter new Name (Leave it blank if you change your mind!!");
                name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name)) employee.Name = name;
                Console.WriteLine("Enter new Position (Leave it blank if you change your mind!!): ");
                position = Console.ReadLine();
                if (!string.IsNullOrEmpty(position)) employee.Position = position;
                Console.WriteLine("Enter new Position (Leave it blank if you change your mind!!): ");
                newSalary = Console.ReadLine();
                if (!double.TryParse(newSalary, out double salary)) employee.Salary = salary;

                Console.WriteLine("\nEmployee Updated Succesfully!\n");


            }
            else 
            {
                Console.WriteLine("ID Not Found!!");
            }
        }
        public void Delete() 
        {
            Console.WriteLine("\n_DELETE Employee_\n");
            Console.Write("Enter ID to DELETE: ");
            id = int.Parse(Console.ReadLine());
            var employee = employees.FirstOrDefault(a => a.Id == id);

            if (employee != null) 
            {
                employees.Remove(employee);
                Console.WriteLine("\nEmployee's Profile Deleted Successfully\ns!");
            
            }
            else 
            {
                Console.WriteLine("ID not Found!!");
            }
        }

    }
}
