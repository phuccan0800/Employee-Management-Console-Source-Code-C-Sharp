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
        private DateTime TimeJoined { get; }
        private int Status {get; set;}
        private void AutoSetTimeJoin() { }
        public Employee() { }
        public override string ToString()
        {
            if (this.PositionI == "manager") return $"{ID}. {Name} | {Age} | {Sex} | {Hometown} | {Phone} | {Birthday} | {TimeJoined} | Manager | {Status}";
            else return $"{ID}. {Name} | {Age} | {Sex} | {Hometown} | {Phone} | {Birthday.ToString("dd-MM-yyyy")} | {TimeJoined.ToString("dd-MM-yyyy")} | Newbie | {Status}";
        }

        public Employee(int iD, 
            string name, 
            int age, 
            string sex, 
            string hometown,
            string phone, 
            DateTime birhday, 
            DateTime timeJoined, 
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
            this.PositionI = positionI;
        }
        public string GetName ()
        {
            return this.Name;
        }
        public int CaculatorAge(DateTime birthday)
        {
            DateTime currentTime = DateTime.Today;
            int age = currentTime.Year - birthday.Year;
            if (currentTime < birthday.AddYears(age)) age--;
            return age;
        }
    }
}
