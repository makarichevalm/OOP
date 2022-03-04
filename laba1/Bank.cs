using System;

namespace Bank
{
    public class Bank
    {
        public string Title;//наименование банка
        public uint NumberDeposits;//число вкладов
        public double ProcentSize;// размер процентной ставки
        public string Type;// тип банка: государственный, частный
        public bool Filials;// наличие филиалов
        public bool Atm; //наличие банкомата
        public uint CreditPeriod;// срок выдаваемого кредита
        public Bank(){}
        public Bank(string name)
        {
            Title = name;
        }
        public Bank(string title, double procent)
        {
            Title = title;
            ProcentSize = procent;
        }
        
        public Bank(string title, uint numberDeposits, double procent, string type, bool filials, bool atm, uint creditPeriod)
        {
            Title = title;
            NumberDeposits = numberDeposits;
            ProcentSize = procent;
            Type = type;
            Filials = filials;
            Atm = atm;
            CreditPeriod = creditPeriod;
        }
        public override string ToString()
        {
            return $"Title (Наименование банка): {Title}\n" +
                $"NumberDeposits (Чиcло вкладов): {NumberDeposits}\n" +
                $"ProcentSize (Размер процентной ставки): {ProcentSize} %\n" +
                $"Type (Тип банка): {Type}\n" +
                $"Filials (Наличие филиалов): {Filials}\n" +
                $"Atm (Наличие банкоматов): {Atm}\n" +
                $"CreditPeriod (Срок выдаваемого кредита): {CreditPeriod}\n";
        }
        public string ConvertToHexadecimal()
        {
            return Convert.ToString(NumberDeposits, 16);
        }
        public void Edit()
        {
            Console.WriteLine("Выберите команду для изменения соответствующего поля из предложенного меню:");
            Console.WriteLine("1. Изменить поле Title (наименование банка)");
            Console.WriteLine("2. Изменить поле NumberDeposits (число вкладов)");
            Console.WriteLine("3. Изменить поле ProcentSize (размер процентной ставки)");
            Console.WriteLine("4. Изменить поле Type (тип банка)");
            Console.WriteLine("5. Изменить поле Filials (наличие филиалов)");
            Console.WriteLine("6. Изменить поле Atm (наличие банкомата)");
            Console.WriteLine("7. Изменить поле CreditPeriod (срок выдаваемого кредита)");
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
                    Console.WriteLine("Изменить значение поля Title на");
                    Title = Console.ReadLine();
                    Console.WriteLine($"Вы изменили значение поля Title на {Title}\n");
                    break;
                case "2":
                    Console.WriteLine("Изменить значение поля NumberDeposits на");
                    string input = Console.ReadLine();
                    bool flag = uint.TryParse(input, out _);
                    while (!flag)
                    {
                        Console.WriteLine("Недопустимое значение для поля NumberDeposits. Введите целое число.");
                        input = Console.ReadLine();
                        flag = uint.TryParse(input, out _);
                    }
                    NumberDeposits = Convert.ToUInt32(input);
                    Console.WriteLine($"Вы изменили значение поля NumberDeposits на {NumberDeposits}\n");
                    break;
                case "3":
                    Console.WriteLine("Изменить значение поля ProcentSize на");
                    string input1 = Console.ReadLine();
                    bool flag1 = double.TryParse(input1, out _);
                    while (!flag1)
                    {
                        Console.WriteLine("Недопустимое значение для поля ProcentSize. Введите число. Например: 3,3");
                        input1 = Console.ReadLine();
                        flag1 = double.TryParse(input1, out _);
                    }
                    ProcentSize = Convert.ToDouble(input1);
                    Console.WriteLine($"Вы изменили значение поля ProcentSize на {ProcentSize}\n");
                    break;
                case "4":
                    Console.WriteLine("Изменить значение поля Type на");
                    Type = Console.ReadLine();
                    Console.WriteLine($"Вы изменили значение поля Type на {Type}\n");
                    break;
                case "5":
                    Console.WriteLine("Изменить значение поля Filials на");
                    string input4 = Console.ReadLine();
                    bool flag4 = bool.TryParse(input4, out _);
                    while (!flag4)
                    {
                        Console.WriteLine("Недопустимое значение для поля Filials. Введите true - если у банка существуют филиалы, false - если нет.");
                        input4 = Console.ReadLine();
                        flag4 = bool.TryParse(input4, out _);
                    }
                    Filials = Convert.ToBoolean(input4);
                    Console.WriteLine($"Вы изменили значение поля Filials на {Filials}\n");
                    break;
                case "6":
                    Console.WriteLine("Изменить значение поля Atm на");
                    string input5 = Console.ReadLine();
                    bool flag5 = bool.TryParse(input5, out _);
                    while (!flag5)
                    {
                        Console.WriteLine("Недопустимое значение для поля Atm. Введите true - если у банка существуют филиалы, false - если нет.");
                        input5 = Console.ReadLine();
                        flag5 = bool.TryParse(input5, out _);
                    }
                    Atm = Convert.ToBoolean(input5);
                    Console.WriteLine($"Вы изменили значение поля Atm на {Atm}\n");
                    break;
                case "7":
                    Console.WriteLine("Изменить значение поля CreditPeriod на");
                    string input6 = Console.ReadLine();
                    bool flag6 = uint.TryParse(input6, out _);
                    while (!flag6)
                    {
                        Console.WriteLine("Недопустимое значение для поля NumberDeposits. Введите целое число.");
                        input6 = Console.ReadLine();
                        flag6 = uint.TryParse(input6, out _);
                    }
                    CreditPeriod = Convert.ToUInt32(input6);
                    Console.WriteLine($"Вы изменили значение поля CreditPeriod на {CreditPeriod}\n");
                    break;
                default:
                    Console.WriteLine("Эта команда в меню не предусмотрена. Попробуйте еще раз\n");
                    break;
            }
        }
        public void Print()
        {
            Console.WriteLine("Выберите команду для вывода соответствующего поля из предложенного меню:");
            Console.WriteLine("1. Вывести поле Title (наименование банка)");
            Console.WriteLine("2. Вывести поле NumberDeposits (число вкладов)");
            Console.WriteLine("3. Вывести поле ProcentSize (размер процентной ставки)");
            Console.WriteLine("4. Вывести поле Type (тип банка)");
            Console.WriteLine("5. Вывести поле Filials (наличие филиалов)");
            Console.WriteLine("6. Вывести поле Atm (наличие банкомата)");
            Console.WriteLine("7. Вывести поле CreditPeriod (срок выдаваемого кредита)");
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
                    Console.WriteLine($"Title (Наименование банка): {Title}\n");
                    break;
                case "2":
                    Console.WriteLine($"NumberDeposits (Чиcло вкладов): {NumberDeposits}\n");
                    break;
                case "3":
                    Console.WriteLine($"ProcentSize (Размер процентной ставки): {ProcentSize} %\n");
                    break;
                case "4":
                    Console.WriteLine($"Type (Тип банка): {Type}\n");
                    break;
                case "5":
                    Console.WriteLine($"Filials (Наличие филиалов): {Filials}\n");
                    break;
                case "6":
                    Console.WriteLine($"Atm (Наличие банкоматов): {Atm}\n");
                    break;
                case "7":
                    Console.WriteLine($"CreditPeriod (Срок выдаваемого кредита): {CreditPeriod}\n");
                    break;
                default:
                    Console.WriteLine("Эта команда в меню не предусмотрена. Попробуйте еще раз\n");
                    break;
            }
        }
    }
}