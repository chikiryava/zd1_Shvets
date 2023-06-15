
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
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
            this.playerGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteTrackOnIndexButton = new System.Windows.Forms.Button();
            this.firstTrackButton = new System.Windows.Forms.Button();
            this.deleteCurrientTrackButton = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.currientTrackLabel = new System.Windows.Forms.Label();
            this.nextTrackButton = new System.Windows.Forms.Button();
            this.stopAndStartButton = new System.Windows.Forms.Button();
            this.previousTrackButton = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.addTrackGroupBox = new System.Windows.Forms.GroupBox();
            this.addTrackButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pathToTrackTextBox = new System.Windows.Forms.TextBox();
            this.trackTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.startTrackOnIndexButton = new System.Windows.Forms.Button();
            this.clearPlayListButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.marketGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.addShowGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.playerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.addTrackGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1508, 963);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.marketGroupBox);
            this.tabPage1.Controls.Add(this.addShowGroupBox);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1500, 930);
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
            this.marketGroupBox.Location = new System.Drawing.Point(0, 46);
            this.marketGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.marketGroupBox.Name = "marketGroupBox";
            this.marketGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.marketGroupBox.Size = new System.Drawing.Size(1491, 868);
            this.marketGroupBox.TabIndex = 2;
            this.marketGroupBox.TabStop = false;
            this.marketGroupBox.Text = "groupBox2";
            this.marketGroupBox.Enter += new System.EventHandler(this.marketGroupBox_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(166, 255);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(180, 26);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(408, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Введите количество товара, которое хотите купить";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1054, 545);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Введите количество товара";
            // 
            // countOfStuffTextBox
            // 
            this.countOfStuffTextBox.Location = new System.Drawing.Point(1059, 569);
            this.countOfStuffTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countOfStuffTextBox.Name = "countOfStuffTextBox";
            this.countOfStuffTextBox.Size = new System.Drawing.Size(148, 26);
            this.countOfStuffTextBox.TabIndex = 13;
            // 
            // addStuffButton
            // 
            this.addStuffButton.Location = new System.Drawing.Point(1059, 646);
            this.addStuffButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addStuffButton.Name = "addStuffButton";
            this.addStuffButton.Size = new System.Drawing.Size(134, 63);
            this.addStuffButton.TabIndex = 12;
            this.addStuffButton.Text = "Добавить товар";
            this.addStuffButton.UseVisualStyleBackColor = true;
            this.addStuffButton.Click += new System.EventHandler(this.addStuffButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1054, 452);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите цену товара";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1041, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите название товара";
            // 
            // stuffPriceTextBox
            // 
            this.stuffPriceTextBox.Location = new System.Drawing.Point(1059, 477);
            this.stuffPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stuffPriceTextBox.Name = "stuffPriceTextBox";
            this.stuffPriceTextBox.Size = new System.Drawing.Size(148, 26);
            this.stuffPriceTextBox.TabIndex = 9;
            // 
            // stuffNameTextBox
            // 
            this.stuffNameTextBox.Location = new System.Drawing.Point(1059, 375);
            this.stuffNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stuffNameTextBox.Name = "stuffNameTextBox";
            this.stuffNameTextBox.Size = new System.Drawing.Size(148, 26);
            this.stuffNameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(952, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Добавить товар в этот магазин";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(597, 25);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(883, 173);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // marketProfitLabel
            // 
            this.marketProfitLabel.AutoSize = true;
            this.marketProfitLabel.Location = new System.Drawing.Point(162, 408);
            this.marketProfitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.marketProfitLabel.Name = "marketProfitLabel";
            this.marketProfitLabel.Size = new System.Drawing.Size(157, 20);
            this.marketProfitLabel.TabIndex = 5;
            this.marketProfitLabel.Text = "Прибыль магазина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите название товара, который хотите купить";
            // 
            // stuffTextBox
            // 
            this.stuffTextBox.Location = new System.Drawing.Point(168, 149);
            this.stuffTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stuffTextBox.Name = "stuffTextBox";
            this.stuffTextBox.Size = new System.Drawing.Size(148, 26);
            this.stuffTextBox.TabIndex = 3;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(188, 335);
            this.buyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(112, 35);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите магазин";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 49);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 28);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // addShowGroupBox
            // 
            this.addShowGroupBox.Controls.Add(this.addMarketButton);
            this.addShowGroupBox.Controls.Add(this.label1);
            this.addShowGroupBox.Controls.Add(this.marketNameTextBox);
            this.addShowGroupBox.Location = new System.Drawing.Point(333, 46);
            this.addShowGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addShowGroupBox.Name = "addShowGroupBox";
            this.addShowGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addShowGroupBox.Size = new System.Drawing.Size(717, 343);
            this.addShowGroupBox.TabIndex = 1;
            this.addShowGroupBox.TabStop = false;
            this.addShowGroupBox.Text = "groupBox1";
            // 
            // addMarketButton
            // 
            this.addMarketButton.Location = new System.Drawing.Point(142, 120);
            this.addMarketButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addMarketButton.Name = "addMarketButton";
            this.addMarketButton.Size = new System.Drawing.Size(112, 35);
            this.addMarketButton.TabIndex = 2;
            this.addMarketButton.Text = "Добавить";
            this.addMarketButton.UseVisualStyleBackColor = true;
            this.addMarketButton.Click += new System.EventHandler(this.addMarketButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название магазина";
            // 
            // marketNameTextBox
            // 
            this.marketNameTextBox.Location = new System.Drawing.Point(117, 78);
            this.marketNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.marketNameTextBox.Name = "marketNameTextBox";
            this.marketNameTextBox.Size = new System.Drawing.Size(148, 26);
            this.marketNameTextBox.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Добавить магазин",
            "Магазин"});
            this.comboBox1.Location = new System.Drawing.Point(364, 5);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.playerGroupBox);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.addTrackGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1500, 930);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // playerGroupBox
            // 
            this.playerGroupBox.Controls.Add(this.clearPlayListButton);
            this.playerGroupBox.Controls.Add(this.startTrackOnIndexButton);
            this.playerGroupBox.Controls.Add(this.deleteTrackOnIndexButton);
            this.playerGroupBox.Controls.Add(this.firstTrackButton);
            this.playerGroupBox.Controls.Add(this.deleteCurrientTrackButton);
            this.playerGroupBox.Controls.Add(this.numericUpDown2);
            this.playerGroupBox.Controls.Add(this.currientTrackLabel);
            this.playerGroupBox.Controls.Add(this.nextTrackButton);
            this.playerGroupBox.Controls.Add(this.stopAndStartButton);
            this.playerGroupBox.Controls.Add(this.previousTrackButton);
            this.playerGroupBox.Location = new System.Drawing.Point(401, 43);
            this.playerGroupBox.Name = "playerGroupBox";
            this.playerGroupBox.Size = new System.Drawing.Size(585, 410);
            this.playerGroupBox.TabIndex = 2;
            this.playerGroupBox.TabStop = false;
            // 
            // deleteTrackOnIndexButton
            // 
            this.deleteTrackOnIndexButton.Location = new System.Drawing.Point(6, 287);
            this.deleteTrackOnIndexButton.Name = "deleteTrackOnIndexButton";
            this.deleteTrackOnIndexButton.Size = new System.Drawing.Size(161, 72);
            this.deleteTrackOnIndexButton.TabIndex = 7;
            this.deleteTrackOnIndexButton.Text = "Удалить трек по индексу";
            this.deleteTrackOnIndexButton.UseVisualStyleBackColor = true;
            this.deleteTrackOnIndexButton.Click += new System.EventHandler(this.deleteTrackOnIndexButton_Click);
            // 
            // firstTrackButton
            // 
            this.firstTrackButton.Location = new System.Drawing.Point(408, 179);
            this.firstTrackButton.Name = "firstTrackButton";
            this.firstTrackButton.Size = new System.Drawing.Size(160, 82);
            this.firstTrackButton.TabIndex = 6;
            this.firstTrackButton.Text = "Вернуться к первому треку";
            this.firstTrackButton.UseVisualStyleBackColor = true;
            this.firstTrackButton.Click += new System.EventHandler(this.firstTrackButton_Click);
            // 
            // deleteCurrientTrackButton
            // 
            this.deleteCurrientTrackButton.Location = new System.Drawing.Point(6, 196);
            this.deleteCurrientTrackButton.Name = "deleteCurrientTrackButton";
            this.deleteCurrientTrackButton.Size = new System.Drawing.Size(161, 85);
            this.deleteCurrientTrackButton.TabIndex = 5;
            this.deleteCurrientTrackButton.Text = "Удалить текущий трек";
            this.deleteCurrientTrackButton.UseVisualStyleBackColor = true;
            this.deleteCurrientTrackButton.Click += new System.EventHandler(this.deleteCurrientTrackButton_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(214, 179);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 4;
            // 
            // currientTrackLabel
            // 
            this.currientTrackLabel.AutoSize = true;
            this.currientTrackLabel.Location = new System.Drawing.Point(250, 12);
            this.currientTrackLabel.Name = "currientTrackLabel";
            this.currientTrackLabel.Size = new System.Drawing.Size(0, 20);
            this.currientTrackLabel.TabIndex = 3;
            // 
            // nextTrackButton
            // 
            this.nextTrackButton.Location = new System.Drawing.Point(312, 219);
            this.nextTrackButton.Name = "nextTrackButton";
            this.nextTrackButton.Size = new System.Drawing.Size(40, 38);
            this.nextTrackButton.TabIndex = 2;
            this.nextTrackButton.Text = "▶";
            this.nextTrackButton.UseVisualStyleBackColor = true;
            this.nextTrackButton.Click += new System.EventHandler(this.nextTrackButton_Click);
            // 
            // stopAndStartButton
            // 
            this.stopAndStartButton.Location = new System.Drawing.Point(254, 219);
            this.stopAndStartButton.Name = "stopAndStartButton";
            this.stopAndStartButton.Size = new System.Drawing.Size(39, 38);
            this.stopAndStartButton.TabIndex = 1;
            this.stopAndStartButton.Text = "⏯️";
            this.stopAndStartButton.UseVisualStyleBackColor = true;
            this.stopAndStartButton.Click += new System.EventHandler(this.stopAndStartButton_Click);
            // 
            // previousTrackButton
            // 
            this.previousTrackButton.Location = new System.Drawing.Point(197, 219);
            this.previousTrackButton.Name = "previousTrackButton";
            this.previousTrackButton.Size = new System.Drawing.Size(39, 38);
            this.previousTrackButton.TabIndex = 0;
            this.previousTrackButton.Text = "◀";
            this.previousTrackButton.UseVisualStyleBackColor = true;
            this.previousTrackButton.Click += new System.EventHandler(this.previousTrackButton_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Добавить трек в плейлист",
            "Открыть плейлист"});
            this.comboBox3.Location = new System.Drawing.Point(600, 9);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(222, 28);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // addTrackGroupBox
            // 
            this.addTrackGroupBox.Controls.Add(this.addTrackButton);
            this.addTrackGroupBox.Controls.Add(this.label11);
            this.addTrackGroupBox.Controls.Add(this.label10);
            this.addTrackGroupBox.Controls.Add(this.label9);
            this.addTrackGroupBox.Controls.Add(this.pathToTrackTextBox);
            this.addTrackGroupBox.Controls.Add(this.trackTextBox);
            this.addTrackGroupBox.Controls.Add(this.authorTextBox);
            this.addTrackGroupBox.Location = new System.Drawing.Point(401, 55);
            this.addTrackGroupBox.Name = "addTrackGroupBox";
            this.addTrackGroupBox.Size = new System.Drawing.Size(504, 400);
            this.addTrackGroupBox.TabIndex = 1;
            this.addTrackGroupBox.TabStop = false;
            this.addTrackGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // addTrackButton
            // 
            this.addTrackButton.Location = new System.Drawing.Point(173, 242);
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.Size = new System.Drawing.Size(117, 70);
            this.addTrackButton.TabIndex = 6;
            this.addTrackButton.Text = "Добавить трек";
            this.addTrackButton.UseVisualStyleBackColor = true;
            this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Укажите путь к файлу (.WAV)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Укажите название песни";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Укажите автора песни";
            // 
            // pathToTrackTextBox
            // 
            this.pathToTrackTextBox.Location = new System.Drawing.Point(173, 176);
            this.pathToTrackTextBox.Name = "pathToTrackTextBox";
            this.pathToTrackTextBox.Size = new System.Drawing.Size(100, 26);
            this.pathToTrackTextBox.TabIndex = 2;
            // 
            // trackTextBox
            // 
            this.trackTextBox.Location = new System.Drawing.Point(173, 114);
            this.trackTextBox.Name = "trackTextBox";
            this.trackTextBox.Size = new System.Drawing.Size(100, 26);
            this.trackTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(173, 60);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 26);
            this.authorTextBox.TabIndex = 0;
            // 
            // startTrackOnIndexButton
            // 
            this.startTrackOnIndexButton.Location = new System.Drawing.Point(229, 268);
            this.startTrackOnIndexButton.Name = "startTrackOnIndexButton";
            this.startTrackOnIndexButton.Size = new System.Drawing.Size(105, 91);
            this.startTrackOnIndexButton.TabIndex = 8;
            this.startTrackOnIndexButton.Text = "Включить трек по индексу";
            this.startTrackOnIndexButton.UseVisualStyleBackColor = true;
            this.startTrackOnIndexButton.Click += new System.EventHandler(this.startTrackOnIndexButton_Click);
            // 
            // clearPlayListButton
            // 
            this.clearPlayListButton.Location = new System.Drawing.Point(408, 268);
            this.clearPlayListButton.Name = "clearPlayListButton";
            this.clearPlayListButton.Size = new System.Drawing.Size(160, 78);
            this.clearPlayListButton.TabIndex = 9;
            this.clearPlayListButton.Text = "Очистить плейлист";
            this.clearPlayListButton.UseVisualStyleBackColor = true;
            this.clearPlayListButton.Click += new System.EventHandler(this.clearPlayListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 963);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.marketGroupBox.ResumeLayout(false);
            this.marketGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.addShowGroupBox.ResumeLayout(false);
            this.addShowGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.playerGroupBox.ResumeLayout(false);
            this.playerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.addTrackGroupBox.ResumeLayout(false);
            this.addTrackGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox addTrackGroupBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button addTrackButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pathToTrackTextBox;
        private System.Windows.Forms.TextBox trackTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.GroupBox playerGroupBox;
        private System.Windows.Forms.Button nextTrackButton;
        private System.Windows.Forms.Button stopAndStartButton;
        private System.Windows.Forms.Button previousTrackButton;
        private System.Windows.Forms.Label currientTrackLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button deleteCurrientTrackButton;
        private System.Windows.Forms.Button firstTrackButton;
        private System.Windows.Forms.Button deleteTrackOnIndexButton;
        private System.Windows.Forms.Button startTrackOnIndexButton;
        private System.Windows.Forms.Button clearPlayListButton;
    }
}

