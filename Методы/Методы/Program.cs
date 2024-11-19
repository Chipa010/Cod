using System;

public class Calculator
{
    // Публичный метод для сложения чисел
    public int AddNumbers(int a, int b)
    {
        return a + b;
    }

    // Приватный метод для сложения строк
    private string AddStrings(string str1, string str2)
    {
        return str1 + str2;
    }

    // Публичный метод, который вызывает приватный метод для сложения строк
    public string CombineStrings(string str1, string str2)
    {
        return AddStrings(str1, str2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        // Используем публичный метод для сложения чисел
        Console.WriteLine(calc.AddNumbers(10, 15)); // Вывод: 25

        // Используем публичный метод для вызова приватного метода сложения строк
        Console.WriteLine(calc.CombineStrings("Учебная ", " практика")); // Вывод: Учебная практика
    }
}

