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

        const string ERROR_NAME_CANNOT_BE_EMPTU = "Имя не может быть пустым";
        const string ERROR_SURNAME_CANNOT_BE_EMPTU = "Фамилия не может быть пустой";
        const string ERROR_PATRONYMIC_CANNOT_BE_EMPTU = "Отчество не может быть пустым";
        const string ERROR_WRONG_TYPE_EMAIL = "Email имеет неверный вид";

        private string _name;
        private string _surname;
        private string _patronymic;
        private string _email;
        public List<Project> Projects { get; set; }
        private int Id { get; set; }
        public string Name 
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(ERROR_NAME_CANNOT_BE_EMPTU);
                _name = value;
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(ERROR_SURNAME_CANNOT_BE_EMPTU);
                _surname = value;
            }
        }
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(ERROR_PATRONYMIC_CANNOT_BE_EMPTU);
                _patronymic = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if(!value.Contains('@'))
                    throw new ArgumentException(ERROR_WRONG_TYPE_EMAIL);
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
