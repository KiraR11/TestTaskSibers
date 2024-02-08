using System;
using System.Collections;
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
            Employees = employees;
            Director = director;
        }
        private Project(){}

        private const string ERROR_NAME_CANNOT_BE_EMPTU = "Название проекта не может быть пустым";
        private const string ERROR_NAME_CUSTOMER_COMPANY_CANNOT_BE_EMPTU = "Название компании заказчика не может быть пустым";
        private const string ERROR_NAME_CONTRACTOR_COMPANY_CANNOT_BE_EMPTU = "Название компании исполнителя не может быть пустым";
        private const string ERROR_DATA_END_CANNOT_BE_EARLIER_DATA_START = "Дата окончания не может быть раньше даты начала";
        private const string ERROR_PRIORITY_CAN_BE_FROME_ZERO_BEFORE_TEN = "Приоритет может быть от 0 до 10";

        private string _name;
        private string _nameСustomerCompany;
        private string _nameСontractorCompany;
        private DateOnly _dataStart;
        private DateOnly _dataEnd;
        private byte _priority;
        private Employee? _director;
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
        public string NameСustomerCompany
        {
            get => _nameСustomerCompany;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(ERROR_NAME_CUSTOMER_COMPANY_CANNOT_BE_EMPTU);
                _nameСustomerCompany = value;
            }
        }
        public string NameСontractorCompany
        {
            get => _nameСontractorCompany;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(ERROR_NAME_CONTRACTOR_COMPANY_CANNOT_BE_EMPTU);
                _nameСontractorCompany = value;
            }
        }
        public byte Priority
        {
            get => _priority;
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException(ERROR_PRIORITY_CAN_BE_FROME_ZERO_BEFORE_TEN);
                _priority = value;
            }
        }
        public DateOnly DataStart
        {
            get => _dataStart;
            set
            {
                if (value >= DataEnd && !(DataEnd is { Day: 1, Month: 1, Year: 1 }))
                    throw new ArgumentException(ERROR_DATA_END_CANNOT_BE_EARLIER_DATA_START);
                _dataStart = value;
            }
        }
        public DateOnly DataEnd
        {
            get => _dataEnd;
            set
            {
                if (value <= DataStart && !(DataStart is { Day: 1, Month: 1, Year: 1 }))
                    throw new ArgumentException(ERROR_DATA_END_CANNOT_BE_EARLIER_DATA_START);
                _dataEnd = value;
            }
        }

        public Employee? Director
        {
            get => _director;
            set
            {
                if(value != null && !Employees.Contains(value))
                    AddEmployee(value);
                _director = value;
            }
        }
        public List<Employee> Employees { get; private set;}

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
            if (employee == Director)
                Director = null;
        }
    }
}
