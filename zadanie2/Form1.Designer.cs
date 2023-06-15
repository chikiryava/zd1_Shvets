
namespace zadanie2
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
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.marketGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.countOfStuffTextBox = new System.Windows.Forms.TextBox();
            this.addStuffButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stuffPriceTextBox = new System.Windows.Forms.TextBox();
            this.stuffNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.marketProfitLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stuffTextBox = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.addShowGroupBox = new System.Windows.Forms.GroupBox();
            this.addMarketButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.marketNameTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.marketGroupBox.SuspendLayout();
            this.addShowGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 626);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.marketGroupBox);
            this.tabPage1.Controls.Add(this.addShowGroupBox);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // marketGroupBox
            // 
            this.marketGroupBox.Controls.Add(this.numericUpDown1);
            this.marketGroupBox.Controls.Add(this.label8);
            this.marketGroupBox.Controls.Add(this.label7);
            this.marketGroupBox.Controls.Add(this.countOfStuffTextBox);
            this.marketGroupBox.Controls.Add(this.addStuffButton);
            this.marketGroupBox.Controls.Add(this.label6);
            this.marketGroupBox.Controls.Add(this.label5);
            this.marketGroupBox.Controls.Add(this.stuffPriceTextBox);
            this.marketGroupBox.Controls.Add(this.stuffNameTextBox);
            this.marketGroupBox.Controls.Add(this.label4);
            this.marketGroupBox.Controls.Add(this.listView1);
            this.marketGroupBox.Controls.Add(this.marketProfitLabel);
            this.marketGroupBox.Controls.Add(this.label3);
            this.marketGroupBox.Controls.Add(this.stuffTextBox);
            this.marketGroupBox.Controls.Add(this.buyButton);
            this.marketGroupBox.Controls.Add(this.label2);
            this.marketGroupBox.Controls.Add(this.comboBox2);
            this.marketGroupBox.Location = new System.Drawing.Point(0, 30);
            this.marketGroupBox.Name = "marketGroupBox";
            this.marketGroupBox.Size = new System.Drawing.Size(994, 564);
            this.marketGroupBox.TabIndex = 2;
            this.marketGroupBox.TabStop = false;
            this.marketGroupBox.Text = "groupBox2";
            this.marketGroupBox.Enter += new System.EventHandler(this.marketGroupBox_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(703, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Введите количество товара";
            // 
            // countOfStuffTextBox
            // 
            this.countOfStuffTextBox.Location = new System.Drawing.Point(706, 370);
            this.countOfStuffTextBox.Name = "countOfStuffTextBox";
            this.countOfStuffTextBox.Size = new System.Drawing.Size(100, 20);
            this.countOfStuffTextBox.TabIndex = 13;
            // 
            // addStuffButton
            // 
            this.addStuffButton.Location = new System.Drawing.Point(706, 420);
            this.addStuffButton.Name = "addStuffButton";
            this.addStuffButton.Size = new System.Drawing.Size(89, 41);
            this.addStuffButton.TabIndex = 12;
            this.addStuffButton.Text = "Добавить товар";
            this.addStuffButton.UseVisualStyleBackColor = true;
            this.addStuffButton.Click += new System.EventHandler(this.addStuffButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите цену товара";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(694, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите название товара";
            // 
            // stuffPriceTextBox
            // 
            this.stuffPriceTextBox.Location = new System.Drawing.Point(706, 310);
            this.stuffPriceTextBox.Name = "stuffPriceTextBox";
            this.stuffPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.stuffPriceTextBox.TabIndex = 9;
            // 
            // stuffNameTextBox
            // 
            this.stuffNameTextBox.Location = new System.Drawing.Point(706, 244);
            this.stuffNameTextBox.Name = "stuffNameTextBox";
            this.stuffNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.stuffNameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Добавить товар в этот магазин";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(398, 16);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(590, 114);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // marketProfitLabel
            // 
            this.marketProfitLabel.AutoSize = true;
            this.marketProfitLabel.Location = new System.Drawing.Point(108, 265);
            this.marketProfitLabel.Name = "marketProfitLabel";
            this.marketProfitLabel.Size = new System.Drawing.Size(108, 13);
            this.marketProfitLabel.TabIndex = 5;
            this.marketProfitLabel.Text = "Прибыль магазина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите название товара, который хотите купить";
            // 
            // stuffTextBox
            // 
            this.stuffTextBox.Location = new System.Drawing.Point(112, 97);
            this.stuffTextBox.Name = "stuffTextBox";
            this.stuffTextBox.Size = new System.Drawing.Size(100, 20);
            this.stuffTextBox.TabIndex = 3;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(125, 218);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите магазин";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // addShowGroupBox
            // 
            this.addShowGroupBox.Controls.Add(this.addMarketButton);
            this.addShowGroupBox.Controls.Add(this.label1);
            this.addShowGroupBox.Controls.Add(this.marketNameTextBox);
            this.addShowGroupBox.Location = new System.Drawing.Point(222, 30);
            this.addShowGroupBox.Name = "addShowGroupBox";
            this.addShowGroupBox.Size = new System.Drawing.Size(478, 223);
            this.addShowGroupBox.TabIndex = 1;
            this.addShowGroupBox.TabStop = false;
            this.addShowGroupBox.Text = "groupBox1";
            // 
            // addMarketButton
            // 
            this.addMarketButton.Location = new System.Drawing.Point(95, 78);
            this.addMarketButton.Name = "addMarketButton";
            this.addMarketButton.Size = new System.Drawing.Size(75, 23);
            this.addMarketButton.TabIndex = 2;
            this.addMarketButton.Text = "Добавить";
            this.addMarketButton.UseVisualStyleBackColor = true;
            this.addMarketButton.Click += new System.EventHandler(this.addMarketButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название магазина";
            // 
            // marketNameTextBox
            // 
            this.marketNameTextBox.Location = new System.Drawing.Point(78, 51);
            this.marketNameTextBox.Name = "marketNameTextBox";
            this.marketNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.marketNameTextBox.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Добавить магазин",
            "Магазин"});
            this.comboBox1.Location = new System.Drawing.Point(243, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Введите количество товара, которое хотите купить";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 166);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 626);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.marketGroupBox.ResumeLayout(false);
            this.marketGroupBox.PerformLayout();
            this.addShowGroupBox.ResumeLayout(false);
            this.addShowGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox marketGroupBox;
        private System.Windows.Forms.GroupBox addShowGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marketNameTextBox;
        private System.Windows.Forms.Button addMarketButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox stuffTextBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label marketProfitLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stuffPriceTextBox;
        private System.Windows.Forms.TextBox stuffNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addStuffButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox countOfStuffTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
    }
}

