using Microsoft.EntityFrameworkCore;
using TestTaskSibers_Model;

namespace TestTaskSibers_Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            AddingDbStartValues();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = $"Data Source = {Environment.CurrentDirectory}\\testDataBase.db";
            string connectionString = "Data Source = testDataBase.db";
            optionsBuilder.UseSqlite("");
        }

        DbSet<Project> Projects { get; set; }
        DbSet<Employee> Employees { get; set; }
        public List<Employee> GetEmployees()
        {
            return Employees.ToList();
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            Employees.Update(employee);
        }
        public List<Project> GetProjects()
        {
            return Projects.ToList();
        }
        public void AddProject(Project project)
        {
            Projects.Add(project);
        }
        public void RemoveProject(Project project)
        {
            Projects.Remove(project);
        }
        public void UpdateProject(Project project)
        {
            Projects.Update(project);
        }
        public void AddingDbStartValues()
        {
            Employee employee1 = new Employee("Имя1", "Фамилия1", "Отчество1", "email@mail.ru", []);
            Employee employee2 = new Employee("Имя2", "Фамилия2", "Отчество2", "email@mail.ru", []);
            Employee employee3 = new Employee("Имя3", "Фамилия3", "Отчество3", "email@mail.ru", []);
            Employee employee4 = new Employee("Имя4", "Фамилия4", "Отчество4", "email@mail.ru", []);
            Employee director1 = new Employee("ИмяДиректора1", "ФамилияДиректора1", "ОтчествоДиректора1", "email@mail.ru", []);
            Employee director2 = new Employee("ИмяДиректора12", "ФамилияДиректора2", "ОтчествоДиректора2", "email@mail.ru", []);
            Project project1 = new Project("А проект", "Г компания заказчик", "Б компания изготовитель", new DateOnly(2020, 12, 1), new DateOnly(2023, 1, 1), 1, director1, []);
            Project project2 = new Project("Б проект", "В компания заказчик", "А компании изготовителя", new DateOnly(2022, 8, 1), new DateOnly(2023, 3, 1), 3, director2, []);
            Project project3 = new Project("В проект", "Б компания заказчик", "Г компании изготовителя", new DateOnly(2022, 5, 1), new DateOnly(2023, 4, 1), 8, director1, []);
            Project project4 = new Project("Г проект", "А компания заказчик", "В компании изготовителя", new DateOnly(2021, 6, 1), new DateOnly(2023, 2, 1), 2, director2, []);

            project1.AddEmployee(employee1);
            project1.AddEmployee(employee2);
            project2.AddEmployee(employee2);
            project2.AddEmployee(employee3);
            project3.AddEmployee(employee3);
            project3.AddEmployee(employee4);
            project4.AddEmployee(employee4);
            project4.AddEmployee(employee1);

            AddProject(project1);
            AddProject(project2);
            AddProject(project3);
            AddProject(project4);

            AddEmployee(employee1);
            AddEmployee(employee2);
            AddEmployee(employee3);
            AddEmployee(employee4);
        }
    }
}
