using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    internal class Salary 
    {
        private int SalaryId;
        private int EmployeeID;
        private int DayWork {  get; set; } 
        private int OverTime { get; set; }
        private int PaidSalary;
        private int TotalSalary;
        private int RemaningSalary;
        public void SalaryReminingCaculator() 
        {
            this.RemaningSalary = this.TotalSalary - this.PaidSalary;
        }
        public void TotalPaidSalary(int Amount) 
        {
            this.PaidSalary= this.PaidSalary + Amount;
        }
        public Salary() { } 
        public Salary(int salaryId, int employeeID, int daywork, int overtime, int paidSalary, int totalSalary, int remaningSalary)
        {
            this.SalaryId = salaryId;
            this.EmployeeID = employeeID;
            this.DayWork = daywork;
            this.OverTime = overtime;
            this.PaidSalary = paidSalary;
            this.TotalSalary = totalSalary;
            this.RemaningSalary = remaningSalary;
        }

        public override string? ToString()
        {
            return $"{this.SalaryId} | Employee {this.EmployeeID} | {this.DayWork} | {this.OverTime} | {this.PaidSalary} | {this.TotalSalary} | {this.RemaningSalary}";
        }
        public int GetEmployeeId() {   return this.EmployeeID;  }
    }
}
