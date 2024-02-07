using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSibers_Model
{
    public class Employee
    {
        public Employee(string name, string surname, string patronymic, string email, List<Project> projects)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
            Projects = projects;
        }
        private Employee(){}
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _email;
        public List<Project> Projects { get; set; }
        private int Id { get; set; }
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }
            set
            {
                _patronymic = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public void AddProjects(Project project)
        {
            Projects.Add(project);
            if(!project.Employees.Contains(this))
                project.AddEmployee(this);
        }
        public void RemoveProjects(Project project)
        {
            Projects.Remove(project);
            if (project.Employees.Contains(this))
                project.RemoveEmployee(this);
        }
    }
}
