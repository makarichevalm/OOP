using System;
using System.Windows.Forms;

namespace laba5
{
    /// <summary>
    /// Абстрактный класс Clients - "Клиенты банка"
    /// </summary>
    public abstract class Clients
    {
        public string Type { get; set; }//организация или физическое лицо
        public string Adress { get; set; }//фактический адрес
        public ulong BankAccount { get; set; }//номер счета (16)
        public ulong PhoneNumber { get; set; }//номер телефона (11)
    }
    /// <summary>
    /// Наследник от класса Clients - Organization - "Организации"
    /// </summary>
    class Organization : Clients
    {
        public string Title { get; set; }//наименование организации
        public ulong Inn { get; set; }//инн (12)
        public uint CountWriters { get; set; }// кол-во лиц с правом подписи
        public bool Kpp { get; set; }//наличие кода причины постановки на налоговый учет
        public bool Filials { get; set; }//наличие филиалов
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="type"></param>
        /// <param name="adress"></param>
        /// <param name="bankAccount"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="title"></param>
        /// <param name="inn"></param>
        /// <param name="countWriters"></param>
        /// <param name="kpp"></param>
        /// <param name="filials"></param>
        public Organization(string type, string adress, ulong bankAccount, ulong phoneNumber,
            string title, ulong inn, uint countWriters, bool kpp, bool filials)
        {
            Type = type;
            Adress = adress;
            BankAccount = bankAccount;
            PhoneNumber = phoneNumber;
            Title = title;
            Inn = inn;
            CountWriters = countWriters;
            Kpp = kpp;
            Filials = filials;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="type"></param>
        /// <param name="adress"></param>
        /// <param name="bankAccount"></param>
        /// <param name="phoneNumber"></param>
        public Organization(string type, string adress, ulong bankAccount, ulong phoneNumber)
        {
            Type = type;
            Adress = adress;
            BankAccount = bankAccount;
            PhoneNumber = phoneNumber;
            Title = "ИП ФотоГраф";
            Inn = 132808730606;
            CountWriters = 3;
            Kpp = true;
            Filials = false;
        }
        /// <summary>
        /// Метод, выводящий информацию об организации
        /// </summary>
        public void GetInfo()
        {
            var _filials = Filials ? "Есть" : "Нет";
            MessageBox.Show($"Информация об организации {Title}:\n" +
                $"Компания {Title} находится по адресу {Adress}.\n" +
                $"Связаться с директором компании можно по номеру телефона {PhoneNumber}.\n" +
                $"У этой компании {_filials} филиалы(-ов).");
        }
        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var _kpp = Kpp ? "Есть" : "Нет";
            var _filials = Filials ? "Есть" : "Нет";
            return
                $"Номер счета: {BankAccount} {Environment.NewLine}" +
                $"Номер телефона: {PhoneNumber} {Environment.NewLine}" +
                $"Наименование организации: {Title} {Environment.NewLine}" +
                $"ИНН: {Inn} {Environment.NewLine}" +
                $"Адрес: {Adress} {Environment.NewLine}" +
                $"Количество лиц с правом подписи: {CountWriters} {Environment.NewLine}" +
                $"Наличие КПП: {_kpp} {Environment.NewLine}" +
                $"Наличие филиалов: {_filials} {Environment.NewLine}" +
                $"{Environment.NewLine}";
        }
    }
    /// <summary>
    /// Наследник от класса Clients - Individuals - "Физические лица"
    /// </summary>
    class Individuals : Clients
    {
        public string Name { get; set; } //имя клиента
        public string Surname { get; set; } //фамилия клиента
        public string MiddleName { get; set; } //отчество клиента
        public uint PassportNumber { get; set; } //номер паспорта (6)
        public uint PassportSeria { get; set; } //серия паспорта (4)
        public bool BiometricData { get; set; }//наличие биометрических данных
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="type"></param>
        /// <param name="adress"></param>
        /// <param name="bankAccount"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="middleName"></param>
        /// <param name="passportNumber"></param>
        /// <param name="passportSeria"></param>
        /// <param name="biometricData"></param>
        public Individuals(string type, string adress, ulong bankAccount, ulong phoneNumber,
            string name, string surname, string middleName, uint passportNumber, uint passportSeria, bool biometricData)
        {
            Type = type;
            Adress = adress;
            BankAccount = bankAccount;
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            PassportNumber = passportNumber;
            PassportSeria = passportSeria;
            BiometricData = biometricData;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="type"></param>
        /// <param name="adress"></param>
        /// <param name="bankAccount"></param>
        /// <param name="phoneNumber"></param>
        public Individuals(string type, string adress, ulong bankAccount, ulong phoneNumber)
        {
            Type = type;
            Adress = adress;
            BankAccount = bankAccount;
            PhoneNumber = phoneNumber;
            Name = "Иван";
            Surname = "Грозов";
            MiddleName = "Дмитриевич";
            PassportNumber = 338206;
            PassportSeria = 5618;
            BiometricData = false;
        }
        /// <summary>
        /// Метод, выводящий информацию о физическом лице
        /// </summary>
        public void GetInfo()
        {
            var _biometricData = BiometricData ? "Есть" : "Нет";
            MessageBox.Show($"Информация о физическом лице {Surname} {Name} {MiddleName}:\n" +
                $"{Surname} {Name} {MiddleName} проживает по адресу {Adress}.\n" +
                $"Связаться с этим человеком можно по номеру телефона {PhoneNumber}.\n" +
                $"У данного физического лица {_biometricData} биометрические(-их) данные(-ых).");
        }
        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var _biometricData = BiometricData ? "Есть" : "Нет";
            return
                $"Номер счета: {BankAccount} {Environment.NewLine}" +
                $"Номер телефона: {PhoneNumber} {Environment.NewLine}" +
                $"Фамилия: {Surname} {Environment.NewLine}" +
                $"Имя: {Name} {Environment.NewLine}" +
                $"Отчество: {MiddleName} {Environment.NewLine}" +
                $"Адрес: {Adress} {Environment.NewLine}" +
                $"Номер паспорта: {PassportNumber} {Environment.NewLine}" +
                $"Серия паспорта: {PassportSeria} {Environment.NewLine}" +
                $"Наличие биометрических данных: {_biometricData} {Environment.NewLine}" +
                $"{Environment.NewLine}";
        }
    }
}
