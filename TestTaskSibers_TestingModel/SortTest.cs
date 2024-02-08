using TestTaskSibers_Model;
using Xunit;

namespace TestTaskSibers_TestingModel
{
    public class SortTest
    {
        [Fact]
        public void SortEmployeesByName()
        {
            Employee employees1 = new("Aвгустин", "Бакулин", "Владимирович", "email@mail.ru", []);
            Employee employees2 = new("Андрей", "Антошкин", "Александрович", "email@mail.ru", []);
            Employee employees3 = new("Владимир", "Ерополков", "Евгеньевич", "email@mail.ru", []);
            Employee employees4 = new("Генадий", "Градов", "Брахович", "email@mail.ru", []);
            Employee employees5 = new("Евгений", "Винакурин", "Генадьевич", "email@mail.ru", []);

            List<Employee> employees = new List<Employee>
            {
                employees5,
                employees1,
                employees2,
                employees4,
                employees3
            };

            SorterEmployee.SortByName(employees);

            Assert.Equal(employees1, employees[0]);
            Assert.Equal(employees2, employees[1]);
            Assert.Equal(employees3, employees[2]);
            Assert.Equal(employees4, employees[3]);
            Assert.Equal(employees5, employees[4]);
        }
        [Fact]
        public void SortEmployeesBySurname()
        {
            Employee employees2 = new("Aвгустин", "Бакулин", "Владимирович", "email@mail.ru", []);
            Employee employees1 = new("Андрей", "Антошкин", "Александрович", "email@mail.ru", []);
            Employee employees5 = new("Владимир", "Ерополков", "Евгеньевич", "email@mail.ru", []);
            Employee employees4 = new("Генадий", "Градов", "Брахович", "email@mail.ru", []);
            Employee employees3 = new("Евгений", "Винакурин", "Генадьевич", "email@mail.ru", []);

            List<Employee> employees = new List<Employee>
            {
                employees5,
                employees1,
                employees2,
                employees4,
                employees3
            };

            SorterEmployee.SortBySurname(employees);

            Assert.Equal(employees1, employees[0]);
            Assert.Equal(employees2, employees[1]);
            Assert.Equal(employees3, employees[2]);
            Assert.Equal(employees4, employees[3]);
            Assert.Equal(employees5, employees[4]);
        }
        [Fact]
        public void SortEmployeesByPatronymic()
        {
            Employee employees3 = new("Aвгустин", "Бакулин", "Владимирович", "email@mail.ru", []);
            Employee employees1 = new("Андрей", "Антошкин", "Александрович", "email@mail.ru", []);
            Employee employees5 = new("Владимир", "Ерополков", "Евгеньевич", "email@mail.ru", []);
            Employee employees2 = new("Генадий", "Градов", "Брахович", "email@mail.ru", []);
            Employee employees4 = new("Евгений", "Винакурин", "Генадьевич", "email@mail.ru", []);

            List<Employee> employees = new List<Employee>
            {
                employees5,
                employees1,
                employees2,
                employees4,
                employees3
            };

            SorterEmployee.SortByPatronymic(employees);

            Assert.Equal(employees1, employees[0]);
            Assert.Equal(employees2, employees[1]);
            Assert.Equal(employees3, employees[2]);
            Assert.Equal(employees4, employees[3]);
            Assert.Equal(employees5, employees[4]);
        }
        [Fact]
        public void SortProjectsByName()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            Project project1 = new Project("А проект", "Г компания заказчик", "Б компания изготовитель", new DateOnly(2022, 7, 1), new DateOnly(2023, 1, 1), 1, director, []);
            Project project2 = new Project("Б проект", "В компания заказчик", "А компании изготовителя", new DateOnly(2022, 8, 1), new DateOnly(2023, 3, 1), 3, director, []);
            Project project3 = new Project("В проект", "Б компания заказчик", "Г компании изготовителя", new DateOnly(2022, 5, 1), new DateOnly(2023, 4, 1), 8, director, []);
            Project project4 = new Project("Г проект", "А компания заказчик", "В компании изготовителя", new DateOnly(2022, 6, 1), new DateOnly(2023, 2, 1), 2, director, []);

            List<Project> projects = new List<Project>
            {
                project4,
                project1,
                project3,
                project2
            };

            SorterProject.SortByName(projects);

            Assert.Equal(project1, projects[0]);
            Assert.Equal(project2, projects[1]);
            Assert.Equal(project3, projects[2]);
            Assert.Equal(project4, projects[3]);
        }
        [Fact]
        public void SortProjectsByNameСustomer()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            Project project4 = new Project("А проект", "Г компания заказчик", "Б компания изготовитель", new DateOnly(2022, 7, 1), new DateOnly(2023, 1, 1), 1, director, []);
            Project project3 = new Project("Б проект", "В компания заказчик", "А компании изготовителя", new DateOnly(2022, 8, 1), new DateOnly(2023, 3, 1), 3, director, []);
            Project project2 = new Project("В проект", "Б компания заказчик", "Г компании изготовителя", new DateOnly(2022, 5, 1), new DateOnly(2023, 4, 1), 8, director, []);
            Project project1 = new Project("Г проект", "А компания заказчик", "В компании изготовителя", new DateOnly(2022, 6, 1), new DateOnly(2023, 2, 1), 2, director, []);

