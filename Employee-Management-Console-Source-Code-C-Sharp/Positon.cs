using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
     internal abstract class Positon
    {
        public void getPositionInfor()
        {
            GetPositionName();
            GetPositionSalary();
        }
        public abstract void GetPositionName();
        public abstract void GetPositionSalary();
    }
}
