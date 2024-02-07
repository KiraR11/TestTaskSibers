using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskSibers_Model
{
    public class Project
    {
        public Project(
            string name,
            string nameСustomerCompany,
            string nameСontractorCompany,
            DateOnly dataStart,
            DateOnly dataEnd,
            byte priority,
            Employee director,
            List<Employee> employees
            ) {
            Name = name;
            NameСustomerCompany = nameСustomerCompany;
            NameСontractorCompany = nameСontractorCompany;
            DataStart = dataStart;
            DataEnd = dataEnd;
            Priority = priority;
            Director = director;
            Employees = employees;
        }
        private Project(){}

        private string _name;
        private string _nameСustomerCompany;
        private string _nameСontractorCompany;
        private DateOnly _dataStart;
        private DateOnly _dataEnd;
        private byte _priority;
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
        public string NameСustomerCompany
        {
            get
            {
                return _nameСustomerCompany;
            }
            set
            {
                _nameСustomerCompany = value;
            }
        }
        public string NameСontractorCompany
        {
            get
            {
                return _nameСontractorCompany;
            }
            set
            {
                _nameСontractorCompany = value;
            }
        }
        public byte Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
            }
        }
        public DateOnly DataStart
        {
            get
            {
                return _dataStart;
            }
            set
            {
                _dataStart = value;
            }
        }
        public DateOnly DataEnd
        {
            get
            {
                return _dataEnd;
            }
            set
            {
                _dataEnd = value;
            }
        }
        public Employee Director { get; set; }
        public List<Employee> Employees { get;}

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            if(!employee.Projects.Contains(this))
                employee.AddProjects(this);
        }
        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
            if(employee.Projects.Contains(this))
                employee.RemoveProjects(this);
        }
    }
}
