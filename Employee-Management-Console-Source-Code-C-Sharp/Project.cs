using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    internal class Project : ObserverController
    {
        private int ID;
        private Employee employee = new Employee();
        private string ProjectName {  get; set; }
        private string ProjectDetail { get; set; } 
        private int ProjectBonus { get; set; }
        private int Status { get; set; }
        public void UpdateNewInfor() { }
    }
}
