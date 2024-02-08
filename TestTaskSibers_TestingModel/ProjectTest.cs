using TestTaskSibers_Model;
using Xunit;

namespace TestTaskSibers_TestingModel
{
    public class ProjectTest
    {
        private const string ERROR_NAME_CANNOT_BE_EMPTU = "Название проекта не может быть пустым";
        private const string ERROR_NAME_CUSTOMER_COMPANY_CANNOT_BE_EMPTU = "Название компании заказчика не может быть пустым";
        private const string ERROR_NAME_CONTRACTOR_COMPANY_CANNOT_BE_EMPTU = "Название компании исполнителя не может быть пустым";
        private const string ERROR_DATA_END_CANNOT_BE_EARLIER_DATA_START = "Дата окончания не может быть раньше даты начала";
        private const string ERROR_PRIORITY_CAN_BE_FROME_ZERO_BEFORE_TEN = "Приоритет может быть от 0 до 10";

        [Fact]
        public void CreateProjectWithEmptyName()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Project("", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023,10,1), new DateOnly(2023, 12, 1),2, director, []));

            Assert.Equal(ERROR_NAME_CANNOT_BE_EMPTU, ex.Message);
        }
        [Fact]
        public void CreateProjectWithEmptyNameСustomerCompany()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Project("Название проекта", "", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 2, director, []));

            Assert.Equal(ERROR_NAME_CUSTOMER_COMPANY_CANNOT_BE_EMPTU, ex.Message);
        }
        [Fact]
        public void CreateProjectWithEmptyNameСontractorCompany()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Project("Название проекта", "Название компании заказчика", "", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 2, director, []));

            Assert.Equal(ERROR_NAME_CONTRACTOR_COMPANY_CANNOT_BE_EMPTU, ex.Message);
        }
        [Fact]
        public void CreateProjectWithDateEndEarlierDateStart()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 9, 1), 2, director, []));

            Assert.Equal(ERROR_DATA_END_CANNOT_BE_EARLIER_DATA_START, ex.Message);
        }
        [Fact]
        public void CreateProjectWithDateEndEqualDateStart()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 10, 1), 2, director, []));

            Assert.Equal(ERROR_DATA_END_CANNOT_BE_EARLIER_DATA_START, ex.Message);
        }
        [Fact]
        public void CreateProjectWithPriorityEqualZero()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            Project project = new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 0, director, []);

            Assert.Equal(0, project.Priority);
        }
        [Fact]
        public void CreateProjectWithPriorityEqualTen()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            Project project = new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 10, director, []);

            Assert.Equal(10, project.Priority);
        }
        [Fact]
        public void CreateProjectWithPriorityEqualEleven()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 11, director, []));

            Assert.Equal(ERROR_PRIORITY_CAN_BE_FROME_ZERO_BEFORE_TEN, ex.Message);
        }
        [Fact]
        public void CreateProjectWithIdealParameters()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            Project project = new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 0, director, []);

            Assert.Equal(0, project.Priority);
        }

        [Fact]
        public void AddEmployeeInProjectWithAddingThisProjectInEmployeeProjects()
        {
            Employee employee = new Employee("Имя1", "Фамилия1", "Отчество1", "email@mail.ru", []);
            Employee director = new Employee("Имя2", "Фамилия2", "Отчество2", "email@mail.ru", []);
            Project project = new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 0, director, []);

            project.AddEmployee(employee);

            Assert.Equal(employee, project.Employees[1]);
            Assert.Equal(project, employee.Projects[0]);
        }
        [Fact]
        public void RemoveEmployeeInProjectWithRemovingThisProjectInEmployeeProjects()
        {
            Employee employee = new Employee("Имя1", "Фамилия1", "Отчество1", "email@mail.ru", []);
            Employee director = new Employee("Имя2", "Фамилия2", "Отчество2", "email@mail.ru", []);
            Project project = new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 0, director, []);

            project.AddEmployee(employee);
            project.RemoveEmployee(employee);

            Assert.Equal(1, project.Employees.Count);
            Assert.Equal(0, employee.Projects.Count);
        }
        [Fact]
        public void AddDirectorInEmployeesWithAddingThisProjectInEmployeeProjects()
        {
            Employee director = new Employee("Имя2", "Фамилия2", "Отчество2", "email@mail.ru", []);
            Project project = new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 0, director, []);

            Assert.Equal(director, project.Employees[0]);
            Assert.Equal(project, director.Projects[0]);
        }
        [Fact]
        public void RemoveDirectorInProjectWithRemovingThisProjectInEmployeeProjects()
        {
            Employee director = new Employee("Имя2", "Фамилия2", "Отчество2", "email@mail.ru", []);
            Project project = new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 0, director, []);

            project.RemoveEmployee(director);

            Assert.Equal(0, project.Employees.Count);
            Assert.Equal(null, project.Director);
            Assert.Equal(0, director.Projects.Count);
            
        }
    }
}