            List<Project> projects = new List<Project>
            {
                project4,
                project1,
                project3,
                project2
            };

            SorterProject.SortByNameСustomer(projects);

            Assert.Equal(project1, projects[0]);
            Assert.Equal(project2, projects[1]);
            Assert.Equal(project3, projects[2]);
            Assert.Equal(project4, projects[3]);
        }
        [Fact]
        public void SortProjectsByNameСontractor()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            Project project2 = new Project("А проект", "Г компания заказчик", "Б компания изготовитель", new DateOnly(2022, 7, 1), new DateOnly(2023, 1, 1), 1, director, []);
            Project project1 = new Project("Б проект", "В компания заказчик", "А компании изготовителя", new DateOnly(2022, 8, 1), new DateOnly(2023, 3, 1), 3, director, []);
            Project project4 = new Project("В проект", "Б компания заказчик", "Г компании изготовителя", new DateOnly(2022, 5, 1), new DateOnly(2023, 4, 1), 8, director, []);
            Project project3 = new Project("Г проект", "А компания заказчик", "В компании изготовителя", new DateOnly(2022, 6, 1), new DateOnly(2023, 2, 1), 2, director, []);

            List<Project> projects = new List<Project>
            {
                project4,
                project1,
                project3,
                project2
            };

            SorterProject.SortByNameСontractor(projects);

            Assert.Equal(project1, projects[0]);
            Assert.Equal(project2, projects[1]);
            Assert.Equal(project3, projects[2]);
            Assert.Equal(project4, projects[3]);
        }
        [Fact]
        public void SortProjectsByPriority()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            Project project1 = new Project("А проект", "Г компания заказчик", "Б компания изготовитель", new DateOnly(2022, 7, 1), new DateOnly(2023, 1, 1), 1, director, []);
            Project project3 = new Project("Б проект", "В компания заказчик", "А компании изготовителя", new DateOnly(2022, 8, 1), new DateOnly(2023, 3, 1), 3, director, []);
            Project project4 = new Project("В проект", "Б компания заказчик", "Г компании изготовителя", new DateOnly(2022, 5, 1), new DateOnly(2023, 4, 1), 8, director, []);
            Project project2 = new Project("Г проект", "А компания заказчик", "В компании изготовителя", new DateOnly(2022, 6, 1), new DateOnly(2023, 2, 1), 2, director, []);

            List<Project> projects = new List<Project>
            {
                project4,
                project1,
                project3,
                project2
            };

            SorterProject.SortByPriority(projects);

            Assert.Equal(project1, projects[0]);
            Assert.Equal(project2, projects[1]);
            Assert.Equal(project3, projects[2]);
            Assert.Equal(project4, projects[3]);
        }
        [Fact]
        public void SortProjectsByDataStart()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            Project project3 = new Project("А проект", "Г компания заказчик", "Б компания изготовитель", new DateOnly(2022, 7, 1), new DateOnly(2023, 1, 1), 1, director, []);
            Project project4 = new Project("Б проект", "В компания заказчик", "А компании изготовителя", new DateOnly(2022, 8, 1), new DateOnly(2023, 3, 1), 3, director, []);
            Project project1 = new Project("В проект", "Б компания заказчик", "Г компании изготовителя", new DateOnly(2022, 5, 1), new DateOnly(2023, 4, 1), 8, director, []);
            Project project2 = new Project("Г проект", "А компания заказчик", "В компании изготовителя", new DateOnly(2022, 6, 1), new DateOnly(2023, 2, 1), 2, director, []);

            List<Project> projects = new List<Project>
            {
                project4,
                project1,
                project3,
                project2
            };

            SorterProject.SortByDataStart(projects);

            Assert.Equal(project1, projects[0]);
            Assert.Equal(project2, projects[1]);
            Assert.Equal(project3, projects[2]);
            Assert.Equal(project4, projects[3]);
        }
        [Fact]
        public void SortProjectsByDataEnd()
        {
            Employee director = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
            Project project1 = new Project("А проект", "Г компания заказчик", "Б компания изготовитель", new DateOnly(2022, 7, 1), new DateOnly(2023, 1, 1), 1, director, []);
            Project project3 = new Project("Б проект", "В компания заказчик", "А компании изготовителя", new DateOnly(2022, 8, 1), new DateOnly(2023, 3, 1), 3, director, []);
            Project project4 = new Project("В проект", "Б компания заказчик", "Г компании изготовителя", new DateOnly(2022, 5, 1), new DateOnly(2023, 4, 1), 8, director, []);
            Project project2 = new Project("Г проект", "А компания заказчик", "В компании изготовителя", new DateOnly(2022, 6, 1), new DateOnly(2023, 2, 1), 2, director, []);

            List<Project> projects = new List<Project>
            {
                project4,
                project1,
                project3,
                project2
            };

            SorterProject.SortByDataEnd(projects);

            Assert.Equal(project1, projects[0]);
            Assert.Equal(project2, projects[1]);
            Assert.Equal(project3, projects[2]);
            Assert.Equal(project4, projects[3]);
        }
    }
}
