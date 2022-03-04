using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work2
{
    public class Bank
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
            return $"Title (Наименование банка): {Title}\n" +
                $"NumberDeposits (Чиcло вкладов): {NumberDeposits}\n" +
                $"ProcentSize (Размер процентной ставки): {ProcentSize} %\n" +
                $"Type (Тип банка): {Type}\n" +
                $"Filials (Наличие филиалов): {_Filials}\n" +
                $"Atm (Наличие банкоматов): {_Atm}\n" +
                $"CreditPeriod (Срок выдаваемого кредита): {CreditPeriod}\n";
        }

        public void ShowName()
        {
            Console.WriteLine("Library name: " + Title);
        }

    }
}


