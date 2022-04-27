using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba4
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Individuals> individuals = new Dictionary<int, Individuals>();
        private Dictionary<int, Organization> organizations = new Dictionary<int, Organization>();
        const int N = 3;
        public Form1()
        {
            InitializeComponent();

            // Заполнение данных
           organizations.Add(organizations.Count, new Organization("Пенза", 345, 89042661675, 
               "OОО Ремстрой", 123761789212,  45,  true,  false));
            ChangeComboBox1();
           organizations.Add(organizations.Count, new Organization("Москва", 654, 89656787551,
                "OАО Вектор", 100063286298, 45, false, false));
            ChangeComboBox1();
           organizations.Add(organizations.Count, new Organization("Казань", 123, 89603259852,
                "ТЦ СИТИ", 193985689256, 45, true, true));
            ChangeComboBox1();

            individuals.Add(individuals.Count, new Individuals("Саратов", 513, 89762555671,
               "Александра", "Михеева", "Дмитриевна" , 561576, 3845, true));
            ChangeComboBox2();
            individuals.Add(individuals.Count, new Individuals("Ульяновск", 145, 89096763051,
                 "Виктор", "Кузнецов" , "Александрович", 571876, 3378, false));
            ChangeComboBox2();
            individuals.Add(individuals.Count, new Individuals("Казань", 678, 89872251002,
                 "Евгения", "Шишкина", "Романовна", 481376, 4345, true));
            ChangeComboBox2();

        }

     
        private void ChangeComboBox1()
        {
            if (organizations.Count == 0)
                MessageBox.Show("Организаций не существует!");
            else
            {
                int selected = comboBox1.SelectedIndex;
                comboBox1.Items.Clear();
                foreach (var pair in organizations)
                    comboBox1.Items.Add(pair.Value.Title);
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(selected);
            }
        }

        private void ChangeComboBox2()
        {
            if (individuals.Count == 0)
                MessageBox.Show("Организаций не существует!");
            else
            {
                int selected2 = comboBox2.SelectedIndex;
                comboBox2.Items.Clear();
                foreach (var pair in individuals)
                    comboBox2.Items.Add(pair.Value.Surname);
                comboBox1.SelectedIndex = comboBox2.Items.IndexOf(selected2);
            }
        }

        private bool isEmpty(TextBox item)
        {
            return string.IsNullOrEmpty(item.Text);
        }
        private bool isEmpty1()
        {
            return
                isEmpty(adress1) ||
                isEmpty(phoneNumber1) ||
                isEmpty(inn) ||
                isEmpty(bankAccount1) ||
                isEmpty(title) ||
                isEmpty(countWriters);
        }

        private bool isEmpty2()
        {
            return
                isEmpty(adress2) ||
                isEmpty(phoneNumber2) ||
                isEmpty(passportNumber) ||
                isEmpty(passportSeria);
        }

        private void Change1_Click(object sender, EventArgs e)
        {

            if (isEmpty1())
            {
                MessageBox.Show("Выберите объект класса!");
                return;
            }

            ulong phoneNumbers = Convert.ToUInt64(Math.Pow(10, 10));
            ulong phone = Convert.ToUInt64(Math.Pow(10, 10));
            ulong inns = Convert.ToUInt64(Math.Pow(10, 11));
            ulong INN = Convert.ToUInt64(Math.Pow(10, 11));
            uint countWriter = 0;


            var result =
                ulong.TryParse(phoneNumber1.Text, out phoneNumbers) &&
                ulong.TryParse(inn.Text, out inns) &&
                uint.TryParse(countWriters.Text, out countWriter) &&
                countWriter > 0 && inns > INN && phoneNumbers > phone;


            phoneNumber1.BackColor = Color.White;
            inn.BackColor = Color.White;
            countWriters.BackColor = Color.White;


            if (!result)
            {
                MessageBox.Show("Некорректные данные");
                if (!ulong.TryParse(phoneNumber1.Text, out phoneNumbers) || (phoneNumbers <= phone))
                {
                    phoneNumber1.BackColor = Color.FromArgb(250, 128, 114);
                }

                if (!ulong.TryParse(inn.Text, out inns) || (inns <= INN))
                {
                    inn.BackColor = Color.FromArgb(250, 128, 114);
                }

                if (!uint.TryParse(countWriters.Text, out countWriter) || (countWriter <= 0))
                {
                    countWriters.BackColor = Color.FromArgb(250, 128, 114);
                }
                return;
            }

            int selected = comboBox1.SelectedIndex;
            if (selected == -1)
            {
                MessageBox.Show("Выберите объект для изменения!");
                return;
            }

            organizations[selected].Title = title.Text;
            organizations[selected].Adress = adress1.Text;
            organizations[selected].BankAccount = Convert.ToUInt64(bankAccount1.Text);
            organizations[selected].PhoneNumber = Convert.ToUInt64(phoneNumber1.Text);
            organizations[selected].INN = Convert.ToUInt64(inn.Text);
            organizations[selected].СountWriters = Convert.ToUInt32(countWriters.Text);
            organizations[selected].Kpp = kppYes.Checked;
            organizations[selected].Filials = filialsYes.Checked;
            ChangeComboBox1();
            show1(sender, e);
        }

        private void show1(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            if (selected == -1) return;
            title.Text = organizations[selected].Title;
            adress1.Text = organizations[selected].Adress;
            bankAccount1.Text = organizations[selected].BankAccount.ToString();
            phoneNumber1.Text = organizations[selected].PhoneNumber.ToString();
            inn.Text = organizations[selected].INN.ToString();
            countWriters.Text = organizations[selected].СountWriters.ToString();
            kppYes.Checked = organizations[selected].Kpp;
            filialsYes.Checked = organizations[selected].Filials;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            show1(sender, e);
        }

        private void Change2_Click(object sender, EventArgs e)
        {
            if (isEmpty2())
            {
                MessageBox.Show("Выберите объект класса!");
                return;
            }

            ulong phoneNumbers = Convert.ToUInt64(Math.Pow(10, 10));
            ulong phone = Convert.ToUInt64(Math.Pow(10, 10));
            uint passportnum = Convert.ToUInt32(Math.Pow(10, 5));
            uint passportnums = Convert.ToUInt32(Math.Pow(10, 5));
            uint passportser = Convert.ToUInt32(Math.Pow(10, 3));
            uint passportsers = Convert.ToUInt32(Math.Pow(10, 3));


            var result =
                ulong.TryParse(phoneNumber2.Text, out phoneNumbers) &&
                uint.TryParse(passportNumber.Text, out passportnum) &&
                uint.TryParse(passportSeria.Text, out passportser) &&
                passportser >= passportsers && passportnum >= passportnums && phoneNumbers > phone;


            phoneNumber2.BackColor = Color.White;
            passportSeria.BackColor = Color.White;
            passportNumber.BackColor = Color.White;


            if (!result)
            {
                MessageBox.Show("Некорректные данные");
                if (!ulong.TryParse(phoneNumber2.Text, out phoneNumbers) || (phoneNumbers <= phone))
                {
                    phoneNumber2.BackColor = Color.FromArgb(250, 128, 114);
                }

                if (!uint.TryParse(inn.Text, out passportnum) || (passportnum <= passportnums))
                {
                    passportNumber.BackColor = Color.FromArgb(250, 128, 114);
                }

                if (!uint.TryParse(countWriters.Text, out passportser) || (passportser < passportsers))
                {
                    passportSeria.BackColor = Color.FromArgb(250, 128, 114);
                }
                return;
            }

            int selected2 = comboBox2.SelectedIndex;
            if (selected2 == -1) return;
            individuals[selected2].Adress = adress2.Text;
            individuals[selected2].BankAccount = Convert.ToUInt64(bankAccount2.Text);
            individuals[selected2].PhoneNumber = Convert.ToUInt64(phoneNumber2.Text);
            individuals[selected2].Name = name.Text;
            individuals[selected2].Surname = surname.Text;
            individuals[selected2].MiddleName = middleName.Text;
            individuals[selected2].PassportNumber = Convert.ToUInt32(passportNumber.Text);
            individuals[selected2].PassportSeria = Convert.ToUInt32(passportSeria.Text);
            individuals[selected2].BiometricData = biometricYes.Checked;
            ChangeComboBox2();
            show2(sender, e);
        }

        private void show2(object sender, EventArgs e)
        {

            int selected2 = comboBox2.SelectedIndex;
            if (selected2 == -1) return;
            adress2.Text = individuals[selected2].Adress;
            bankAccount2.Text = individuals[selected2].BankAccount.ToString();
            phoneNumber2.Text = individuals[selected2].PhoneNumber.ToString();
            name.Text = individuals[selected2].Name;
            surname.Text = individuals[selected2].Surname;
            middleName.Text = individuals[selected2].MiddleName;
            passportNumber.Text = individuals[selected2].PassportNumber.ToString();
            passportSeria.Text = individuals[selected2].PassportSeria.ToString();
            biometricYes.Checked = individuals[selected2].BiometricData;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Type typeCl = typeof(Clients);
            treeView1.Nodes.Add(typeCl.ToString());
            Type typeOrg = typeof(Organization);
            treeView1.Nodes[0].Nodes.Add(typeOrg.ToString());
            Type typeInd = typeof(Individuals);
            treeView1.Nodes[0].Nodes.Add(typeInd.ToString());
            foreach (FieldInfo field in typeCl.GetFields(
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
            {
                string modificator = "";
                if (field.IsPublic)
                    modificator += "public ";
                else if (field.IsPrivate)
                    modificator += "private ";
                else if (field.IsAssembly)
                    modificator += "internal ";
                else if (field.IsFamily)
                    modificator += "protected ";
                else if (field.IsFamilyAndAssembly)
                    modificator += "private protected ";
                else if (field.IsFamilyOrAssembly)
                    modificator += "protected internal ";
                if (field.IsStatic) modificator += "static ";
                treeView1.Nodes[0].Nodes.Add($"{modificator}{field.FieldType.Name} {field.Name}");
            }
            foreach (FieldInfo field in typeOrg.GetFields(
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
            {
                string modificator = "";
                if (field.IsPublic)
                    modificator += "public ";
                else if (field.IsPrivate)
                    modificator += "private ";
                else if (field.IsAssembly)
                    modificator += "internal ";
                else if (field.IsFamily)
                    modificator += "protected ";
                else if (field.IsFamilyAndAssembly)
                    modificator += "private protected ";
                else if (field.IsFamilyOrAssembly)
                    modificator += "protected internal ";
                if (field.IsStatic) modificator += "static ";
                treeView1.Nodes[0].Nodes[0].Nodes.Add($"{modificator}{field.FieldType.Name} {field.Name}");
            }
            foreach (FieldInfo field in typeInd.GetFields(
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
            {
                string modificator = "";
                if (field.IsPublic)
                    modificator += "public ";
                else if (field.IsPrivate)
                    modificator += "private ";
                else if (field.IsAssembly)
                    modificator += "internal ";
                else if (field.IsFamily)
                    modificator += "protected ";
                else if (field.IsFamilyAndAssembly)
                    modificator += "private protected ";
                else if (field.IsFamilyOrAssembly)
                    modificator += "protected internal ";
                if (field.IsStatic) modificator += "static ";
                treeView1.Nodes[0].Nodes[1].Nodes.Add($"{modificator}{field.FieldType.Name} {field.Name}");
            }
            foreach (MethodInfo method in typeOrg.GetMethods())
            {
                treeView1.Nodes[0].Nodes[0].Nodes.Add($"{method.ReturnType.Name} {method.Name} ()");
            }
            foreach (MethodInfo method in typeInd.GetMethods())
            {
                treeView1.Nodes[0].Nodes[1].Nodes.Add($"{method.ReturnType.Name} {method.Name} ()");
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            show2(sender, e);
        }


        private void tree_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void passportSeria_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
