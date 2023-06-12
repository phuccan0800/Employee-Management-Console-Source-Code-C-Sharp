using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    public class EmployeeController : ObserverController
    {
        public static List<Employee> employees = new List<Employee>();
        Positon manger = new Manager();
        Positon newbie = new Newbie();
        private int LastID = 0;
        public  EmployeeController() { }
        public void ViewEmployeeList()
        {
            foreach (Employee employee in employees) Console.WriteLine(employee.ToString());
        }
        public void AddEmployee()
        {
            int choice = 9;
            LastID++;
            Console.Write("Enter Name of New Employee: ");
            string name = Console.ReadLine();
            do
            {
                Console.Write($"Male or Female ? (1 or 2) (Deafault: Male): ");
                choice = int.Parse(Console.ReadLine());
            }
            while (choice > 2 || choice <1);
            string sex = "Male";
            if (choice == 1) sex = "Male"; 
            else if (choice == 2) sex = "Female";
            Console.Write($"Where ur {name}'s Hometown ?: "); string hometown = Console.ReadLine();
            Console.Write($"Enter {name}'s Birthday: "); DateTime birthday = DateTime.Parse(Console.ReadLine());
            int age = employees[0].CaculatorAge(birthday);
            Console.Write($" Enter {name} Phone number: ");
            string phone = Console.ReadLine();
            DateTime timeJoin = DateTime.Today;
            Console.Write($"Choose position for {name}: \n1.");
            manger.getPositionInfor();
            Console.Write("\n2.");
            newbie.getPositionInfor();
            Console.WriteLine("\n");
            choice = 0;
            do
            {
                Console.Write("Enter Your Choice (1 or 2): ");
                choice = int.Parse(Console.ReadLine());
            }
            while (choice > 2 || choice < 1);
            string positionName = "NULL";
            if (choice == 1) positionName = "Manager";
            else if (choice == 2) positionName = "Newbie";
            Console.Write("Confirm ADD ? (Y or N): ");
            string confirm = Console.ReadLine().ToUpper();
            switch (confirm)
                {
                case "N":
                    LastID--;
                    Console.WriteLine("Cancel !!");
                    break;
                default:
                    Employee employee = new Employee(LastID, name, age, sex, hometown, phone, birthday, timeJoin, positionName, 1);
                    employees.Add(employee);
                    Console.WriteLine("Add Employee Complete !!!");
                    break;
                }
        }
        public void DeleteEmployee() 
        {
            Console.Write("Enter ID of Employee you want to delete: ");
            int IdDelete = int.Parse(Console.ReadLine()) -1;
            Console.Write($"Are you sure for Delete {employees[IdDelete].GetName()}  ? (Y or N): ");
            string confirm = Console.ReadLine().ToUpper();
            switch (confirm)
            {
                case "N":
                    Console.WriteLine("Cancel !!");
                    break;
                default:
                    employees.RemoveAt(IdDelete);
                    Console.WriteLine("Delete Employee Complete !!!");
                    break;
            }
        }
        public void EditEmployee()
        {
            Console.Write("Who you want to edit ? (Input his/her ID) : ");
            int id = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Information: ");
            Console.WriteLine(employees[id].ToString2());
            int choice=0;
            do
            {
                Console.Write("Choose Information you want to edit (1..8): ");
                choice = int.Parse(Console.ReadLine());
            } while (choice > 8 || choice < 1);
            Console.Write($"Enter New Information: ");
            string Information = Console.ReadLine();
            switch (choice)
            {
                case 1:
                    employees[id].SetName(Information);
                    break;
                case 2:
                    employees[id].SetAge(int.Parse(Information));
                    break; 
                case 3:
                    employees[id].SetSex(Information);
                    break;
                case 4:
                    employees[id].SetHometown(Information);
                    break;
                case 5:
                    employees[id].SetPhone(Information);
                    break;
                case 6:
                    employees[id].SetBirthday(DateTime.Parse(Information));
                    break;
                case 7:
                    employees[id].SetTimeJoined(DateTime.Parse(Information));
                    break;
                case 8:
                    employees[id].SetStatus(int.Parse(Information));
                    break;
                default:
                    Console.WriteLine("ERRORR !!! TRY AGAIN !!!!");
                    EditEmployee();
                    break;
            }
            Console.WriteLine("DONE !!!!");
        }
        public void SearchEmployee() 
        {
            Console.Write("Search Input: ");
            string search = Console.ReadLine();
            Console.WriteLine("List Found: ");
            foreach (Employee emp in employees)
            {
                if (emp.GetName().Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                     Console.WriteLine(emp.ToString());
                }
            }
        }
        public void UpdateNewInfo(String Action) 
        { 

        }
        public void ReadEmployeesFromFile()
        {
            string[] inputs = new string[]
            {
                "1|Truong Tan Phuc|21|Male|Le Thuy|84916430598|12-05-2003|2021-05-12|manager|1",
                "2|Nguyen Thi Anh|28|Female|Hanoi|84987654321|15-10-1995|01-01-2022|newbie|1",
                "3|Le Van Tuan|35|Male|Ho Chi Minh City|84123456789|05-07-1988|01-03-2023|manager|1",
                "4|Tran Thi Huong|42|Female|Da Nang|84999999999|20-12-1979|15-09-2022|newbie|1",
                "5|Pham Minh Hieu|33|Male|Can Tho|84888888888|07-03-1988|10-06-2023|manager|1"
            };

            foreach (string input in inputs)
            {
                Employee employee = ParseEmployeeFromLine(input);
                employees.Add(employee);
                LastID++;
            }
        }
        private static Employee ParseEmployeeFromLine(string line)
        {
            string[] data = line.Split('|');
            Employee employee2 = new Employee(int.Parse(data[0]), data[1], int.Parse(data[2]), data[3], data[4], data[5], DateTime.Parse(data[6]), DateTime.Parse(data[7]), data[8], int.Parse(data[9]));
            return employee2;
        }

    }
}
