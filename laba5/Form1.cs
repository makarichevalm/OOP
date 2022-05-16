using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba5
{
    public partial class Form1 : Form
    {
        private Bank bank = new Bank("Сбербанк", 53, 5.5, "государственный", true, true, 5);
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsEmpty()
        {
            typeText.Text = "";
            accountText.Text = "";
            phoneText.Text = "";
            adressText.Text = "";
            bool flag = false;
            if (TypeClient.SelectedIndex == -1)
            {
                typeText.Text = "Заполните поле Тип клиента";
                typeText.ForeColor = Color.Red;
                flag = true;

            }
            if (string.IsNullOrEmpty(BankAccount.Text))
            {
                accountText.Text = "Заполните поле Номер счета";
                accountText.ForeColor = Color.Red;
                flag = true;
            }
            else if(BankAccount.Text.Length != 4) //(10, 15)
            {
                accountText.Text = "Номер счета должен содержать 4 цифры";
                accountText.ForeColor = Color.Red;
                flag = true;
            }
            if (string.IsNullOrEmpty(PhoneNumber.Text))
            {
                phoneText.Text = "Заполните поле Номер телефона";
                phoneText.ForeColor = Color.Red;
                flag = true;
            }
            else if (PhoneNumber.Text.Length != 6)//(10, 11) Convert.ToUInt64(------)
            {
                phoneText.Text = "Номер счета должен содержать 6 цифр";
                phoneText.ForeColor = Color.Red;
                flag = true;
            }
            if (string.IsNullOrEmpty(Adress.Text))
            {
                adressText.Text = "Заполните поле Фактический адрес";
                adressText.ForeColor = Color.Red;
                flag = true;
            }
            return flag;
    }
        private void AddClient_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                return;
            }
            int selectTipe = TypeClient.SelectedIndex;//0-физическое лицо, 1-организация
            string adress = Adress.Text;
            ulong account = Convert.ToUInt64(BankAccount.Text);
            ulong phone = Convert.ToUInt64(PhoneNumber.Text);
            if(selectTipe == 0)
            {
                string type = "Физическое лицо";
                Clients client = new Individuals(type, adress, account, phone);
                bank += client;
            }
            else
            {
                string type = "Организация";
                Clients client = new Organization(type, adress, account, phone);
                bank += client;
            }
            ShowClient(bank);
        }
        private void DeleteClient_Click(object sender, EventArgs e)
        {
            ulong acc = Convert.ToUInt64(AccountB.Text);
            var find = bank.clients.Find(b => b.BankAccount == acc);
            if ( find != null)
            {
                bank -= find;
            }
            else
            {
                MessageBox.Show(
                    "Клиент с таким номером счета не найден!");
                return;
            }
            ShowClient(bank);
        }
        private void ShowClient(Bank bank)
        {
            RandomClients.Text = "";
            foreach (var b in bank.clients)
            {
                RandomClients.Text += b.ToString();
            }
        }
        private void BankAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void ShowInfo_Click(object sender, EventArgs e)
        {
            ulong acc = Convert.ToUInt64(AccountB.Text);
            var find = bank.clients.Find(b => b.BankAccount == acc);
            if (find != null)
            {
                if(find.Type == "Физическое лицо")
                {
                    Individuals ind = (Individuals)find;
                    ind.GetInfo();
                }
                if(find.Type == "Организация")
                {
                    Organization org = (Organization)find;
                    org.GetInfo();
                }
            }
            else
            {
                MessageBox.Show(
                    "Клиент с таким номером счета не найден!");
                return;
            }
        }

        private void butStartTime_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerText.Text = "Объекты генерируются";
        }

        private void butFinishTime_Click(object sender, EventArgs e)
        {         
            timer1.Enabled = false;
            TimerText.Text = "Объекты не генерируются";
        }
        private void AddRandomCl()
        {
            Random rnd = new Random();
            int type = rnd.Next(0, 2);
            string adress = $"Проспект {rnd.Next(1, 30)}, дом № {rnd.Next(1, 50)}";
            ulong account = (ulong)rnd.Next(1000, 100000);
            ulong phone = (ulong)rnd.Next(100000, 999999);
            if (type == 0)
            {
                string surname = $"Фамилия_{rnd.Next(1, 100)}";
                string name = $"Имя_{rnd.Next(1, 100)}";
                string midName = $"Отчество_{rnd.Next(1, 100)}";
                uint passNum = (uint)rnd.Next(100000, 999999);
                uint passSer = (uint)rnd.Next(1000, 9999);
                Clients client = new Individuals("Физическое лицо", adress, account, phone, name, surname, midName, passNum, passSer, false);
                bank += client;
            }
            else if (type == 1)
            {
                string title = $"Компания_{rnd.Next(1, 100)}";
                ulong inn = (ulong)rnd.Next(100000, 999999);
                uint countWriters = (uint)rnd.Next(0, 5);
                Clients client = new Organization("Организация", adress, account, phone, title, inn, countWriters, false, true);
                bank += client;
            }
            ShowClient(bank);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AddRandomCl();
        }
    }
}
