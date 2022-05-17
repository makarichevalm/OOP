using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace laba6
{
    public partial class Form1 : Form
    {
        List<Individuals> clients = new List<Individuals>();

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
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
            if (string.IsNullOrEmpty(type.Text))
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
            else if(BankAccount.Text.Length != 4)
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
            else if (PhoneNumber.Text.Length != 6)
            {
                phoneText.Text = "Номер телефона должен содержать 6 цифр";
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
            try
            {
                if (IsEmpty())
                {
                    return;
                }
                string selectType = type.Text;//0-физическое лицо, 1-организация
                string adress = Adress.Text;
                ulong account = Convert.ToUInt64(BankAccount.Text);
                ulong phone = Convert.ToUInt64(PhoneNumber.Text);
                if (!clients.Any(i => i.BankAccount == account
                                    || i.PhoneNumber == phone))
                {
                    clients.Add(new Individuals(selectType, adress, account, phone));
                }
                else
                {
                    MessageBox(new IntPtr(0), "Клиент с таким номером счёта или телефона уже существует"
                        , "Ошибка", 0);
                    
                }
                ShowClient(clients);
            }
            catch (SystemException ex)
            {
                MessageBox(new IntPtr(0), ex.Message, "Ошибка", 0);
               
            }
        }
        private void ShowClient(List<Individuals> clients)
        {
            RandomClients.Text = "";
            foreach (var b in clients)
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
            var find = clients.Find(b => b.BankAccount == acc);
            if (find != null)
            {
                    Individuals ind = (Individuals)find;
                    ind.GetInfo();
            }
            else
            {
                MessageBox(new IntPtr(0), "Клиент с таким номером счета не найден!"
                        , "Ошибка", 0);
                
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                throw new MyException("Кастомное исключение сработало правильно. Это текст его сообщения:", DateTime.Now);
            }
            catch (MyException ex)
            {
                MessageBox(new IntPtr(0), ex + $"\nВремя вызова исключения: {ex.Date}",
                   "Ошибка", 0);
            }
            catch (Exception ex)
            {
                MessageBox(new IntPtr(0), ex.ToString() + $"\nЧто-то пошло не так",
                   "Ошибка", 0);
            }
        }
    }
}
