using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Меню выбора:");
        Console.WriteLine("- ввести А");
        Console.WriteLine("- ввести В");
        Console.WriteLine("- выполнить операцию '+'");
        Console.WriteLine("- выполнить операцию '-'");
        Console.WriteLine("- выполнить операцию '*'");
        Console.WriteLine("- выполнить операцию '/'");

        Console.Write("Введите ваш выбор: ");
        string choice = Console.ReadLine();

        switch (choice.ToUpper())
        {
            case "А":
                Console.WriteLine("Вы выбрали ввести А.");
                break;

            case "В":
                Console.WriteLine("Вы выбрали ввести В.");
                break;

            case "+":
                Console.WriteLine("Вы выбрали выполнить операцию '+'.");
                break;

            case "-":
                Console.WriteLine("Вы выбрали выполнить операцию '-'.");
                break;

            case "*":
                Console.WriteLine("Вы выбрали выполнить операцию '*'.");
                break;

            case "/":
                Console.WriteLine("Вы выбрали выполнить операцию '/'.");
                break;

            default:
                Console.WriteLine("Неверный выбор. Пожалуйста, выберите пункт из меню.");
                break;
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
    public class MenuFunctions
    {
        public void MenuFunction1()
        {
            // Код для функции меню A
        }
    }
    public class MenuFunctions2
    {
        public void MenuFunction2()
        {
            // Код для функции меню B
        }
    }
    public class MenuFunctions3
    {
        public void MenuFunction3()
        {
            // Код для функции меню -
        }
    }
    public class MenuFunctions4
    {
        public void MenuFunction4()
        {
            // Код для функции меню +
        }
    }
    public class MenuFunctions5
    {
        public void MenuFunction5()
        {
            // Код для функции меню *
        }
    }
}