using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace laba8
{
    public partial class Form1 : Form
    {
        Bank_Collection<Bank> B = new Bank_Collection<Bank>();
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsEmpty()
        {
            TextBankTitle.Text = "";
            TextBankDepos.Text = "";
            TextBankCredit.Text = "";
            TextBankProc.Text = "";
            TextBankType.Text = "";
            bool flag = false;
            if (BankType.SelectedIndex == -1)
            {
                TextBankType.Text = "Заполните поле Тип банка";
                TextBankType.ForeColor = Color.Red;
                flag = true;
            }
            if (string.IsNullOrEmpty(BankTitle.Text))
            {
                TextBankTitle.Text = "Заполните поле Наименование банка";
                TextBankTitle.ForeColor = Color.Red;
                flag = true;
            }
            if (string.IsNullOrEmpty(BankDeposits.Text))
            {
                TextBankDepos.Text = "Заполните поле Число вкладов";
                TextBankDepos.ForeColor = Color.Red;
                flag = true;
            }
            else if(!uint.TryParse(BankDeposits.Text, out _))
            {
                TextBankDepos.Text = "Введите целое неотрицательное число";
                TextBankDepos.ForeColor = Color.Red;
                flag = true;
            }
            if (string.IsNullOrEmpty(BankProcent.Text))
            {
                TextBankProc.Text = "Заполните поле Размер процентной ставки";
                TextBankProc.ForeColor = Color.Red;
                flag = true;
            }
            else if (!double.TryParse(BankProcent.Text, out _) || (Convert.ToDouble(BankProcent.Text))<=0)
            {
                TextBankProc.Text = "Введите неотрицательное число";
                TextBankProc.ForeColor = Color.Red;
                flag = true;
            }
            if (string.IsNullOrEmpty(BankCredit.Text))
            {
                TextBankCredit.Text = "Заполните поле Срок кредита";
                TextBankCredit.ForeColor = Color.Red;
                flag = true;
            }
            else if (!uint.TryParse(BankCredit.Text, out _))
            {
                TextBankCredit.Text = "Введите целое неотрицательное число";
                TextBankCredit.ForeColor = Color.Red;
                flag = true;
            }

            return flag;
        }
        private void Button_add_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                return;
            }
            string typeB;
            string title = BankTitle.Text;
            int type = BankType.SelectedIndex;
            bool atm = BankAtmYes.Checked;
            bool filials = BankFilNo.Checked;
            uint deposit = Convert.ToUInt32(BankDeposits.Text);
            uint period = Convert.ToUInt32(BankCredit.Text);
            double procent = Convert.ToDouble(BankProcent.Text);
            if (type == 0)
            {
                typeB = "Государственный";
            }
            else
            {
                typeB = "Частный";
            }
            Bank newB = new Bank(title, deposit, procent, typeB, filials, atm, period);
            /*if (B.Contains(newB))
            {
                MessageBox.Show("Банк с такими данными уже существует");
                return;
            }
            else {*/
                B.Add(newB);
            //}
            BankTitle.Text = "";
            BankType.SelectedIndex = -1;
            BankAtmYes.Checked = false;
            BankFilNo.Checked = false;
            BankDeposits.Text = "";
            BankCredit.Text = "";
            BankProcent.Text ="";
            ShowBank(B);
            LinqText.Text = "";
        }
        private void panel2_Paint(object sender, PaintEventArgs e){}
        private void ToString(Bank_Collection<Bank> bank)
        {
            foreach (var b in bank)
            {
                var _Atm = b.Atm ? "Есть" : "Нет";
                var _Filials = b.Filials ? "Есть" : "Нет";
                Banks.Text += $"Наименование банка: {b.Title}{Environment.NewLine}" +
                $"Чиcло вкладов: {b.NumberDeposits}{Environment.NewLine}" +
                $"Размер процентной ставки: {b.ProcentSize} %{Environment.NewLine}" +
                $"Тип банка: {b.Type}{Environment.NewLine}" +
                $"Срок выдаваемого кредита: {b.CreditPeriod}{Environment.NewLine}" +
                $"Наличие банкоматов: {_Atm}{Environment.NewLine}" +
                $"Наличие филиалов: {_Filials}{Environment.NewLine}"+
                $"{ Environment.NewLine}";
            }
        }
        private void ShowBank(Bank_Collection<Bank> bank)
        {
            Banks.Text = "";
            ToString(bank);
        }
        private void butLinq_Click(object sender, EventArgs e)
        {
            LinqText.Text = "";
            if (B.Count > 0)
            {
                
                //кол-во объектов в коллекции содержащих одно значение поля
                int number = (from b in B where b.Type == "Государственный" select b).Count();
                LinqText.Text += $"Количество государственных банков:{Environment.NewLine}" +
                    $"{ number}{Environment.NewLine}" +
                    $"{Environment.NewLine}";
                //банки с максимальным размером проц ставки
                LinqText.Text += $"Банки с max размером процентной ставки:{Environment.NewLine}{Environment.NewLine}";
                var bank_max = from b in B
                               where b.ProcentSize == B.Max().ProcentSize
                               select b;

                foreach (var b in bank_max)
                    LinqText.Text += b + $"{Environment.NewLine}";
                LinqText.Text += $"{Environment.NewLine}";
                //банки с мин размером проц ставки
                LinqText.Text += $"Банки с min размером процентной ставки:{Environment.NewLine}{Environment.NewLine}";
                var bank_min = from b in B
                               where b.ProcentSize == B.Min().ProcentSize
                               select b;

                foreach (var b in bank_min)
                    LinqText.Text += b + $"{Environment.NewLine}";
                LinqText.Text += $"{Environment.NewLine}";
                Bank_Collection<Bank> BSortmax = B;
                //сортировка банков в алфавитном порядке по названию
                LinqText.Text += $"Сортировка банков по названию в алфавитном порядке:{Environment.NewLine}{Environment.NewLine}";
                var ordered = BSortmax.OrderBy(b => b.Title);
                foreach (var b in ordered)
                    LinqText.Text += b + $"{Environment.NewLine}";
                LinqText.Text += $"{Environment.NewLine}";
                Bank_Collection<Bank> BSortmin = B;
                //сортировка в обратном порядке по названию
                LinqText.Text += $"Сортировка банков по названию в обратном алфавитному порядке:{Environment.NewLine}{Environment.NewLine}";
                var d_ordered = BSortmin.OrderByDescending(b => b.Title);
                foreach (var b in d_ordered)
                    LinqText.Text += b + $"{Environment.NewLine}";
                LinqText.Text += $"{Environment.NewLine}";
            }
            else
            {
                MessageBox.Show("Занесите данные о банках!");
                return;
            }
        }
    }
}
