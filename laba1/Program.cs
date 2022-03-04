using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа № 1. Класс. Создание объекта. Работа с консолью.");
            Console.WriteLine("Группа: 20ВП1. Вариант 6\nДюжева Анна, Макаричева Елизавета \n");
            Bank b1 = new Bank("Сбербанк", 5000, 3.8, "государственный", true, true,3);
            bool mark = true;
        while (mark)
            {
                Console.WriteLine("Выберите команду из предложенного меню:");
                Console.WriteLine("1. Вывод полей класса с использованием переопределенного метода ToString()");
                Console.WriteLine("2. Вывод поля класса, непосредственно обращаясь к нему");
                Console.WriteLine("3. Вывод поля класса с помощью метода, выводящего на экран значение определенного поля");
                Console.WriteLine("4. Вывод числового поля в шестнадцатеричном представлении");
                Console.WriteLine("5. Изменение поля");
                Console.WriteLine("6. Выход");
                string choose = Console.ReadLine();
                bool res = int.TryParse(choose, out _);
                while (!res)
                {
                    Console.WriteLine("Эта команда в меню не предусмотрена. Попробуйте еще раз");
                    choose = Console.ReadLine();
                    res = int.TryParse(choose, out _);
                }
                switch (choose)
                {
                    
                    case "1":
                        Console.WriteLine("\nВывод полей класса с использованием переопределенного метода ToString():\n");
                        Console.WriteLine(b1.ToString()+ "\n");
                        break;
                    case "2":
                        Console.WriteLine("\nВывод поля класса, непосредственно обращаясь к нему:\n");
                        Console.WriteLine("Title: "+b1.Title+ "\n");
                        break;
                    case "3":
                        Console.WriteLine("\nВывод поля класса с помощью метода, выводящего на экран значение определенного поля\n");
                        b1.Print();
                        break;
                    case "4":
                        Console.WriteLine("\nВывод числового поля в шестнадцатеричном представлении\n");
                        Console.WriteLine("Поле NumberDeposits: "+b1.NumberDeposits+" в 16 сс = " + b1.ConvertToHexadecimal()+"\n");
                        break;
                    case "5":
                        Console.WriteLine("\nИзменение поля\n");
                        b1.Edit();
                        break;
                    case "6":
                        mark = false;
                        break;
                    default:
                        Console.WriteLine("Эта команда в меню не предусмотрена. Попробуйте еще раз\n");
                        break;
                }
            }
        }
    }
}
