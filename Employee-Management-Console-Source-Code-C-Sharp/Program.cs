using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    public class Program
    {
        public static SalaryController salaryController = new SalaryController();
        public static EmployeeController employeeController = new EmployeeController();
        public static ProjectController projectController = new ProjectController();
        public static void Main(string[] args)
        {
            showMenu();
        }
        public static void showMenu()
        {
            Console.WriteLine("+--------Managerment-------+");
            Console.WriteLine("| 1. Employees Manager     | ");
            Console.WriteLine("| 2. Salaries Manager      | ");
            Console.WriteLine("| 3. Projects Manager      | ");
            Console.WriteLine("| 4. Exit                  | ");
            Console.WriteLine("+--------------------------+");
            string choice = Console.ReadLine();
            ControlChoiceMainMenu(choice);
        }
        public static void showEmployeeMenu()
        {
            Console.WriteLine("+---Employees Managerment--+");
            Console.WriteLine("| 1. View list Employees   | ");
            Console.WriteLine("| 2. Add new Employees     | ");
            Console.WriteLine("| 3. DeleteEmployees       | ");
            Console.WriteLine("| 4. Back                  | ");
            Console.WriteLine("+--------------------------+");
            string choice = Console.ReadLine();
            ControlEmployeeChoiceMenu(choice);
        }
        public static void showSalaiesMenu()
        {
            Console.WriteLine("+----Salaries Managerment----+");
            Console.WriteLine("| 1. View list Salaies       | ");
            Console.WriteLine("| 2. Pay salary for Employee | ");
            Console.WriteLine("| 3. Back                    | ");
            Console.WriteLine("+----------------------------+");
            string choice = Console.ReadLine();
            ControlSalariesChoiceMenu(choice);
        }
        public static void showProjectsMenu()
        {
            Console.WriteLine("+----Projects Managerment----+");
            Console.WriteLine("| 1. View list Projects      | ");
            Console.WriteLine("| 2. Add new Project         | ");
            Console.WriteLine("| 3. Delete Project          | ");
            Console.WriteLine("| 4. Back                    | ");
            Console.WriteLine("+----------------------------+");
            string choice = Console.ReadLine();
            ControlProjectsChoiceMenu(choice);
        }
        public static void ControlChoiceMainMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    showEmployeeMenu();
                    employeeController.ReadEmployeesFromFile();
                    employeeController.ViewEmployeeList();
                    break;
                case "2":
                    showSalaiesMenu(); break;
                case "3":
                    showProjectsMenu(); break;
                case "4":
                    break;
                default:
                    Console.WriteLine("WRONG INPUT !!");
                    showMenu(); break;
            }
        }
        public static void ControlEmployeeChoiceMenu(string choice)
        {
            employeeController.ReadEmployeesFromFile();
            switch (choice)
            {
                case "1":
                     employeeController.ViewEmployeeList();
                     showEmployeeMenu();
                     break;
                case "2":
                    employeeController.AddEmployee();
                    showEmployeeMenu(); 
                    break;
                case "3":
                    employeeController.DeleteEmployee();
                    showEmployeeMenu(); 
                    break;
                case "4":
                    showMenu(); break;
                default:
                    Console.WriteLine("WRONG INPUT !!");
                    showEmployeeMenu(); 
                    break;
            }
        }
        public static void ControlSalariesChoiceMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    employeeController.ReadEmployeesFromFile();
                    salaryController.ViewSalaryList();
                    ControlSalariesChoiceMenu("1"); 
                    break;
                case "2":
                    salaryController.PaidSalary();
                    ControlSalariesChoiceMenu(choice); break;
                case "3":
                    showMenu(); break;
                default:
                    Console.WriteLine("WRONG INPUT !!");
                    showSalaiesMenu(); break;
            }
        }
        public static void ControlProjectsChoiceMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    projectController.ViewProjectList(); showProjectsMenu(); break;
                case "2":
                    projectController.AddProject(); showProjectsMenu(); break;
                case "3":
                    projectController.DeleteProject(); showProjectsMenu(); break;
                case "4":
                    showMenu();
                    break;
                default:
                    Console.WriteLine("WRONG INPUT !!");
                    showProjectsMenu(); break;
            }
        }
    }
}