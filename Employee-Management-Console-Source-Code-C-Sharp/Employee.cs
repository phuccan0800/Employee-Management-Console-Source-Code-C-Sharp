using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    public class Employee : Person
    {
        private string PositionI;
        private Positon manager = new Manager();
        private Positon newbie = new Newbie();
        //private Salary salary = new Salary();
        private DateOnly TimeJoined { get; }
        private int Status {get; set;}
        private void AutoSetTimeJoin() { }
        public Employee() { }
        public override string ToString()
        {
            if (this.PositionI == "manager") return $"{ID}. {Name} | {Age} | {Sex} | {Hometown} | {Phone} | {Birthday} | {TimeJoined} | {manager.GetPositionName()} | {Status}";
            else return $"{ID}. {Name} | {Age} | {Sex} | {Hometown} | {Phone} | {Birthday} | {TimeJoined} | {newbie.GetPositionName()} | {Status}";
        }

        public Employee(int iD, 
            string name, 
            int age, 
            string sex, 
            string hometown,
            string phone, 
            string birhday, 
            DateOnly timeJoined, 
            string positionI, 
            int status)
        {
            this.ID = iD;
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Hometown = hometown;
            this.Phone = phone;
            this.Birthday = birhday; 
            this.Status = status;  
            this.TimeJoined = timeJoined;
            this.Status = status;
            this.PositionI = positionI;
        }
        public int CaculatorAge(DateTime birthday)
        {
            return 0;
        }

    }
}
