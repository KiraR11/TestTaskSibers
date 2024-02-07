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
    public void Create_Employee_With_Empty_Name()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => new Employee("", "Фамилия", "Отчество", "email@mail.ru", []));

        Assert.Equal(ERROR_NAME_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Create_Employee_With_Empty_Surname()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => new Employee("Имя", "", "Отчество", "email@mail.ru", []));

        Assert.Equal(ERROR_SURNAME_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Create_Employee_With_Empty_Patronymic()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => new Employee("Имя", "Фамилия", "", "email@mail.ru", []));

        Assert.Equal(ERROR_PATRONYMIC_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Create_Employee_With_Wrong_Type_Of_Email()
    {
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => new Employee("Имя", "Фамилия", "Отчество", "emailmail.ru", []));

        Assert.Equal(ERROR_WRONG_TYPE_EMAIL, ex.Message);
    }

    [Fact]
    public void Changing_Employee_Name_An_Empty()
    {
        Employee employee = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);
        
        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => employee.Name = "");

        Assert.Equal(ERROR_NAME_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Changing_Employee_Surname_An_Empty()
    {
        Employee employee = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);

        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => employee.Surname = "");

        Assert.Equal(ERROR_SURNAME_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Changing_Employee_Patronymic_An_Empty()
    {
        Employee employee = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);

        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => employee.Patronymic = "");

        Assert.Equal(ERROR_PATRONYMIC_CANNOT_BE_EMPTU, ex.Message);
    }
    [Fact]
    public void Changing_Employee_Email_An_Wrong_Type_Email()
    {
        Employee employee = new Employee("Имя", "Фамилия", "Отчество", "email@mail.ru", []);

        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => employee.Email = "emailmail.ru");

        Assert.Equal(ERROR_WRONG_TYPE_EMAIL, ex.Message);
    }
}