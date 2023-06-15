using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form1 :Form
    {
        List<Shop> list_of_shops = new List<Shop>();
        Shop currient_shop;
        int index;
        public Form1 ()
        {
            InitializeComponent();
            marketGroupBox.Visible = addShowGroupBox.Visible = false;
        }

        private void tabPage1_Click (object sender, EventArgs e)
        {

        }

        private void addMarketButton_Click (object sender, EventArgs e)
        {
            if (checkName(marketNameTextBox.Text))
            {
                addInList();
                MessageBox.Show("Вы добавили магазин");
            }
        }
        private bool checkName (string name)
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Вы не ввели название магазина");
                return false;
            }
                
            foreach(char i in name)
            {
                if (!Char.IsLetterOrDigit(i))
                {
                    MessageBox.Show("Название магазина может содержать только буквы и цифры");
                    return false;                   
                }
            }
            return true;
        }

        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    addShowGroupBox.Visible = true;
                    marketGroupBox.Visible = false;
                    break;
                case 1:
                    addShowGroupBox.Visible = false;
                    marketGroupBox.Visible = true;
                    break;
            }

        }

        private void comboBox2_SelectedIndexChanged (object sender, EventArgs e)
        {
            index = comboBox2.SelectedIndex;
            refresh(index);
        }

        private void button1_Click (object sender, EventArgs e)
        {
            if (checkMarket())
            {
                currient_shop.Sell(stuffTextBox.Text,int.Parse(numericUpDown1.Value.ToString()));
                refresh(index);
            }
        }
        private void refresh (int index)
        {
            currient_shop = list_of_shops[index];
            marketProfitLabel.Text = $"Прибыль магазина: {currient_shop.getProfit} рублей";
            currient_shop.showAllProducts(listView1);
        }
        private void addInList ()
        {
            list_of_shops.Add(new Shop(marketNameTextBox.Text));
            comboBox2.Items.Add(list_of_shops[list_of_shops.Count - 1].getName);
        }
        private bool checkStuff ()
        {
            try
            {
                decimal price = Convert.ToDecimal(stuffPriceTextBox.Text);
                int count = int.Parse(countOfStuffTextBox.Text);
                if (stuffNameTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Вы не ввели значение в имя товара");
                    return false;
                }
                if (price <= 0)
                {
                    MessageBox.Show("Цена должна быть больше 0");
                    return false;
                }
                if (count <= 0)
                {
                    MessageBox.Show("Количество товара должно быть больше 0");
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Вы ввели не число");
                return false;
            }
        }

        private void addStuffButton_Click (object sender, EventArgs e)
        {
            if (checkStuff()&&checkMarket())
            {
                if (currient_shop.FindByName(stuffNameTextBox.Text) == null)
                {                    
                    currient_shop.CreateProduct(stuffNameTextBox.Text, Convert.ToDecimal(stuffPriceTextBox.Text), int.Parse(countOfStuffTextBox.Text));
                    refresh(index);
                    MessageBox.Show("Вы добавили товар в магазин");
                } else
                    MessageBox.Show("Такой товар уже существует");
            }
        }
        private bool checkMarket ()
        {
            if (currient_shop == null)
            {
                MessageBox.Show("Вы не выбрали магазин");
                return false;
            }
            return true;
        }

        private void listView1_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void marketGroupBox_Enter (object sender, EventArgs e)
        {

        }
    }
}
