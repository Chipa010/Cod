using System;

public class User
{
    // Свойства пользователя
    public int Id { get; set; } // Уникальный идентификатор
    public string FirstName { get; set; } // Имя
    public string LastName { get; set; } // Фамилия
    public string Email { get; set; } // Электронная почта
    public string Password { get; set; } // Пароль (в реальном приложении стоит хранить хэш)
    public DateTime DateOfBirth { get; set; } // Дата рождения
    public string Address { get; set; } // Адрес
    public string PhoneNumber { get; set; } // Номер телефона
    public DateTime RegistrationDate { get; set; } // Дата регистрации
    public bool IsActive { get; set; } // Активен ли пользователь

    // Дополнительно можно добавить вычисляемое свойство
    public string FullName => $"{FirstName} {LastName}";

    // Конструктор
    public User(int id, string firstName, string lastName, string email, string password, DateTime dateOfBirth)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        DateOfBirth = dateOfBirth;
        RegistrationDate = DateTime.Now;
        IsActive = true;
    }

    // Метод для отображения информации о пользователе
    public override string ToString()
    {
        return $"ID: {Id}, Name: {FullName}, Email: {Email}, Active: {IsActive}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем нового пользователя
        User user = new User(1, "Дмитрий", "Чернышев", "dpapkiin976@gmail.com", "admin777", new DateTime(1990, 5, 10));

        // Выводим информацию о пользователе
        Console.WriteLine(user);
    }
}

