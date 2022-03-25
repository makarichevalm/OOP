using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace laba3
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Bank> banks = new Dictionary<int, Bank>();
        private Dictionary<int, Bank> banksRND = new Dictionary<int, Bank>();
        private Bank[] banksArray = new Bank[N];
        private const int N = 100;
        public Form1()
        {
            InitializeComponent();
            listView1.Items.Add("Случайная");
            listView1.Items.Add("Последовательная");
        }
        private bool isEmpty(TextBox item)
        {
            return string.IsNullOrEmpty(item.Text);
        }
        private bool isEmpty()
        {
            return
                isEmpty(BankTitle) ||
                isEmpty(BankType) ||
                isEmpty(BankProcent) ||
                isEmpty(BankCredit) ||
                isEmpty(BankDeposits);
        }
        private void ChangeComboBox1()
        {
            if (banks.Count == 0)
                MessageBox.Show("Банков не существует!");
            else
            {
                comboBox1.Items.Clear();
                foreach (var pair in banks)
                    comboBox1.Items.Add(pair.Value.TitleBank);
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            uint deposits;
            uint periods = 1;
            double procents = 0;
            var result =
                uint.TryParse(BankDeposits.Text, out deposits) &&
                double.TryParse(BankProcent.Text, out procents) &&
                uint.TryParse(BankCredit.Text, out periods) &&
                procents > 0;
            BankDeposits.BackColor = Color.White;
            BankProcent.BackColor = Color.White;
            BankCredit.BackColor = Color.White;
            if (!result)
            {
                MessageBox.Show("Некорректные данные");
                if (!uint.TryParse(BankDeposits.Text, out deposits))
                {
                    BankDeposits.BackColor = Color.FromArgb(255, 0, 0);
                }
                if (!double.TryParse(BankProcent.Text, out procents)  || (procents <= 0) )
                {
                    BankProcent.BackColor = Color.FromArgb(255, 0, 0);
                }
                if (!uint.TryParse(BankCredit.Text, out periods))
                {
                    BankCredit.BackColor = Color.FromArgb(255, 0, 0);
                }
                return;
            }
            string title = BankTitle.Text;
            string type = BankType.Text;
            bool atm = BankAtmYes.Checked;
            bool filials = BankFilNo.Checked;
            uint deposit = deposits;
            uint period = periods;
            double procent = procents;

            foreach (var pair in banks)
            {
                if (pair.Value.TitleBank == title)
                {
                    MessageBox.Show("Банк с таким названием уже существует!");
                    return;
                }
            }
            banks.Add(Bank.QuantityBanks, new Bank(title, deposit, procent, type, filials, atm, period));
            ChangeComboBox1();
            label9.Text = "Количество созданных банков: " + banks.Count;
        }
        private void button_show_Click_1(object sender, EventArgs e)
        {
            if (banks.Count == 0)
            {
                MessageBox.Show("Банков не существует");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите банк!");
                return;
            }
            else
            {
                foreach (var pair in banks)
                    if (pair.Value.TitleBank == comboBox1.Text)
                    {
                        BankTitle.Text = pair.Value.TitleBank;
                        BankType.Text = pair.Value.TypeBank;
                        BankDeposits.Text = pair.Value.NumberDepBank.ToString();
                        BankProcent.Text = pair.Value.ProcentBank.ToString();
                        BankCredit.Text = pair.Value.CreditPeriodBank.ToString();
                        BankFilNo.Checked = pair.Value.FilialsBank;
                        BankAtmYes.Checked = pair.Value.AtmBank;
                        label12.Text = pair.Value.ToString();
                        break;
                    }
            }
    }
        private void button_change_Click_1(object sender, EventArgs e)
        {
            double procent;
            var result =
                uint.TryParse(BankDeposits.Text, out _) &&
                double.TryParse(BankProcent.Text, out procent) &&
                uint.TryParse(BankCredit.Text, out _) &&
                procent > 0;
            
            if (!result)
            {
                MessageBox.Show("Некорректные данные");
                return;
            }
            if (banks.Count == 0)
                MessageBox.Show("Банков не существует");
            else if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Выберите банк!");
            else
            {
                foreach (var pair in banks)
                {
                    if (pair.Value.TitleBank == comboBox1.Text)
                    {
                        pair.Value.TitleBank = BankTitle.Text;
                        pair.Value.TypeBank = BankType.Text;
                        pair.Value.NumberDepBank = Convert.ToUInt32(BankDeposits.Text);
                        pair.Value.ProcentBank = Convert.ToUInt32(BankProcent.Text);
                        pair.Value.CreditPeriodBank = Convert.ToUInt32(BankCredit.Text);
                        pair.Value.FilialsBank = BankFilNo.Checked;
                        pair.Value.AtmBank = BankAtmYes.Checked;
                        label12.Text = pair.Value.ToString();
                        button_show_Click_1(sender, e);
                        break;
                    }
                }
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            if(Bank.QuantityBanks == 0)
            {
                MessageBox.Show("Банков не существует!");
                return;
            }
            string val = comboBox1.Text;
            foreach(var pair in banks)
            {
                if(val == pair.Value.TitleBank)
                {
                    banks.Remove(pair.Key);
                    comboBox1.Items.Remove(val);
                    comboBox1.Text = "";
                    
                    break;
                }
            }
            label12.Text = "";
            ChangeComboBox1();
            label9.Text = "Количество созданных банков: " + banks.Count;
        }
        private void button_deleteAll_Click(object sender, EventArgs e)
        {
            banks.Clear();
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            label12.Text = "";
            label9.Text = "Количество созданных банков: " + banks.Count;
            ChangeComboBox1();
        }
        private void Generate_Button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            
            for (int i = 0; i < N ; i++)
            {
                string title = "Банк_" + rnd.Next(0, 1000001);
                string type = stringConvertor(rnd.Next(0, 2));
                bool atm = boolConvertor(rnd.Next(0, 2));
                bool filials = boolConvertor(rnd.Next(0, 2));

                uint deposit = (uint)(rnd.Next(0, 100));
                uint period = (uint)(rnd.Next(0, 25));
                double procent = (uint)(rnd.Next(0, 50));
             
                banks.Add(Bank.QuantityBanks,
                    new Bank(title, deposit, procent, type, filials, atm, period));

                label9.Text = "Количество созданных банков: " + banks.Count;
                ChangeComboBox1();

                banksArray[i] = new Bank(title, deposit, procent, type, filials, atm, period);
            }
        }
        private bool boolConvertor(int val)
        {
            return val == 1 ? true : false;
        }
        private string stringConvertor(int val)
        {
            return val == 1 ? "Государственный" : "Частный";
        }
        private void show_random_results_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem();
            ListViewItem lv2 = new ListViewItem();
            lv1.Text = "Последовательная";
            lv2.Text = "Случайная";
            if (banks.Count == 0)
            {
                MessageBox.Show("Банков нет!");
                lv1.SubItems.Add("");
                lv1.SubItems.Add("");
                lv2.SubItems.Add("");
                lv2.SubItems.Add("");
                listView1.Items[0] = lv1;
                listView1.Items[1] = lv2;
                return;
            }
            Random rnd = new Random(DateTime.Now.Millisecond);
            // ----------------Последовательная выборка--------------------
            Stopwatch allTimeArray1 = new Stopwatch(), allTimeDictionary1 = new Stopwatch();
            Bank temp;
            allTimeArray1.Start();
            for (int i = 0; i < N; i++)
                temp = banksArray[i];
            allTimeArray1.Stop();
            allTimeDictionary1.Start();
            foreach (var pair in banks)
                temp = pair.Value;
            allTimeDictionary1.Stop();
            // -------------------Случайная выборка-----------------
            Stopwatch allTimeArray2 = new Stopwatch(), allTimeDictionary2 = new Stopwatch();
            allTimeArray2.Start();
            for (int i = 0; i < N; i++)
                temp = banksArray[rnd.Next(0, N)];
            allTimeArray2.Stop();
            allTimeDictionary2.Start();
            foreach (var pair in banks)
                temp = pair.Value;
            allTimeDictionary2.Stop();
            // ------------Заполнение таблицы-------------
            lv1.SubItems.Add(allTimeArray1.ElapsedTicks.ToString());
            lv1.SubItems.Add(allTimeDictionary1.ElapsedTicks.ToString());
            lv2.SubItems.Add(allTimeArray2.ElapsedTicks.ToString());
            lv2.SubItems.Add(allTimeDictionary2.ElapsedTicks.ToString());
            listView1.Items[0] = lv1;
            listView1.Items[1] = lv2;
        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e){}
        private void panel2_Paint(object sender, PaintEventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}
        private void panel1_Paint(object sender, PaintEventArgs e){}
        private void BankProcent_TextChanged(object sender, EventArgs e){}
    }
}
