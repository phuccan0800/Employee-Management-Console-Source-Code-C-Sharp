using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    internal class Newbie : Positon
    {
        private int PositonSalary = 0;
        private string PositionName = "Newbie";
        public override void GetPositionName()
        {
            Console.Write($"{PositionName}:");
        }

        public override void GetPositionSalary()
        {
            Console.Write($"{PositonSalary} VND");
        }
    }
}
