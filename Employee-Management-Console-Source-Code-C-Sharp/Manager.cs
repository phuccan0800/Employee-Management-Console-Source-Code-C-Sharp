using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    internal class Manager : Positon
    {
        private int PositionSalary =500000;
        private string PositionName = "Manager";
        public override void GetPositionName()
        {
            Console.Write($"{PositionName}:");
        }

        public override void GetPositionSalary()
        {
            Console.Write($"{PositionSalary} VND");
        }
    }
}
