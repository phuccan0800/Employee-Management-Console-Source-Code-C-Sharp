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
            string input = "1|Truong Tan Phuc|21|Male|Le Thuy|84916430598|12-05-2003|12-05-2021|manager|1";
            Employee employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "2|Nguyen Thi Anh|28|Female|Hanoi|84987654321|15-10-1995|01-01-2022|newbie|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "3|Le Van Tuan|35|Male|Ho Chi Minh City|84123456789|05-07-1988|01-03-2023|manager|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "4|Tran Thi Huong|42|Female|Da Nang|84999999999|20-12-1979|15-09-2022|newbie|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "5|Pham Minh Hieu|33|Male|Can Tho|84888888888|07-03-1988|10-06-2023|manager|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "6|Vu Thi Thu|29|Female|Ha Long|84777777777|25-08-1992|05-02-2023|newbie|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "7|Hoang Van Nam|27|Male|Hai Phong|84666666666|02-06-1996|01-01-2022|manager|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "8|Tran Thi Mai|38|Female|Nha Trang|84555555555|18-09-1983|01-01-2023|newbie|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "9|Nguyen Van Hoa|31|Male|Vung Tau|84444444444|11-11-1990|15-03-2022|manager|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "10|Le Thi Huong|36|Female|Hue|84333333333|29-07-1987|20-05-2023|newbie|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "11|Pham Van Dung|32|Male|Da Lat|84222222222|03-04-1991|01-01-2023|manager|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "12|Do Thi Hanh|25|Female|Quy Nhon|84111111111|22-02-1998|01-02-2022|newbie|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
            input = "13|Nguyen Van Hieu|39|Male|Bien Hoa|84999999998|14-12-1982|01-03-2023|manager|1";
            employee = ParseEmployeeFromLine(input);
            employees.Add(employee);
        }
        private static Employee ParseEmployeeFromLine(string line)
        {
            string[] data = line.Split('|');
            Employee employee = new Employee(int.Parse(data[0]), data[1], int.Parse(data[2]), data[3], data[4], data[5], data[6], DateOnly.Parse(data[7]), data[8], int.Parse(data[9]));
            return employee;
        }

    }
}
