using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace laba7
{
    /// <summary>
    /// класс Банк
    /// </summary>
    public class Bank
    {
        public delegate void AddClient(string message, string heading);
        public delegate void RemoveClient(string message, string heading);
        public string Title { get; set; }//наименование банка
        public uint NumberDeposits { get; set; }// размер процентной ставки
        public double ProcentSize { get; set; }// размер процентной ставки
        public string Type { get; set; }// тип банка: государственный, частный
        public bool Filials { get; set; }// наличие филиалов
        public bool Atm { get; set; } //наличие банкомата
        public uint CreditPeriod { get; set; }// срок выдаваемого кредита
        public int NumberOfClients = 0;//число клиентов банка

        public static int QuantityBanks = 0;
        public List<Clients> clients = new List<Clients>(); //список клиентов банков
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Bank()
        {
            Title = "Название";
            NumberDeposits = 0;
            ProcentSize = 0;
            Type = "Тип";
            Filials = false;
            Atm = false;
            CreditPeriod = 0;
            QuantityBanks++;
        }
        public event AddClient? Add; //Определение события
        public event RemoveClient? Remove; //Определение события

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
        /// <summary>
        /// Перегрузка оператора +
        /// </summary>
        /// <param name="bank">объект класса Bank</param>
        /// <param name="client">объект класса Clients</param>
        /// <returns></returns>
        public static Bank operator +(Bank bank, Clients client)
        {

            if (!bank.clients.Any(i => i.BankAccount == client.BankAccount
                                    || i.PhoneNumber == client.PhoneNumber))
            {
                bank.clients.Add(client);
                bank.NumberOfClients = bank.clients.Count;
                bank.Add?.Invoke("Клиент успешно добавлен в банк", "Добаление!");//Вызов события
            }
            else
            {
                MessageBox.Show(
                    "Клиент с таким номером счёта или телефона уже существует");
            }
            return bank;
        }
        /// <summary>
        /// Перегрузка оператора -
        /// </summary>
        /// <param name="bank">объект класса Bank</param>
        /// <param name="client">объект класса Clients</param>
        /// <returns></returns>
        public static Bank operator -(Bank bank, Clients client)
        {
            if (bank.clients.Remove(client)) bank.Remove?.Invoke("Клиент успешно удалён из банка", "Удаление");//Вызов события
            bank.NumberOfClients = bank.clients.Count;
            return bank;

        }
    }
}
