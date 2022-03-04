
namespace lab_work2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Display = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BankAtmNo = new System.Windows.Forms.RadioButton();
            this.BankAtmYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BankProcent = new System.Windows.Forms.TextBox();
            this.BankDeposits = new System.Windows.Forms.TextBox();
            this.BankTitle = new System.Windows.Forms.TextBox();
            this.button_change = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BankType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BankCredit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BankFilNo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Location = new System.Drawing.Point(369, 162);
            this.Display.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(0, 20);
            this.Display.TabIndex = 47;
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(722, 178);
            this.button_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(196, 33);
            this.button_show.TabIndex = 46;
            this.button_show.Text = "Показать";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Наличие банкоматов";
            // 
            // BankAtmNo
            // 
            this.BankAtmNo.AutoSize = true;
            this.BankAtmNo.Location = new System.Drawing.Point(251, 281);
            this.BankAtmNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankAtmNo.Name = "BankAtmNo";
            this.BankAtmNo.Size = new System.Drawing.Size(64, 24);
            this.BankAtmNo.TabIndex = 42;
            this.BankAtmNo.TabStop = true;
            this.BankAtmNo.Text = "Нет";
            this.BankAtmNo.UseVisualStyleBackColor = true;
            // 
            // BankAtmYes
            // 
            this.BankAtmYes.AutoSize = true;
            this.BankAtmYes.Location = new System.Drawing.Point(112, 279);
            this.BankAtmYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankAtmYes.Name = "BankAtmYes";
            this.BankAtmYes.Size = new System.Drawing.Size(71, 24);
            this.BankAtmYes.TabIndex = 41;
            this.BankAtmYes.TabStop = true;
            this.BankAtmYes.Text = "Есть";
            this.BankAtmYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Число вкладов";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = " Наименование банка";
            // 
            // BankProcent
            // 
            this.BankProcent.Location = new System.Drawing.Point(289, 134);
            this.BankProcent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankProcent.Name = "BankProcent";
            this.BankProcent.Size = new System.Drawing.Size(247, 26);
            this.BankProcent.TabIndex = 33;
            // 
            // BankDeposits
            // 
            this.BankDeposits.Location = new System.Drawing.Point(289, 78);
            this.BankDeposits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankDeposits.Name = "BankDeposits";
            this.BankDeposits.Size = new System.Drawing.Size(247, 26);
            this.BankDeposits.TabIndex = 31;
            // 
            // BankTitle
            // 
            this.BankTitle.Location = new System.Drawing.Point(289, 29);
            this.BankTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankTitle.Name = "BankTitle";
            this.BankTitle.Size = new System.Drawing.Size(247, 26);
            this.BankTitle.TabIndex = 29;
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(722, 231);
            this.button_change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(196, 35);
            this.button_change.TabIndex = 27;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(57, 507);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(244, 35);
            this.button_add.TabIndex = 25;
            this.button_add.Text = "Добавить банк";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Размер процентной ставки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Тип банка";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BankType
            // 
            this.BankType.Location = new System.Drawing.Point(289, 188);
            this.BankType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankType.Name = "BankType";
            this.BankType.Size = new System.Drawing.Size(247, 26);
            this.BankType.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Срок кредита";
            // 
            // BankCredit
            // 
            this.BankCredit.Location = new System.Drawing.Point(289, 347);
            this.BankCredit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankCredit.Name = "BankCredit";
            this.BankCredit.Size = new System.Drawing.Size(247, 26);
            this.BankCredit.TabIndex = 51;
            this.BankCredit.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Наличие филиалов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(843, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 56;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(722, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 28);
            this.comboBox1.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(581, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 589);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Количество банков: 0";
            // 
            // BankFilNo
            // 
            this.BankFilNo.AutoSize = true;
            this.BankFilNo.Location = new System.Drawing.Point(229, 416);
            this.BankFilNo.Name = "BankFilNo";
            this.BankFilNo.Size = new System.Drawing.Size(72, 24);
            this.BankFilNo.TabIndex = 68;
            this.BankFilNo.Text = "Есть";
            this.BankFilNo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1015, 637);
            this.Controls.Add(this.BankFilNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BankCredit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BankType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BankAtmNo);
            this.Controls.Add(this.BankAtmYes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BankProcent);
            this.Controls.Add(this.BankDeposits);
            this.Controls.Add(this.BankTitle);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банк";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton BankAtmNo;
        private System.Windows.Forms.RadioButton BankAtmYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BankProcent;
        private System.Windows.Forms.TextBox BankDeposits;
        private System.Windows.Forms.TextBox BankTitle;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BankType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BankCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox BankFilNo;
    }
}