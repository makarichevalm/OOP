
namespace laba4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tree = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.changeInfo = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.middleName = new System.Windows.Forms.MaskedTextBox();
            this.surname = new System.Windows.Forms.MaskedTextBox();
            this.name = new System.Windows.Forms.MaskedTextBox();
            this.Change2 = new System.Windows.Forms.Button();
            this.passportSeria = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.passportNumber = new System.Windows.Forms.TextBox();
            this.biometricYes = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bankAccount2 = new System.Windows.Forms.TextBox();
            this.phoneNumber2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.adress2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filialsYes = new System.Windows.Forms.CheckBox();
            this.kppYes = new System.Windows.Forms.CheckBox();
            this.countWriters = new System.Windows.Forms.TextBox();
            this.inn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bankAccount1 = new System.Windows.Forms.TextBox();
            this.phoneNumber1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adress1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Change1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tree.SuspendLayout();
            this.changeInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tree);
            this.tabControl1.Controls.Add(this.changeInfo);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1110, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tree
            // 
            this.tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.tree.Controls.Add(this.treeView1);
            this.tree.Location = new System.Drawing.Point(4, 29);
            this.tree.Name = "tree";
            this.tree.Padding = new System.Windows.Forms.Padding(3);
            this.tree.Size = new System.Drawing.Size(1102, 634);
            this.tree.TabIndex = 0;
            this.tree.Text = "Дерево";
            this.tree.Click += new System.EventHandler(this.tree_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(24, 30);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1047, 577);
            this.treeView1.TabIndex = 0;
            // 
            // changeInfo
            // 
            this.changeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.changeInfo.Controls.Add(this.label2);
            this.changeInfo.Controls.Add(this.label1);
            this.changeInfo.Controls.Add(this.panel2);
            this.changeInfo.Controls.Add(this.panel1);
            this.changeInfo.Location = new System.Drawing.Point(4, 29);
            this.changeInfo.Name = "changeInfo";
            this.changeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.changeInfo.Size = new System.Drawing.Size(1102, 634);
            this.changeInfo.TabIndex = 1;
            this.changeInfo.Text = "Информация об объектах";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(609, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Изменение объектов класса Физичесикие лица";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Изменение объектов класса Организации ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.middleName);
            this.panel2.Controls.Add(this.surname);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.Change2);
            this.panel2.Controls.Add(this.passportSeria);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.passportNumber);
            this.panel2.Controls.Add(this.biometricYes);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.bankAccount2);
            this.panel2.Controls.Add(this.phoneNumber2);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.adress2);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Location = new System.Drawing.Point(565, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 569);
            this.panel2.TabIndex = 1;
            // 
            // middleName
            // 
            this.middleName.HidePromptOnLeave = true;
            this.middleName.Location = new System.Drawing.Point(316, 363);
            this.middleName.Mask = "L?????????????????????????";
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(176, 26);
            this.middleName.TabIndex = 43;
            this.middleName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // surname
            // 
            this.surname.HidePromptOnLeave = true;
            this.surname.Location = new System.Drawing.Point(316, 321);
            this.surname.Mask = "L?????????????????????????";
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(176, 26);
            this.surname.TabIndex = 42;
            this.surname.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // name
            // 
            this.name.HidePromptOnLeave = true;
            this.name.Location = new System.Drawing.Point(316, 279);
            this.name.Mask = "L?????????????????????????";
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(176, 26);
            this.name.TabIndex = 41;
            this.name.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // Change2
            // 
            this.Change2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Change2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Change2.Location = new System.Drawing.Point(315, 69);
            this.Change2.Name = "Change2";
            this.Change2.Size = new System.Drawing.Size(172, 31);
            this.Change2.TabIndex = 40;
            this.Change2.Text = "Изменить";
            this.Change2.UseVisualStyleBackColor = false;
            this.Change2.Click += new System.EventHandler(this.Change2_Click);
            // 
            // passportSeria
            // 
            this.passportSeria.Location = new System.Drawing.Point(316, 405);
            this.passportSeria.MaxLength = 4;
            this.passportSeria.Name = "passportSeria";
            this.passportSeria.Size = new System.Drawing.Size(175, 26);
            this.passportSeria.TabIndex = 39;
            this.passportSeria.TextChanged += new System.EventHandler(this.passportSeria_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(33, 411);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 20);
            this.label22.TabIndex = 38;
            this.label22.Text = "Серия паспорта";
            // 
            // passportNumber
            // 
            this.passportNumber.Location = new System.Drawing.Point(316, 444);
            this.passportNumber.MaxLength = 6;
            this.passportNumber.Name = "passportNumber";
            this.passportNumber.Size = new System.Drawing.Size(175, 26);
            this.passportNumber.TabIndex = 37;
            // 
            // biometricYes
            // 
            this.biometricYes.AutoSize = true;
            this.biometricYes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.biometricYes.Location = new System.Drawing.Point(316, 488);
            this.biometricYes.Name = "biometricYes";
            this.biometricYes.Size = new System.Drawing.Size(72, 24);
            this.biometricYes.TabIndex = 36;
            this.biometricYes.Text = "Есть";
            this.biometricYes.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(33, 488);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Наличие биометрии";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(33, 450);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Номер паспорта";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(33, 369);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Отчество";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(33, 327);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Фамилия";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(33, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 20);
            this.label18.TabIndex = 27;
            this.label18.Text = "Имя";
            // 
            // bankAccount2
            // 
            this.bankAccount2.Location = new System.Drawing.Point(316, 202);
            this.bankAccount2.Name = "bankAccount2";
            this.bankAccount2.Size = new System.Drawing.Size(175, 26);
            this.bankAccount2.TabIndex = 26;
            // 
            // phoneNumber2
            // 
            this.phoneNumber2.Location = new System.Drawing.Point(316, 241);
            this.phoneNumber2.Name = "phoneNumber2";
            this.phoneNumber2.Size = new System.Drawing.Size(175, 26);
            this.phoneNumber2.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(33, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 20);
            this.label19.TabIndex = 24;
            this.label19.Text = "Номер счета";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(33, 244);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "Телефон";
            // 
            // adress2
            // 
            this.adress2.Location = new System.Drawing.Point(316, 162);
            this.adress2.Name = "adress2";
            this.adress2.Size = new System.Drawing.Size(175, 26);
            this.adress2.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(33, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 20);
            this.label21.TabIndex = 21;
            this.label21.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(33, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выберите объект:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(37, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 28);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.filialsYes);
            this.panel1.Controls.Add(this.kppYes);
            this.panel1.Controls.Add(this.countWriters);
            this.panel1.Controls.Add(this.inn);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bankAccount1);
            this.panel1.Controls.Add(this.phoneNumber1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.adress1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Change1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(22, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 569);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // filialsYes
            // 
            this.filialsYes.AutoSize = true;
            this.filialsYes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filialsYes.Location = new System.Drawing.Point(306, 450);
            this.filialsYes.Name = "filialsYes";
            this.filialsYes.Size = new System.Drawing.Size(72, 24);
            this.filialsYes.TabIndex = 20;
            this.filialsYes.Text = "Есть";
            this.filialsYes.UseVisualStyleBackColor = true;
            // 
            // kppYes
            // 
            this.kppYes.AutoSize = true;
            this.kppYes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kppYes.Location = new System.Drawing.Point(306, 406);
            this.kppYes.Name = "kppYes";
            this.kppYes.Size = new System.Drawing.Size(72, 24);
            this.kppYes.TabIndex = 19;
            this.kppYes.Text = "Есть";
            this.kppYes.UseVisualStyleBackColor = true;
            // 
            // countWriters
            // 
            this.countWriters.Location = new System.Drawing.Point(306, 363);
            this.countWriters.Name = "countWriters";
            this.countWriters.Size = new System.Drawing.Size(175, 26);
            this.countWriters.TabIndex = 18;
            // 
            // inn
            // 
            this.inn.Location = new System.Drawing.Point(306, 321);
            this.inn.MaxLength = 12;
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(175, 26);
            this.inn.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(23, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Наличие филиалов";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(23, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Наличие КПП";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(23, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Кол-во лиц с правом подписи";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(23, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "ИНН";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(306, 279);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(175, 26);
            this.title.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(23, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Наименование организации";
            // 
            // bankAccount1
            // 
            this.bankAccount1.Location = new System.Drawing.Point(306, 202);
            this.bankAccount1.Name = "bankAccount1";
            this.bankAccount1.Size = new System.Drawing.Size(175, 26);
            this.bankAccount1.TabIndex = 10;
            // 
            // phoneNumber1
            // 
            this.phoneNumber1.Location = new System.Drawing.Point(306, 241);
            this.phoneNumber1.MaxLength = 11;
            this.phoneNumber1.Name = "phoneNumber1";
            this.phoneNumber1.Size = new System.Drawing.Size(175, 26);
            this.phoneNumber1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(23, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Номер счета";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(23, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Телефон";
            // 
            // adress1
            // 
            this.adress1.Location = new System.Drawing.Point(306, 162);
            this.adress1.MaxLength = 1000;
            this.adress1.Name = "adress1";
            this.adress1.Size = new System.Drawing.Size(175, 26);
            this.adress1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(23, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выберите объект:";
            // 
            // Change1
            // 
            this.Change1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Change1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Change1.Location = new System.Drawing.Point(309, 67);
            this.Change1.Name = "Change1";
            this.Change1.Size = new System.Drawing.Size(172, 31);
            this.Change1.TabIndex = 1;
            this.Change1.Text = "Изменить";
            this.Change1.UseVisualStyleBackColor = false;
            this.Change1.Click += new System.EventHandler(this.Change1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1135, 741);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты банка";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tree.ResumeLayout(false);
            this.changeInfo.ResumeLayout(false);
            this.changeInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tree;
        private System.Windows.Forms.TabPage changeInfo;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Change1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bankAccount1;
        private System.Windows.Forms.TextBox phoneNumber1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adress1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox biometricYes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox bankAccount2;
        private System.Windows.Forms.TextBox phoneNumber2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox adress2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox filialsYes;
        private System.Windows.Forms.CheckBox kppYes;
        private System.Windows.Forms.TextBox countWriters;
        private System.Windows.Forms.TextBox inn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox passportSeria;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox passportNumber;
        private System.Windows.Forms.Button Change2;
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.MaskedTextBox middleName;
        private System.Windows.Forms.MaskedTextBox surname;
    }
}

