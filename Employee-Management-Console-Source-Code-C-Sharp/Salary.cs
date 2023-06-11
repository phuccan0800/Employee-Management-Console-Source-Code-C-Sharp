using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    internal class Salary 
    {
        private Employee employee = new Employee();
        Positon manager = new Manager();
        Positon newbie = new Newbie();
        private int DayWork {  get; set; } 
        private int OverTime { get; set; }
        private int PaidSalary;
        private int TotalSalary;
        private int RemaningSalary;
        public int SalaryTotalCaculattion() { return 0; }
        public int SalaryReminingCaculator() { return 0; }
        public int TotalPaidSalary(int Amount) { return 0; }
    }
}
