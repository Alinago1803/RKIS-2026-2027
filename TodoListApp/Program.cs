using System;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сделала Боярова и Горелова");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите ваш год рождения");
            int yearOfBirth = int.Parse(Console.ReadLine());
            int age = 2026 - yearOfBirth;
            Console.WriteLine("Добавлен пользователь "+ name + " " + lastname + ", возраст- " + age.ToString());
        }
    }
}
