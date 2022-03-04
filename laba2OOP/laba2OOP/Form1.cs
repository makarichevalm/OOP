using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace laba2OOP
{
    public partial class Form1 : Form
    {
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
                isEmpty(BankCredit)||
                !(BankAtmNo.Checked || BankAtmYes.Checked);
        }

        private Dictionary<int, Bank> banks = new Dictionary<int, Bank>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            uint deposits;
            uint period = 1;
            double procent = 0;


            var result =
                uint.TryParse(BankDeposits.Text, out deposits) &&
                double.TryParse(BankProcent.Text, out procent) &&
                uint.TryParse(BankCredit.Text, out period) &&
                procent > 0;

            if (!result)
            {
                MessageBox.Show("Некорректные данные");
                return;
            }

            
            int selected = comboBox1.SelectedIndex;
            if (selected == -1) return;

            /*foreach (var pair in banks)
            {
                if (pair.Value.Title == BankTitle.Text)
                {
                    MessageBox.Show("Банк с таким названием уже существует!");
                    return;
                }
            }*/

            banks[selected].Title = BankTitle.Text;
            banks[selected].Type = BankType.Text;
            banks[selected].NumberDeposits = deposits;
            banks[selected].ProcentSize = procent;
            banks[selected].CreditPeriod = period;
            banks[selected].Filials = BankFilNo.Checked;
            banks[selected].Atm = BankAtmYes.Checked;
            label12.Text = banks[selected].ToString();
            ChangeComboBox1();

        }

        private void button_show_Click(object sender, EventArgs e)
        {

            uint deposits;
            uint period = 1;
            double procent = 0;


            var result =
                uint.TryParse(BankDeposits.Text, out deposits) &&
                double.TryParse(BankProcent.Text, out procent) &&
                uint.TryParse(BankCredit.Text, out period) &&
                procent > 0;

            int selected = comboBox1.SelectedIndex;
            if (selected == -1) return;
            BankTitle.Text = banks[selected].Title;
            BankType.Text = banks[selected].Type;
            BankDeposits.Text = banks[selected].NumberDeposits.ToString();
            BankProcent.Text = banks[selected].ProcentSize.ToString();
            BankCredit.Text = banks[selected].CreditPeriod.ToString();
            BankFilNo.Checked = banks[selected].Filials;
            BankAtmYes.Checked = banks[selected].Atm;
            //BankAtmNo.Checked = banks[selected].Atm;
            label12.Text = banks[selected].ToString();
        }


        private void button_add_Click_1(object sender, EventArgs e)
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

            if (!result)
            {
                MessageBox.Show("Некорректные данные");
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
                if (pair.Value.Title == title)
                {
                    MessageBox.Show("Банк с таким названием уже существует!");
                    return;
                }
            }
            
            banks.Add(Bank.QuantityBanks, new Bank(title, deposit, procent, type, filials, atm, period));
            ChangeComboBox1();
            label9.Text = "Добавлено банков: " + Bank.QuantityBanks;

            
        }


        private void ChangeComboBox1()
        {
            if (banks.Count == 0)
                label2.Text = "";
            else
            {
                int selected = comboBox1.SelectedIndex;
                comboBox1.Items.Clear();
                foreach (var pair in banks)
                    comboBox1.Items.Add(pair.Value.Title);
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(selected);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            label2.Text = banks[selected].ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BankAtmNo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
