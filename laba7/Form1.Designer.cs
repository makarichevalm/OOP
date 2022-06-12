
namespace laba7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TypeClient = new System.Windows.Forms.ComboBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.BankAccount = new System.Windows.Forms.TextBox();
            this.adressText = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.Label();
            this.accountText = new System.Windows.Forms.Label();
            this.typeText = new System.Windows.Forms.Label();
            this.AddClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AccountB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowInfo = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.RandomClients = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.TypeClient);
            this.panel1.Controls.Add(this.PhoneNumber);
            this.panel1.Controls.Add(this.Adress);
            this.panel1.Controls.Add(this.BankAccount);
            this.panel1.Controls.Add(this.adressText);
            this.panel1.Controls.Add(this.phoneText);
            this.panel1.Controls.Add(this.accountText);
            this.panel1.Controls.Add(this.typeText);
            this.panel1.Controls.Add(this.AddClient);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.title1);
            this.panel1.Location = new System.Drawing.Point(25, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 554);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TypeClient
            // 
            this.TypeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeClient.FormattingEnabled = true;
            this.TypeClient.Items.AddRange(new object[] {
            "Физическое лицо",
            "Организация"});
            this.TypeClient.Location = new System.Drawing.Point(236, 95);
            this.TypeClient.Name = "TypeClient";
            this.TypeClient.Size = new System.Drawing.Size(204, 28);
            this.TypeClient.TabIndex = 14;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(236, 237);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(204, 26);
            this.PhoneNumber.TabIndex = 13;
            this.PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber_KeyPress);
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(236, 309);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(204, 26);
            this.Adress.TabIndex = 12;
            // 
            // BankAccount
            // 
            this.BankAccount.Location = new System.Drawing.Point(236, 167);
            this.BankAccount.Name = "BankAccount";
            this.BankAccount.Size = new System.Drawing.Size(204, 26);
            this.BankAccount.TabIndex = 11;
            this.BankAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BankAccount_KeyPress);
            // 
            // adressText
            // 
            this.adressText.AutoSize = true;
            this.adressText.Location = new System.Drawing.Point(40, 352);
            this.adressText.Name = "adressText";
            this.adressText.Size = new System.Drawing.Size(0, 20);
            this.adressText.TabIndex = 10;
            // 
            // phoneText
            // 
            this.phoneText.AutoSize = true;
            this.phoneText.Location = new System.Drawing.Point(40, 280);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(0, 20);
            this.phoneText.TabIndex = 9;
            // 
            // accountText
            // 
            this.accountText.AutoSize = true;
            this.accountText.Location = new System.Drawing.Point(40, 209);
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(0, 20);
            this.accountText.TabIndex = 8;
            // 
            // typeText
            // 
            this.typeText.AutoSize = true;
            this.typeText.Location = new System.Drawing.Point(40, 139);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(0, 20);
            this.typeText.TabIndex = 7;
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(149, 414);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(149, 41);
            this.AddClient.TabIndex = 6;
            this.AddClient.Text = "Добавить";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер телефона:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Фактический адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер счета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип клиента:";
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Location = new System.Drawing.Point(116, 50);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(222, 20);
            this.title1.TabIndex = 0;
            this.title1.Text = "Добавление клиента банка:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.AccountB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ShowInfo);
            this.panel2.Controls.Add(this.DeleteClient);
            this.panel2.Location = new System.Drawing.Point(510, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 554);
            this.panel2.TabIndex = 1;
            // 
            // AccountB
            // 
            this.AccountB.Location = new System.Drawing.Point(55, 309);
            this.AccountB.Name = "AccountB";
            this.AccountB.Size = new System.Drawing.Size(242, 26);
            this.AccountB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Введите номер счета клиента:";
            // 
            // ShowInfo
            // 
            this.ShowInfo.Location = new System.Drawing.Point(93, 376);
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.Size = new System.Drawing.Size(149, 62);
            this.ShowInfo.TabIndex = 1;
            this.ShowInfo.Text = "Показать информацию";
            this.ShowInfo.UseVisualStyleBackColor = true;
            this.ShowInfo.Click += new System.EventHandler(this.ShowInfo_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.Location = new System.Drawing.Point(93, 152);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(149, 41);
            this.DeleteClient.TabIndex = 0;
            this.DeleteClient.Text = "Удалить";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.RandomClients);
            this.panel3.Location = new System.Drawing.Point(867, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 554);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Клиенты банка:";
            // 
            // RandomClients
            // 
            this.RandomClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomClients.Location = new System.Drawing.Point(22, 86);
            this.RandomClients.Multiline = true;
            this.RandomClients.Name = "RandomClients";
            this.RandomClients.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RandomClients.Size = new System.Drawing.Size(306, 448);
            this.RandomClients.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 618);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Клиенты банка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label adressText;
        private System.Windows.Forms.Label phoneText;
        private System.Windows.Forms.Label accountText;
        private System.Windows.Forms.Label typeText;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeClient;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.TextBox BankAccount;
        private System.Windows.Forms.TextBox AccountB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ShowInfo;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RandomClients;
    }
}

