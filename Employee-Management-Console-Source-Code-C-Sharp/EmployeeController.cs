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
        public  EmployeeController() { }
        public void ViewEmployeeList()
        {
            foreach (Employee employee in employees) Console.WriteLine(employee.ToString());
        }
        public void AddEmployee()
        {

        }
        public void DeleteEmployee() 
        {
            
        }
        public void EditEmployee()
        {

        }
        public void SearchEmployee(string input) 
        {
        
        }
        public void UpdateNewInfo(String Action) { }
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
            }
        }
        private static Employee ParseEmployeeFromLine(string line)
        {
            string[] data = line.Split('|');
            Console.WriteLine(data[0]);
            Employee employee2 = new Employee(int.Parse(data[0]), data[1], int.Parse(data[2]), data[3], data[4], data[5], data[6], DateOnly.Parse(data[7]), data[8], int.Parse(data[9]));
            return employee2;
        }

    }
}
