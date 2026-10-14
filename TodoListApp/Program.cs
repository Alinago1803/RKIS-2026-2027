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
            //Боярова
            // коммментарий 
            //kjo
            //мяу
        string[]todos = new string[2]
        int count =0;
        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (input == "exit")
            {
                break;
            }
            else if (input == "help")
            {
                Console.WriteLine("help - список команд");
                Console.WriteLine("profile - данные пользователя");
                Console.WriteLine("add \"текст задачи\" - добавить задачу");
                Console.WriteLine("view - вывести список задач");
                Console.WriteLine("exit - выход из программы");
            }
            else if (input == "profile")
            {
                Console.WriteLine($"{name} {lastname}, {yearOfBirth}");
            }
            else if (input.StartsWith("add "))
            {
                string task = input.Substring(4).Trim('"');
                
                if (count >= todos.Length)
                {
                    string[] newTodos = new string[todos.Length * 2];
                    for (int i = 0; i < todos.Length; i++)
                    {
                        newTodos[i] = todos[i];
                    }
                    todos = newTodos;
                }

                todos[count] = task;
                count++;
                Console.WriteLine("Задача добавлена.");
            }
            else if (input == "view")
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }
            }
        }}}
}      