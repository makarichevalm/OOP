using System;

namespace laba3
{


/// <summary>
/// класс Банк
/// </summary>
    public class Bank
    {
        private string Title;//наименование банка
        private uint NumberDeposits;//число вкладов
        private double ProcentSize;// размер процентной ставки
        private string Type;// тип банка: государственный, частный
        private bool Filials;// наличие филиалов
        private bool Atm; //наличие банкомата
        private uint CreditPeriod;// срок выдаваемого кредита

        public static int QuantityBanks = 0;

        /// <summary>
        ///  Метод для работы с частным полем Title
        /// </summary>
        public string TitleBank { get { return Title; } set { Title = value; } }
        /// <summary>
        /// Метод для работы с частным полем NumberDeposits
        /// </summary>
        public uint NumberDepBank { get { return NumberDeposits; } set { NumberDeposits = value; } }
        /// <summary>
        /// Метод для работы с частным полем ProcentSize
        /// </summary>
        public double ProcentBank { get { return ProcentSize; } set { ProcentSize = value; } }
        /// <summary>
        /// Метод для работы с частным полем Type
        /// </summary>
        public string TypeBank { get { return Type; } set { Type = value; } }
        /// <summary>
        /// Метод для работы с частным полем Filials
        /// </summary>
        public bool FilialsBank { get { return Filials; } set { Filials = value; } }
        /// <summary>
        /// Метод для работы с частным полем Atm
        /// </summary>
        public bool AtmBank { get { return Atm; } set { Atm = value; } }
        /// <summary>
        /// Метод для работы с частным полем CreditPeriod
        /// </summary>
        public uint CreditPeriodBank { get { return CreditPeriod; } set { CreditPeriod = value; } }
        
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Bank()
        {
            Title = "Сбербанк";
            NumberDeposits = 5000;
            ProcentSize = 3.8;
            Type = "государственный";
            Filials = true;
            Atm = true;
            CreditPeriod = 3;
            QuantityBanks++;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="title">Название банка</param>
        /// <param name="numberDeposits">Количество вкладов</param>
        /// <param name="procent">Пртоцентная ставка</param>
        /// <param name="type">Тип банка</param>
        /// <param name="filials">Наличие филиалов</param>
        /// <param name="atm">Наличие банкоматов</param>
        /// <param name="creditPeriod">Срок выдачи кредита</param>
        public Bank(string title, uint numberDeposits, double procent, string type, bool filials, bool atm, uint creditPeriod)
        {
            Title = title;
            NumberDeposits = numberDeposits;
            ProcentSize = procent;
            Type = type;
            Filials = filials;
            Atm = atm;
            CreditPeriod = creditPeriod;
            QuantityBanks++;
        }

        /// <summary>
        /// Переопределение метода toString()
        /// </summary>
        /// <returns>Информация о банке</returns>
        public override string ToString()
        {

            var _Atm = Atm ? "Есть" : "Нет";
            var _Filials = Filials ? "Есть" : "Нет";
            return $"Наименование банка: {Title}\n" +
                $"Чиcло вкладов: {NumberDeposits}\n" +
                $"Размер процентной ставки: {ProcentSize} %\n" +
                $"Тип банка: {Type}\n" +
                $"Срок выдаваемого кредита: {CreditPeriod}\n" +
                $"Наличие банкоматов: {_Atm}\n" +
                $"Наличие филиалов: {_Filials}\n";
        }
    }
}

