
namespace laba8
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BankType = new System.Windows.Forms.ComboBox();
            this.TextBankType = new System.Windows.Forms.Label();
            this.TextBankCredit = new System.Windows.Forms.Label();
            this.TextBankProc = new System.Windows.Forms.Label();
            this.TextBankDepos = new System.Windows.Forms.Label();
            this.TextBankTitle = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.BankFilNo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BankTitle = new System.Windows.Forms.TextBox();
            this.BankDeposits = new System.Windows.Forms.TextBox();
            this.BankProcent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BankCredit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BankAtmYes = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Banks = new System.Windows.Forms.TextBox();
            this.title2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butLinq = new System.Windows.Forms.Button();
            this.LinqText = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.BankType);
            this.panel2.Controls.Add(this.TextBankType);
            this.panel2.Controls.Add(this.TextBankCredit);
            this.panel2.Controls.Add(this.TextBankProc);
            this.panel2.Controls.Add(this.TextBankDepos);
            this.panel2.Controls.Add(this.TextBankTitle);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.BankFilNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BankTitle);
            this.panel2.Controls.Add(this.BankDeposits);
            this.panel2.Controls.Add(this.BankProcent);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BankCredit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BankAtmYes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 596);
            this.panel2.TabIndex = 80;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BankType
            // 
            this.BankType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BankType.FormattingEnabled = true;
            this.BankType.Items.AddRange(new object[] {
            "Государственный",
            "Частный"});
            this.BankType.Location = new System.Drawing.Point(339, 227);
            this.BankType.Name = "BankType";
            this.BankType.Size = new System.Drawing.Size(215, 28);
            this.BankType.TabIndex = 83;
            // 
            // TextBankType
            // 
            this.TextBankType.AutoSize = true;
            this.TextBankType.Location = new System.Drawing.Point(15, 265);
            this.TextBankType.Name = "TextBankType";
            this.TextBankType.Size = new System.Drawing.Size(0, 20);
            this.TextBankType.TabIndex = 82;
            // 
            // TextBankCredit
            // 
            this.TextBankCredit.AutoSize = true;
            this.TextBankCredit.Location = new System.Drawing.Point(13, 335);
            this.TextBankCredit.Name = "TextBankCredit";
            this.TextBankCredit.Size = new System.Drawing.Size(0, 20);
            this.TextBankCredit.TabIndex = 81;
            // 
            // TextBankProc
            // 
            this.TextBankProc.AutoSize = true;
            this.TextBankProc.Location = new System.Drawing.Point(15, 196);
            this.TextBankProc.Name = "TextBankProc";
            this.TextBankProc.Size = new System.Drawing.Size(0, 20);
            this.TextBankProc.TabIndex = 79;
            // 
            // TextBankDepos
            // 
            this.TextBankDepos.AutoSize = true;
            this.TextBankDepos.Location = new System.Drawing.Point(15, 126);
            this.TextBankDepos.Name = "TextBankDepos";
            this.TextBankDepos.Size = new System.Drawing.Size(0, 20);
            this.TextBankDepos.TabIndex = 78;
            // 
            // TextBankTitle
            // 
            this.TextBankTitle.AutoSize = true;
            this.TextBankTitle.Location = new System.Drawing.Point(15, 55);
            this.TextBankTitle.Name = "TextBankTitle";
            this.TextBankTitle.Size = new System.Drawing.Size(0, 20);
            this.TextBankTitle.TabIndex = 77;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_add.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(19, 521);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(246, 51);
            this.button_add.TabIndex = 75;
            this.button_add.Text = "Добавить банк";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // BankFilNo
            // 
            this.BankFilNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankFilNo.AutoSize = true;
            this.BankFilNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankFilNo.Location = new System.Drawing.Point(339, 422);
            this.BankFilNo.Name = "BankFilNo";
            this.BankFilNo.Size = new System.Drawing.Size(86, 30);
            this.BankFilNo.TabIndex = 74;
            this.BankFilNo.Text = "Есть";
            this.BankFilNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = " Наименование банка";
            // 
            // BankTitle
            // 
            this.BankTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankTitle.Location = new System.Drawing.Point(339, 15);
            this.BankTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankTitle.Name = "BankTitle";
            this.BankTitle.Size = new System.Drawing.Size(215, 32);
            this.BankTitle.TabIndex = 54;
            // 
            // BankDeposits
            // 
            this.BankDeposits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankDeposits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankDeposits.Location = new System.Drawing.Point(339, 87);
            this.BankDeposits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankDeposits.Name = "BankDeposits";
            this.BankDeposits.Size = new System.Drawing.Size(215, 32);
            this.BankDeposits.TabIndex = 55;
            // 
            // BankProcent
            // 
            this.BankProcent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankProcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankProcent.Location = new System.Drawing.Point(339, 158);
            this.BankProcent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankProcent.Name = "BankProcent";
            this.BankProcent.Size = new System.Drawing.Size(215, 32);
            this.BankProcent.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Число вкладов";
            // 
            // BankCredit
            // 
            this.BankCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankCredit.Location = new System.Drawing.Point(339, 295);
            this.BankCredit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankCredit.Name = "BankCredit";
            this.BankCredit.Size = new System.Drawing.Size(215, 32);
            this.BankCredit.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 367);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 26);
            this.label7.TabIndex = 59;
            this.label7.Text = "Наличие банкоматов";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Размер процентной ставки";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 422);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 26);
            this.label6.TabIndex = 73;
            this.label6.Text = "Наличие филиалов";
            // 
            // BankAtmYes
            // 
            this.BankAtmYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankAtmYes.AutoSize = true;
            this.BankAtmYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankAtmYes.Location = new System.Drawing.Point(339, 367);
            this.BankAtmYes.Name = "BankAtmYes";
            this.BankAtmYes.Size = new System.Drawing.Size(86, 30);
            this.BankAtmYes.TabIndex = 72;
            this.BankAtmYes.Text = "Есть";
            this.BankAtmYes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 227);
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
            this.label5.Location = new System.Drawing.Point(12, 296);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 26);
            this.label5.TabIndex = 53;
            this.label5.Text = "Срок кредита";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.Banks);
            this.panel1.Controls.Add(this.title2);
            this.panel1.Location = new System.Drawing.Point(592, 20);
            this.panel1.MaximumSize = new System.Drawing.Size(600, 596);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 596);
            this.panel1.TabIndex = 81;
            // 
            // Banks
            // 
            this.Banks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Banks.Location = new System.Drawing.Point(16, 83);
            this.Banks.MaximumSize = new System.Drawing.Size(450, 500);
            this.Banks.Multiline = true;
            this.Banks.Name = "Banks";
            this.Banks.ReadOnly = true;
            this.Banks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Banks.Size = new System.Drawing.Size(331, 500);
            this.Banks.TabIndex = 10;
            // 
            // title2
            // 
            this.title2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.title2.Location = new System.Drawing.Point(3, 27);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(79, 26);
            this.title2.TabIndex = 11;
            this.title2.Text = "Банки:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.butLinq);
            this.panel3.Controls.Add(this.LinqText);
            this.panel3.Location = new System.Drawing.Point(985, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 596);
            this.panel3.TabIndex = 82;
            // 
            // butLinq
            // 
            this.butLinq.BackColor = System.Drawing.Color.PaleTurquoise;
            this.butLinq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.butLinq.Location = new System.Drawing.Point(55, 15);
            this.butLinq.Name = "butLinq";
            this.butLinq.Size = new System.Drawing.Size(246, 51);
            this.butLinq.TabIndex = 1;
            this.butLinq.Text = "LINQ-запросы";
            this.butLinq.UseVisualStyleBackColor = false;
            this.butLinq.Click += new System.EventHandler(this.butLinq_Click);
            // 
            // LinqText
            // 
            this.LinqText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LinqText.Location = new System.Drawing.Point(21, 83);
            this.LinqText.Multiline = true;
            this.LinqText.Name = "LinqText";
            this.LinqText.ReadOnly = true;
            this.LinqText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LinqText.Size = new System.Drawing.Size(340, 489);
            this.LinqText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1378, 674);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1400, 730);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банк";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.CheckBox BankFilNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BankTitle;
        private System.Windows.Forms.TextBox BankDeposits;
        private System.Windows.Forms.TextBox BankProcent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BankCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox BankAtmYes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Banks;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox LinqText;
        private System.Windows.Forms.Button butLinq;
        private System.Windows.Forms.Label TextBankCredit;
        private System.Windows.Forms.Label TextBankProc;
        private System.Windows.Forms.Label TextBankDepos;
        private System.Windows.Forms.Label TextBankTitle;
        private System.Windows.Forms.Label TextBankType;
        private System.Windows.Forms.ComboBox BankType;
    }
}

