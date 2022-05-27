using System;

namespace laba8
{
    public class Bank :IComparable<Bank>
    {
        public string Title { get; set; }//наименование банка
        public uint NumberDeposits { get; set; }//число вкладов
        public double ProcentSize { get; set; }// размер процентной ставки
        public string Type { get; set; }// тип банка: государственный, частный
        public bool Filials { get; set; }// наличие филиалов
        public bool Atm { get; set; } //наличие банкомата
        public uint CreditPeriod { get; set; }// срок выдаваемого кредита

        public static int QuantityBanks = 0;
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
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="numberDeposits"></param>
        /// <param name="procent"></param>
        /// <param name="type"></param>
        /// <param name="filials"></param>
        /// <param name="atm"></param>
        /// <param name="creditPeriod"></param>
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
        public int CompareTo(Bank other)
        {
            if (other is null) throw new ArgumentException("Некорректное значение параметра");
            return Title.CompareTo(other.Title);
        }
    }
}
