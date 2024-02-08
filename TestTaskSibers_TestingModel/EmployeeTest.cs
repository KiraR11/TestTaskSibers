using Xunit;
using TestTaskSibers_Model;

namespace TestTaskSibers_TestingModel;
public class EmployeeTest
{
    const string ERROR_NAME_CANNOT_BE_EMPTU = "Имя не может быть пустым";
    const string ERROR_SURNAME_CANNOT_BE_EMPTU = "Фамилия не может быть пустой";
    const string ERROR_PATRONYMIC_CANNOT_BE_EMPTU = "Отчество не может быть пустым";
    const string ERROR_WRONG_TYPE_EMAIL = "Email имеет неверный вид";

    [Fact]
    public void Create_Employee_With_Ideal_Parametrs()
    {
        Employee employee =  new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);

        Assert.Equal("Имя", employee.Name);
    }
    [Fact]
    public void Create_Employee_With_Empty_Name()
    {
        ArgumentException ex = Assert.Throws<ArgumentException>(() => new Employee("", "Фамилия", "Отчество", "email@mail.ru", []));

        Assert.Equal(ERROR_NAME_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Create_Employee_With_Empty_Surname()
    {
        ArgumentException ex = Assert.Throws<ArgumentException>(() => new Employee("Имя", "", "Отчество", "email@mail.ru", []));

        Assert.Equal(ERROR_SURNAME_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Create_Employee_With_Empty_Patronymic()
    {
        ArgumentException ex = Assert.Throws<ArgumentException>(() => new Employee("Имя", "Фамилия", "", "email@mail.ru", []));

        Assert.Equal(ERROR_PATRONYMIC_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Create_Employee_With_Wrong_Type_Of_Email()
    {
        ArgumentException ex = Assert.Throws<ArgumentException>(() => new Employee("Имя", "Фамилия", "Отчество", "emailmail.ru", []));

        Assert.Equal(ERROR_WRONG_TYPE_EMAIL, ex.Message);
    }

    [Fact]
    public void Changing_Employee_Name_An_Empty()
    {
        Employee employee = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);

        ArgumentException ex = Assert.Throws<ArgumentException>(() => employee.Name = "");

        Assert.Equal(ERROR_NAME_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Changing_Employee_Surname_An_Empty()
    {
        Employee employee = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);

        ArgumentException ex = Assert.Throws<ArgumentException>(() => employee.Surname = "");

        Assert.Equal(ERROR_SURNAME_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Changing_Employee_Patronymic_An_Empty()
    {
        Employee employee = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);

        ArgumentException ex = Assert.Throws<ArgumentException>(() => employee.Patronymic = "");

        Assert.Equal(ERROR_PATRONYMIC_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Changing_Employee_Email_An_Wrong_Type_Email()
    {
        Employee employee = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);

        ArgumentException ex = Assert.Throws<ArgumentException>(() => employee.Email = "emailmail.ru");

        Assert.Equal(ERROR_WRONG_TYPE_EMAIL, ex.Message);
    }
    [Fact]
    public void AddProjectInEmployeeWithAddingThisEmployeeInProjectEmployees()
    {
        Employee employee = new Employee("Имя1", "Фамилия1", "Отчество1", "email@mail.ru", []);
        Employee director = new Employee("Имя2", "Фамилия2", "Отчество2", "email@mail.ru", []);
        Project project = new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 0, director, []);

        employee.AddProjects(project);

        Assert.Equal(project, employee.Projects[0]);
        Assert.Equal(employee, project.Employees[1]);
    }
    [Fact]
    public void RemoveProjectInEmployeeWithRemovingThisEmployeeInProjectEmployees()
    {
        Employee employee = new Employee("Имя1", "Фамилия1", "Отчество1", "email@mail.ru", []);
        Employee director = new Employee("Имя2", "Фамилия2", "Отчество2", "email@mail.ru", []);
        Project project = new Project("Название проекта", "Название компании заказчика", "Название компании изготовителя", new DateOnly(2023, 10, 1), new DateOnly(2023, 12, 1), 0, director, []);

        employee.AddProjects(project);
        employee.RemoveProjects(project);

        Assert.Equal(1, project.Employees.Count);
        Assert.Equal(0, employee.Projects.Count);
    }
}