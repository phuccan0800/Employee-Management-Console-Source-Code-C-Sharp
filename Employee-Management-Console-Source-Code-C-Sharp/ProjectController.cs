using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Console_Source_Code_C_Sharp
{
    public class ProjectController
    {
        List<Project> ListProject = new List<Project>();
        EmployeeController employeeController = new EmployeeController();
        private int LastProjectID = 0;
        public ProjectController() { }
        public void ReadProject()
        {
            string[] inputs = new string[]
            {
                "1|1|Project A|Details of Project A|500000|1",
                "2|2|Project B|Details of Project B|700000|1",
                "3|2|Project C|Details of Project C|300000|2",
                "4|1|Project D|Details of Project D|400000|2",
                "5|4|Project E|Details of Project E|600000|1"
            };

            foreach (string input in inputs)
            {
                Project project = ParseEmployeeFromLine(input);
                ListProject.Add(project);
                LastProjectID++;
            }
        }
        private static Project ParseEmployeeFromLine(string line)
        {
            string[] data = line.Split('|');
            Project project2 = new Project(int.Parse(data[0]), int.Parse(data[1]), data[2], data[3], int.Parse(data[4]), int.Parse(data[5]));
            return project2;
        }
        public void ViewProjectList()
        {
            foreach (Project project in ListProject)
            {
                Console.WriteLine(project.ToString());
            }
        }
        public void DeleteProject()
        {
            Console.Write("Enter ID of Project you want to delete: ");
            int IdDelete = int.Parse(Console.ReadLine()) - 1;
            Console.Write($"Are you sure for Delete {ListProject[IdDelete].GetProjectName()}  ? (Y or N): ");
            string confirm = Console.ReadLine().ToUpper();
            switch (confirm)
            {
                case "N":
                    Console.WriteLine("Cancel !!");
                    break;
                default:
                    ListProject.RemoveAt(IdDelete);
                    Console.WriteLine("Delete Employee Complete !!!");
                    break;
            }
        }
        public void EditProject()
        {
            Console.Write("Choose Project you want to edit (ID): ");
            int id = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Information: ");
            Console.WriteLine(ListProject[id].ToString2());
            int choice = 0;
            do
            {
                Console.Write("Choose Information you want to edit (1..8): ");
                choice = int.Parse(Console.ReadLine());
            } while (choice > 8 || choice < 1);
            Console.Write($"Enter New Information: ");
            string Information = Console.ReadLine();
            switch (choice)
            {
                case 1:
                    ListProject[id].SetEmployeeID(int.Parse(Information));
                    break;
                case 2:
                    ListProject[id].SetProjectName(Information);
                    break;
                case 3:
                    ListProject[id].SetProjectDetail(Information);
                    break;
                case 4:
                    ListProject[id].SetProjectBonus(int.Parse(Information));
                    break;
                case 5:
                    ListProject[id].SetStatus(int.Parse(Information));
                    break;
                default:
                    Console.WriteLine("ERRORR !!! TRY AGAIN !!!!");
                    EditProject();
                    break;
            }
            Console.WriteLine("DONE !!!!");
        }
        public void AddProject()
        {
            int choice = 9;
            LastProjectID++;
            Console.Write("Enter Name of New Project: ");
            string name = Console.ReadLine();
            employeeController.ViewEmployeeList();
            Console.Write("This Project for Employee (ID): ");
            int employeeID = int.Parse(Console.ReadLine());
            Console.Write($"Enter Description for {name} Project: ");
            string desProject = Console.ReadLine();
            Console.Write("How much Bonus for this Project?(VND): ");
            int Bonus = int.Parse(Console.ReadLine());
            Console.Write("Confirm ADD ? (Y or N): ");
            string confirm = Console.ReadLine().ToUpper();
            switch (confirm)
            {
                case "N":
                    LastProjectID--;
                    Console.WriteLine("Cancel !!");
                    break;
                default:
                    Project project = new Project(LastProjectID, employeeID, name, desProject, Bonus, 0);
                    ListProject.Add(project);
                    Console.WriteLine("Add Project Complete !!!");
                    break;
            }
        }
    }
}
