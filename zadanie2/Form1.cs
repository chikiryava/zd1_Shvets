using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;


namespace zadanie2
{
    public partial class Form1 :Form
    {
        List<Shop> list_of_shops = new List<Shop>();
        Shop currient_shop;
        int currient_track_index = 0;
        Playlist playlist = new Playlist();
        SoundPlayer player = new SoundPlayer();

        int index;
        public Form1 ()
        {
            InitializeComponent();
            marketGroupBox.Visible = addShowGroupBox.Visible = false;
            playerGroupBox.Visible = false;
            addTrackGroupBox.Visible = false;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //zadanie 2 code

        private void addTrackButton_Click(object sender, EventArgs e)
        {
            if (checkTrack())
            {
                playlist.Add(authorTextBox.Text, trackTextBox.Text, pathToTrackTextBox.Text);
                UpdateCountOfTracks();
                MessageBox.Show("Трек был добавлен");
            }
        }
        public bool checkTrack()
        {
            if (trackTextBox.Text.Length == 0)
            {
                MessageBox.Show("Вы должны ввести название трека");
                return false;
            }
            if (authorTextBox.Text.Length == 0)
            {
                MessageBox.Show("Вы должны ввести автора трека");
                return false;
            }
            if(pathToTrackTextBox.Text.Length == 0)
            {
                MessageBox.Show("Вы должны указать путь к файлу");
                return false;
            }
            if (!File.Exists(pathToTrackTextBox.Text))
            {
                MessageBox.Show("Такого файла не существует");
                return false;
            }
            return true;
        }
        public void UpdateCountOfTracks()
        {
            if(playlist.CountOfTracks>1)
                numericUpDown2.Maximum = playlist.CountOfTracks-1;
            else
                numericUpDown2.Maximum = 0;
        }
        private void previousTrackButton_Click(object sender, EventArgs e)
        {
            if (playlist.CountOfTracks == 0)
            {
                MessageBox.Show("У вас нет треков в плейлисте");
            }
            else
            {
                if (currient_track_index > 0)
                {
                    currient_track_index--;
                    player.SoundLocation = playlist.GetTrack(currient_track_index);
                    player.Play();
                    currientTrackLabel.Text = playlist.GetTitle(currient_track_index);
                    stopAndStartButton.Text = "⏸";
                }
            }
        }

        private void stopAndStartButton_Click(object sender, EventArgs e)
        {
            if(stopAndStartButton.Text == "⏸")
            {
                if (playlist.CountOfTracks == 0)
                {
                    MessageBox.Show("У вас нет треков в плейлисте");
                }
                else
                {
                    player.Stop();
                    stopAndStartButton.Text = "⏯️";
                }

            }
            else if(stopAndStartButton.Text == "⏯️")
            {
                if (playlist.CountOfTracks == 0)
                {
                    MessageBox.Show("У вас нет треков в плейлисте");
                }
                else
                {
                    player.Stop();
                    player.SoundLocation = playlist.GetTrack(currient_track_index);
                    player.Play();
                    currientTrackLabel.Text = playlist.GetTitle(currient_track_index);
                    stopAndStartButton.Text = "⏸";
                }

            }
        }

        private void nextTrackButton_Click(object sender, EventArgs e)
        {
            if (playlist.CountOfTracks == 0)
            {
                MessageBox.Show("У вас нет треков в плейлисте");
            }
            else
            {
                if (currient_track_index < playlist.CountOfTracks - 1)
                {
                    player.Stop();
                    currient_track_index++;
                    player.SoundLocation = playlist.GetTrack(currient_track_index);
                    player.Play();
                    currientTrackLabel.Text = playlist.GetTitle(currient_track_index);
                    stopAndStartButton.Text = "⏸";
                }
            }

        }

        private void deleteCurrientTrackButton_Click(object sender, EventArgs e)
        {
            try
            {             
                    player.Stop();
                    playlist.DeleteTrack(currient_track_index);
                    UpdateCountOfTracks();
                    player.SoundLocation = playlist.GetTrack(currient_track_index);
                    player.Play();
                    stopAndStartButton.Text = "⏸";
                    currientTrackLabel.Text = playlist.GetTitle(currient_track_index);
                
            }
            catch (Exception ex)
            {
                if (playlist.CountOfTracks == 0)
                {
                    currientTrackLabel.Text = "";
                    MessageBox.Show("У вас нет треков в плейлисте");
                }
                else
                {
                    player.SoundLocation = playlist.GetTrack(playlist.CountOfTracks - 1);
                    player.Play();
                    stopAndStartButton.Text = "⏸";
                    currientTrackLabel.Text = playlist.GetTitle(playlist.CountOfTracks-1);
                }
            }
        }

        private void deleteTrackOnIndexButton_Click(object sender, EventArgs e)
        {
            try
            {
                player.Stop();
                playlist.DeleteTrack(int.Parse(numericUpDown2.Value.ToString()));
                UpdateCountOfTracks();
                player.SoundLocation = playlist.GetTrack(int.Parse(numericUpDown2.Value.ToString()));
                player.Play();
                stopAndStartButton.Text = "⏸";
                currientTrackLabel.Text = playlist.GetTitle(int.Parse(numericUpDown2.Value.ToString()));

            }
            catch (Exception ex)
            {
                if (playlist.CountOfTracks == 0)
                {
                    currientTrackLabel.Text = "";
                    MessageBox.Show("У вас нет треков в плейлисте");
                }
                else
                {
                    player.SoundLocation = playlist.GetTrack(playlist.CountOfTracks - 1);
                    player.Play();
                    stopAndStartButton.Text = "⏸";
                    currientTrackLabel.Text = playlist.GetTitle(playlist.CountOfTracks - 1);
                }
            }
        }

        private void startTrackOnIndexButton_Click(object sender, EventArgs e)
        {
            if (playlist.CountOfTracks == 0)
            {
                MessageBox.Show("У вас нет треков в плейлисте");
            }
            else
            {
                
                    player.Stop();
                    currient_track_index++;
                    player.SoundLocation = playlist.GetTrack(int.Parse(numericUpDown2.Value.ToString()));
                    player.Play();
                stopAndStartButton.Text = "⏸";
                currientTrackLabel.Text = playlist.GetTitle(int.Parse(numericUpDown2.Value.ToString()));
                currient_track_index = int.Parse(numericUpDown2.Value.ToString());


            }
        }

        private void firstTrackButton_Click(object sender, EventArgs e)
        {
            if (playlist.CountOfTracks == 0)
            {
                currientTrackLabel.Text = "";
                MessageBox.Show("У вас нет треков в плейлисте");
            }
            else
            {
                player.SoundLocation = playlist.GetTrack(0);
                player.Play();
                stopAndStartButton.Text = "⏸";
                currientTrackLabel.Text = playlist.GetTitle(0);
            }
        }

        private void clearPlayListButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            playlist.ClearPlayList();
            UpdateCountOfTracks();
            stopAndStartButton.Text = "⏯️";
            currient_track_index = 0;
            currientTrackLabel.Text = "";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex == 0)
            {
                playerGroupBox.Visible = false;
                addTrackGroupBox.Visible = true;
            }
            else
            {
                playerGroupBox.Visible = true;
                addTrackGroupBox.Visible = false;
            }
        }
    }
}
