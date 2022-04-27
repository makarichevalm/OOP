using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    /// <summary>
    /// Абстрактный класс Clients - "Клиенты банка"
    /// </summary>
    abstract class Clients
    {
        protected string adress;//фактический адрес
        protected ulong bankAccount;//номер счета
        protected ulong phoneNumber;//номер телефона
    }
    /// <summary>
    /// Наследник от класса Clients - Organization - "Организации"
    /// </summary>
    class Organization : Clients {
        private string title;//наименование организации
        private ulong inn;//инн
        private uint countWriters;// кол-во лиц с правом подписи
        private bool kpp;//наличие кода причины постановки на налоговый учет
        private bool filials;//наличие филиалов
        public Organization(string Adress, ulong BankAccount, ulong PhoneNumber, 
            string Title, ulong Inn, uint CountWriters, bool Kpp, bool Filials)
        {
            adress = Adress;
            bankAccount = BankAccount;
            phoneNumber = PhoneNumber;
            title = Title;
            inn = Inn;
            countWriters = CountWriters;
            kpp = Kpp;
            filials = Filials;
        }
        /// <summary>
        /// Метод для работы с полем adress
        /// </summary>
        public string Adress { get { return adress; } set { adress = value; } }
        /// <summary>
        /// Метод для работы с полем bankAccount
        /// </summary>
        public ulong BankAccount { get { return bankAccount; } set { bankAccount = value; } }
        /// <summary>
        /// Метод для работы с полем phoneNumber
        /// </summary>
        public ulong PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        /// <summary>
        /// Метод для работы с частным полем title
        /// </summary>
        public string Title { get { return title; } set { title = value; } }
        /// <summary>
        /// Метод для работы с частным полем inn
        /// </summary>
        public ulong INN { get { return inn; } set { inn = value; } }
        /// <summary>
        /// Метод для работы с частным полем countWriters
        /// </summary>
        public uint СountWriters { get { return countWriters; } set { countWriters = value; } }
        /// <summary>
        /// Метод для работы с частным полем kpp
        /// </summary>
        public bool Kpp { get { return kpp; } set { kpp = value; } }
        /// <summary>
        /// Метод для работы с частным полем filials
        /// </summary>
        public bool Filials { get { return filials; } set { filials = value; } }
        public override string ToString()
        {
            var _kpp = kpp ? "Есть" : "Нет";
            var _filials = filials ? "Есть" : "Нет";
            return
                $"Номер счета: {bankAccount}\n" +
                $"Номер телефона: {phoneNumber} %\n" +
                $"Наименование организации: {title}\n" +
                $"ИНН: {inn}\n" +
                $"Адрес: {adress}\n" +
                $"Количество лиц с правом подписи: {countWriters}\n" +
                $"Наличие КПП: {_kpp}\n" +
                $"Наличие филиалов: {_filials}\n";
        }
    }
    /// <summary>
    /// Наследник от класса Clients - Individuals - "Чаcтные лица"
    /// </summary>
    class Individuals : Clients
    {
        private string name; //имя клиента
        private string surname; //фамилия клиента
        private string middleName; //отчество клиента
        private uint passportNumber; //номер паспорта
        private uint passportSeria; //серия паспорта
        private bool biometricData;//наличие биометрических данных
        public Individuals(string Adress, ulong BankAccount, ulong PhoneNumber, 
            string Name, string Surname, string MiddleName, uint PassportNumber, uint PassportSeria, bool BiometricData)
        {
            adress = Adress;
            bankAccount = BankAccount;
            phoneNumber = PhoneNumber;
            name = Name;
            surname = Surname;
            middleName = MiddleName;
            passportNumber = PassportNumber;
            passportSeria = PassportSeria;
            biometricData = BiometricData;

        }
        /// <summary>
        /// Метод для работы с полем adress
        /// </summary>
        public string Adress { get { return adress; } set { adress = value; } }
        /// <summary>
        /// Метод для работы с полем bankAccount
        /// </summary>
        public ulong BankAccount { get { return bankAccount; } set { bankAccount = value; } }
        /// <summary>
        /// Метод для работы с полем phoneNumber
        /// </summary>
        public ulong PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        /// <summary>
        /// Метод для работы с частным полем title
        /// </summary>
        /// <summary>
        /// Метод для работы с частным полем name
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// Метод для работы с частным полем surname
        /// </summary>
        public string Surname { get { return surname; } set { surname = value; } }
        /// <summary>
        /// Метод для работы с частным полем middleName
        /// </summary>
        public string MiddleName { get { return middleName; } set { middleName = value; } }
        /// <summary>
        /// Метод для работы с частным полем passportNumber
        /// </summary>
        public uint PassportNumber { get { return passportNumber; } set { passportNumber = value; } }
        /// <summary>
        /// Метод для работы с частным полем passportSeria
        /// </summary>
        public uint PassportSeria { get { return passportSeria; } set { passportSeria = value; } }
        /// <summary>
        /// Метод для работы с частным полем biometricData
        /// </summary>
        public bool BiometricData { get { return biometricData; } set { biometricData = value; } }
        public override string ToString()
        {
            var _biometricData = biometricData ? "Есть" : "Нет";
            return 
                $"Номер счета: {bankAccount}\n" +
                $"Номер телефона: {phoneNumber} %\n" +
                $"Имя: {name}\n" +
                $"Фамилия: {surname}\n" +
                $"Отчество: {middleName}\n" +
                $"Адрес: {adress}\n" +
                $"Номер паспорта: {passportNumber}\n"+
                $"Серия паспорта: {passportSeria}\n" +
                $"Наличие биометрических данных: {_biometricData}\n";
        }
    }
}
