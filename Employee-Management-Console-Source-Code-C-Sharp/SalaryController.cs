using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    public class SalaryController : ObserverController
    {
        int LastSalaryID=0;
        List<Salary> listSalary = new List<Salary>();
        public SalaryController() { }
        public void ViewSalaryList()
        {
            foreach (Salary salary in listSalary)
            {
                Console.WriteLine(salary.ToString());
            }
        }
        public void PaidSalary()
        {
            int choice = 0;
            do
            {
                Console.Write("Choose Employee (ID): ");
                choice = int.Parse(Console.ReadLine());
            } while (choice < 1);
            Console.Write("How much money you pay (VND) ?: ");
            int paid = int.Parse(Console.ReadLine());
            listSalary[choice - 1].TotalPaidSalary(paid);
            listSalary[choice - 1].SalaryReminingCaculator();
            Console.Clear();
            Console.WriteLine("DONE !!!");
        }
        public void UpdateNewInfor(string Action)
        {

        }
        public void ReadSalary()
        {
            string[] inputs = new string[]
            {
                "1|1|20|5|10000|15000|5000",
                "2|2|22|8|12000|18000|6000",
                "3|3|18|3|8000|12000|4000",
                "4|4|25|10|15000|22000|7000",
                "5|5|21|6|11000|16000|5000"
            };

            foreach (string input in inputs)
            {
                Salary salary = ParseEmployeeFromLine(input);
                listSalary.Add(salary);
                LastSalaryID++;
            }
        }
        private static Salary ParseEmployeeFromLine(string line)
        {
            string[] data = line.Split('|');
            Salary salary2 = new Salary(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]));
            return salary2;
        }
    }
}
