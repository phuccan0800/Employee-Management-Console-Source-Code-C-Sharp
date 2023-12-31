﻿using System;
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
            employeeController.ReadEmployeesFromFile();
            projectController.ReadProject();
            salaryController.ReadSalary();
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
            Console.WriteLine("| 3. Delete Employees      | ");
            Console.WriteLine("| 4. Search Employees      | ");
            Console.WriteLine("| 5. Edit Employee         | ");
            Console.WriteLine("| 6. Back                  | ");
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
            Console.WriteLine("| 4. Edit Project            |");
            Console.WriteLine("| 5. Back                    | ");
            Console.WriteLine("+----------------------------+");
            string choice = Console.ReadLine();
            ControlProjectsChoiceMenu(choice);
        }
        public static void ControlChoiceMainMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.Clear();  
                    showEmployeeMenu(); break;
                case "2":
                    Console.Clear();
                    showSalaiesMenu(); break;
                case "3":
                    Console.Clear();
                    showProjectsMenu(); break;
                case "4":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("WRONG INPUT !!");
                    showMenu(); break;
            }
        }
        public static void ControlEmployeeChoiceMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                     Console.Clear();
                     employeeController.ViewEmployeeList();
                     showEmployeeMenu();
                     break;
                case "2":
                    Console.Clear();
                    employeeController.AddEmployee();
                    showEmployeeMenu(); 
                    break;
                case "3":
                    employeeController.DeleteEmployee(salaryController);
                    showEmployeeMenu(); 
                    break;
                case "4":
                    Console.Clear();
                    employeeController.SearchEmployee();
                    showEmployeeMenu();
                    break;
                case "5":
                    Console.Clear();
                    employeeController.ViewEmployeeList();
                    employeeController.EditEmployee();
                    showEmployeeMenu();
                    break;
                case "6":
                    Console.Clear();
                    showMenu(); break;
                default:
                    Console.Clear();
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
                    Console.Clear();
                    salaryController.ViewSalaryList();
                    showSalaiesMenu();
                    break;
                case "2":
                    employeeController.ViewEmployeeList();
                    salaryController.PaidSalary();
                    showSalaiesMenu(); break;
                case "3":
                    Console.Clear();
                    showMenu(); break;
                default:
                    Console.Clear();
                    Console.WriteLine("WRONG INPUT !!");
                    showSalaiesMenu(); break;
            }
        }
        public static void ControlProjectsChoiceMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    projectController.ViewProjectList(); showProjectsMenu(); break;
                case "2":
                    projectController.AddProject();
                    Console.Clear(); 
                    showProjectsMenu(); break;
                case "3":
                    Console.Clear();
                    projectController.ViewProjectList();
                    projectController.DeleteProject(); showProjectsMenu(); break;
                case "4":
                    Console.Clear();
                    projectController.ViewProjectList();
                    projectController.EditProject(); showProjectsMenu(); break;
                case "5":
                    Console.Clear();
                    showMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("WRONG INPUT !!");
                    showProjectsMenu(); break;
            }
        }
    }
}