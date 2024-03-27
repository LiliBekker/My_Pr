using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoicedAndDeafConsonants
{  
    public partial class GameTheme : Form
    {
        public GameTheme()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            this.FormClosing += Form_FormClosing;
            foreach (var item in this.Controls) //обходим все элементы формы
            {
                if (item is Button) // проверяем, что это кнопка
                {
                    ((Button)item).BackColor = System.Drawing.Color.Transparent;
                    ((Button)item).FlatAppearance.BorderSize = 0;
                    ((Button)item).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    ((Button)item).FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                    ((Button)item).FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                }
            }
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameType gameselection = new GameType();
            gameselection.Show();
        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            Theme.str = "Забрось мяч в нужную корзину";
            Theme.bitmap1 = new Bitmap("BasDull.png");
            Theme.bitmap2 = new Bitmap("BasRinging.png");
            Theme.bitmap3 = new Bitmap("Ball.png");
            this.Hide();
            Levels wheresound = new Levels();
            wheresound.Show();
        }      

        private void buttonFlower_Click(object sender, EventArgs e)
        {
            Theme.str = "Собери цветы в корзину";
            Theme.bitmap1 = new Bitmap("BasketDull.png");
            Theme.bitmap2 = new Bitmap("BasketRinging.png");
            Theme.bitmap3 = new Bitmap("Flower.png");
            this.Hide();
            Levels wheresound = new Levels();
            wheresound.Show();
        }

        private void buttonFish_Click(object sender, EventArgs e)
        {
            Theme.str = "Выпусти рыбок в пруд";
            Theme.bitmap1 = new Bitmap("PondDull.png");
            Theme.bitmap2 = new Bitmap("PondRinging.png");
            Theme.bitmap3 = new Bitmap("Fish.png");
            this.Hide();
            Levels wheresound = new Levels();
            wheresound.Show();
        }

        private void buttonBee_Click(object sender, EventArgs e)
        {
            Theme.str = "Помоги пчелкам добраться до улья";
            Theme.bitmap1 = new Bitmap("BeehiveDull.png");
            Theme.bitmap2 = new Bitmap("1.png");
            Theme.bitmap3 = new Bitmap("Bee.png");
            this.Hide();
            Levels wheresound = new Levels();
            wheresound.Show();
        }

        private void GameTheme_Load(object sender, EventArgs e)
        {

        }
    }
}
