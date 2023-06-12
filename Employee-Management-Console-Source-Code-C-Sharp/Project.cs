using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    public class Project : ObserverController
    {
        private int ID;
        private Employee employee = new Employee();
        private int EmployeeID { get; set; }
        private string ProjectName {  get; set; }
        private string ProjectDetail { get; set; } 
        private int ProjectBonus { get; set; }
        private int Status { get; set; }
        public void UpdateNewInfor() { }
        public Project() { }
        public Project (int id, int employeeID, string projectName, string projectDetail, int projectBonus, int status) 
        {
            this.ID = id;
            this.EmployeeID = employeeID;
            this.ProjectName = projectName;
            this.ProjectDetail = projectDetail;
            this.Status = status;
            this.ProjectBonus = projectBonus;
        }
        public override string? ToString()
        {
            return $"{this.ID} | Employee {this.EmployeeID} | {this.ProjectName} | {this.ProjectDetail} | {this.ProjectBonus} | {GetStatus(this.Status)} ";
        }
        public string ToString2()
        {
            return $"ID: {this.ID} \n 1.For Employee: Employee {this.EmployeeID} \n 2.Project Name: {this.ProjectName} \n 3.Project Details: {this.ProjectDetail} \n 4.Project Bonus: {this.ProjectBonus} \n 5.Status: {GetStatus(this.Status)} ";
        }
        private static string GetStatus(int status)
        {
            if (status == 0) return "Not Yet";
            else if (status == 1) return "Processing";
            else if (status == 2) return "Checking";
            else if (status == 3) return "Done !";
            else return "No Info";
        }
        public string GetProjectName() {
            return this.ProjectName;
        }
        public void SetEmployeeID(int employeeID)
        {
            EmployeeID = employeeID;
        }

        public void SetProjectName(string projectName)
        {
            ProjectName = projectName;
        }

        public void SetProjectDetail(string projectDetail)
        {
            ProjectDetail = projectDetail;
        }

        public void SetProjectBonus(int projectBonus)
        {
            ProjectBonus = projectBonus;
        }

        public void SetStatus(int status)
        {
            Status = status;
        }

    }
}
