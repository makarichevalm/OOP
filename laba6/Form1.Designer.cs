
namespace laba6
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.TextBox();
            this.BankAccount = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.type = new System.Windows.Forms.TextBox();
            this.adressText = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.Label();
            this.accountText = new System.Windows.Forms.Label();
            this.typeText = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.AddClient = new System.Windows.Forms.Button();
            this.RandomClients = new System.Windows.Forms.TextBox();
            this.title2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AccountB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фактический адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер счета:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер телефона:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип клиента:";
            // 
            // Adress
            // 
            this.Adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Adress.Location = new System.Drawing.Point(189, 234);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(177, 26);
            this.Adress.TabIndex = 4;
            // 
            // BankAccount
            // 
            this.BankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BankAccount.Location = new System.Drawing.Point(189, 105);
            this.BankAccount.Name = "BankAccount";
            this.BankAccount.Size = new System.Drawing.Size(177, 26);
            this.BankAccount.TabIndex = 5;
            this.BankAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BankAccount_KeyPress);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumber.Location = new System.Drawing.Point(189, 170);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(177, 26);
            this.PhoneNumber.TabIndex = 6;
            this.PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.type);
            this.panel1.Controls.Add(this.adressText);
            this.panel1.Controls.Add(this.phoneText);
            this.panel1.Controls.Add(this.accountText);
            this.panel1.Controls.Add(this.typeText);
            this.panel1.Controls.Add(this.title1);
            this.panel1.Controls.Add(this.AddClient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Adress);
            this.panel1.Controls.Add(this.PhoneNumber);
            this.panel1.Controls.Add(this.BankAccount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.MaximumSize = new System.Drawing.Size(500, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 464);
            this.panel1.TabIndex = 9;
            // 
            // type
            // 
            this.type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.type.Location = new System.Drawing.Point(189, 47);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(177, 26);
            this.type.TabIndex = 16;
            // 
            // adressText
            // 
            this.adressText.AutoSize = true;
            this.adressText.Location = new System.Drawing.Point(19, 273);
            this.adressText.Name = "adressText";
            this.adressText.Size = new System.Drawing.Size(0, 20);
            this.adressText.TabIndex = 15;
            // 
            // phoneText
            // 
            this.phoneText.AutoSize = true;
            this.phoneText.Location = new System.Drawing.Point(19, 208);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(0, 20);
            this.phoneText.TabIndex = 14;
            // 
            // accountText
            // 
            this.accountText.AutoSize = true;
            this.accountText.Location = new System.Drawing.Point(19, 144);
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(0, 20);
            this.accountText.TabIndex = 13;
            // 
            // typeText
            // 
            this.typeText.AutoSize = true;
            this.typeText.Location = new System.Drawing.Point(19, 79);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(0, 20);
            this.typeText.TabIndex = 12;
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Location = new System.Drawing.Point(82, 11);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(222, 20);
            this.title1.TabIndex = 11;
            this.title1.Text = "Добавление клиента банка:";
            // 
            // AddClient
            // 
            this.AddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClient.Location = new System.Drawing.Point(141, 318);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(127, 36);
            this.AddClient.TabIndex = 9;
            this.AddClient.Text = "Добавить";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // RandomClients
            // 
            this.RandomClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomClients.Location = new System.Drawing.Point(14, 44);
            this.RandomClients.MaximumSize = new System.Drawing.Size(450, 397);
            this.RandomClients.Multiline = true;
            this.RandomClients.Name = "RandomClients";
            this.RandomClients.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RandomClients.Size = new System.Drawing.Size(365, 397);
            this.RandomClients.TabIndex = 10;
            // 
            // title2
            // 
            this.title2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title2.AutoSize = true;
            this.title2.Location = new System.Drawing.Point(10, 11);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(128, 20);
            this.title2.TabIndex = 11;
            this.title2.Text = "Клиенты банка:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.RandomClients);
            this.panel2.Controls.Add(this.title2);
            this.panel2.Location = new System.Drawing.Point(887, 12);
            this.panel2.MaximumSize = new System.Drawing.Size(600, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 464);
            this.panel2.TabIndex = 15;
            // 
            // ShowInfo
            // 
            this.ShowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowInfo.Location = new System.Drawing.Point(96, 234);
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.Size = new System.Drawing.Size(151, 59);
            this.ShowInfo.TabIndex = 16;
            this.ShowInfo.Text = "Показать информацию";
            this.ShowInfo.UseVisualStyleBackColor = true;
            this.ShowInfo.Click += new System.EventHandler(this.ShowInfo_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Введите номер счета клиента:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.AccountB);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.ShowInfo);
            this.panel3.Location = new System.Drawing.Point(486, 12);
            this.panel3.MaximumSize = new System.Drawing.Size(400, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 464);
            this.panel3.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(96, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 76);
            this.button1.TabIndex = 20;
            this.button1.Text = "Вызвать кастомное исключение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountB
            // 
            this.AccountB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountB.Location = new System.Drawing.Point(16, 175);
            this.AccountB.Name = "AccountB";
            this.AccountB.Size = new System.Drawing.Size(323, 26);
            this.AccountB.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 520);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1335, 576);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты банка";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.TextBox BankAccount;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.TextBox RandomClients;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShowInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label adressText;
        private System.Windows.Forms.Label phoneText;
        private System.Windows.Forms.Label accountText;
        private System.Windows.Forms.Label typeText;
        private System.Windows.Forms.TextBox AccountB;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Button button1;
    }
}

