
namespace laba3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BankTitle = new System.Windows.Forms.TextBox();
            this.BankDeposits = new System.Windows.Forms.TextBox();
            this.BankProcent = new System.Windows.Forms.TextBox();
            this.BankType = new System.Windows.Forms.TextBox();
            this.BankCredit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BankAtmYes = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BankFilNo = new System.Windows.Forms.CheckBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.show_random_results = new System.Windows.Forms.Button();
            this.Generate_Button = new System.Windows.Forms.Button();
            this.button_deleteAll = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_show = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dictionary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Array = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = " Наименование банка";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Число вкладов";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Размер процентной ставки";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "Тип банка";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 26);
            this.label5.TabIndex = 53;
            this.label5.Text = "Срок кредита";
            // 
            // BankTitle
            // 
            this.BankTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankTitle.Location = new System.Drawing.Point(405, 42);
            this.BankTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankTitle.Name = "BankTitle";
            this.BankTitle.Size = new System.Drawing.Size(245, 32);
            this.BankTitle.TabIndex = 54;
            // 
            // BankDeposits
            // 
            this.BankDeposits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankDeposits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankDeposits.Location = new System.Drawing.Point(405, 98);
            this.BankDeposits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankDeposits.Name = "BankDeposits";
            this.BankDeposits.Size = new System.Drawing.Size(245, 32);
            this.BankDeposits.TabIndex = 55;
            // 
            // BankProcent
            // 
            this.BankProcent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankProcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankProcent.Location = new System.Drawing.Point(405, 147);
            this.BankProcent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankProcent.Name = "BankProcent";
            this.BankProcent.Size = new System.Drawing.Size(245, 32);
            this.BankProcent.TabIndex = 56;
            this.BankProcent.TextChanged += new System.EventHandler(this.BankProcent_TextChanged);
            // 
            // BankType
            // 
            this.BankType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankType.Location = new System.Drawing.Point(405, 206);
            this.BankType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankType.Name = "BankType";
            this.BankType.Size = new System.Drawing.Size(245, 32);
            this.BankType.TabIndex = 57;
            // 
            // BankCredit
            // 
            this.BankCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankCredit.Location = new System.Drawing.Point(405, 261);
            this.BankCredit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankCredit.Name = "BankCredit";
            this.BankCredit.Size = new System.Drawing.Size(245, 32);
            this.BankCredit.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 26);
            this.label7.TabIndex = 59;
            this.label7.Text = "Наличие банкоматов";
            // 
            // BankAtmYes
            // 
            this.BankAtmYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankAtmYes.AutoSize = true;
            this.BankAtmYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankAtmYes.Location = new System.Drawing.Point(405, 317);
            this.BankAtmYes.Name = "BankAtmYes";
            this.BankAtmYes.Size = new System.Drawing.Size(86, 30);
            this.BankAtmYes.TabIndex = 72;
            this.BankAtmYes.Text = "Есть";
            this.BankAtmYes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 26);
            this.label6.TabIndex = 73;
            this.label6.Text = "Наличие филиалов";
            // 
            // BankFilNo
            // 
            this.BankFilNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankFilNo.AutoSize = true;
            this.BankFilNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankFilNo.Location = new System.Drawing.Point(405, 372);
            this.BankFilNo.Name = "BankFilNo";
            this.BankFilNo.Size = new System.Drawing.Size(86, 30);
            this.BankFilNo.TabIndex = 74;
            this.BankFilNo.Text = "Есть";
            this.BankFilNo.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_add.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(17, 476);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(246, 51);
            this.button_add.TabIndex = 75;
            this.button_add.Text = "Добавить банк";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 548);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 26);
            this.label9.TabIndex = 76;
            this.label9.Text = "Количество созданных банков: 0";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.show_random_results);
            this.panel1.Controls.Add(this.Generate_Button);
            this.panel1.Controls.Add(this.button_deleteAll);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button_show);
            this.panel1.Controls.Add(this.button_change);
            this.panel1.Location = new System.Drawing.Point(741, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 322);
            this.panel1.TabIndex = 77;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // show_random_results
            // 
            this.show_random_results.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.show_random_results.BackColor = System.Drawing.Color.PaleTurquoise;
            this.show_random_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_random_results.Location = new System.Drawing.Point(224, 230);
            this.show_random_results.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.show_random_results.MinimumSize = new System.Drawing.Size(196, 42);
            this.show_random_results.Name = "show_random_results";
            this.show_random_results.Size = new System.Drawing.Size(196, 82);
            this.show_random_results.TabIndex = 82;
            this.show_random_results.Text = "Показать результаты";
            this.show_random_results.UseVisualStyleBackColor = false;
            this.show_random_results.Click += new System.EventHandler(this.show_random_results_Click);
            // 
            // Generate_Button
            // 
            this.Generate_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Generate_Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Generate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate_Button.Location = new System.Drawing.Point(20, 230);
            this.Generate_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Generate_Button.MinimumSize = new System.Drawing.Size(196, 42);
            this.Generate_Button.Name = "Generate_Button";
            this.Generate_Button.Size = new System.Drawing.Size(196, 83);
            this.Generate_Button.TabIndex = 81;
            this.Generate_Button.Text = "Генерация элементов";
            this.Generate_Button.UseVisualStyleBackColor = false;
            this.Generate_Button.Click += new System.EventHandler(this.Generate_Button_Click);
            // 
            // button_deleteAll
            // 
            this.button_deleteAll.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_deleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteAll.Location = new System.Drawing.Point(224, 179);
            this.button_deleteAll.Name = "button_deleteAll";
            this.button_deleteAll.Size = new System.Drawing.Size(196, 43);
            this.button_deleteAll.TabIndex = 80;
            this.button_deleteAll.Text = "Очистить все";
            this.button_deleteAll.UseVisualStyleBackColor = false;
            this.button_deleteAll.Click += new System.EventHandler(this.button_deleteAll_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(20, 179);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(196, 41);
            this.button_delete.TabIndex = 71;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(124, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 26);
            this.label10.TabIndex = 69;
            this.label10.Text = "Выберите банк:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownHeight = 65;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(93, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 37);
            this.comboBox1.TabIndex = 57;
            // 
            // button_show
            // 
            this.button_show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_show.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_show.Location = new System.Drawing.Point(20, 124);
            this.button_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_show.MinimumSize = new System.Drawing.Size(196, 42);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(196, 42);
            this.button_show.TabIndex = 20;
            this.button_show.Text = "Показать";
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.button_show_Click_1);
            // 
            // button_change
            // 
            this.button_change.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_change.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_change.Location = new System.Drawing.Point(225, 124);
            this.button_change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(196, 44);
            this.button_change.TabIndex = 27;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click_1);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(814, 517);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label12.Size = new System.Drawing.Size(20, 22);
            this.label12.TabIndex = 78;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.BankFilNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BankTitle);
            this.panel2.Controls.Add(this.BankDeposits);
            this.panel2.Controls.Add(this.BankProcent);
            this.panel2.Controls.Add(this.BankType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BankCredit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BankAtmYes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(42, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 601);
            this.panel2.TabIndex = 79;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Dictionary,
            this.Array});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 17);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.listView1.MaximumSize = new System.Drawing.Size(589, 400);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(459, 101);
            this.listView1.TabIndex = 80;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Выборка";
            this.columnHeader1.Width = 130;
            // 
            // Dictionary
            // 
            this.Dictionary.Text = "Dictionary";
            this.Dictionary.Width = 100;
            // 
            // Array
            // 
            this.Array.Text = "Array";
            this.Array.Width = 100;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Location = new System.Drawing.Point(750, 39);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.panel3.Size = new System.Drawing.Size(494, 128);
            this.panel3.TabIndex = 81;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1231, 709);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 30, 20, 20);
            this.Text = "Банк";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BankTitle;
        private System.Windows.Forms.TextBox BankDeposits;
        private System.Windows.Forms.TextBox BankProcent;
        private System.Windows.Forms.TextBox BankType;
        private System.Windows.Forms.TextBox BankCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox BankAtmYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox BankFilNo;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_deleteAll;
        private System.Windows.Forms.Button Generate_Button;
        private System.Windows.Forms.Button show_random_results;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Dictionary;
        private System.Windows.Forms.ColumnHeader Array;
        private System.Windows.Forms.Panel panel3;
    }
}

