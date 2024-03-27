using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoicedAndDeafConsonants
{
    public partial class WhereSound : Form
    {
        public WhereSound(int N)
        {
            InitializeComponent();

            this.label1.BackColor = System.Drawing.Color.Transparent;
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
            SoundDistribution sounddistribution = new SoundDistribution();
            String a="";
            Bitmap B = new Bitmap("2.png");
            Bitmap B1 = new Bitmap("bas2.png");
            Bitmap B2 = new Bitmap("mch.png");
            if (N==1)
            {
                 a = "Забрось мячь в нужную корзину";
                 B = new Bitmap("bas1.png");
                 B1 = new Bitmap("bas2.png");
                 B2 = new Bitmap("mch.png");                       
            }
            if (N == 2)
            {
                a = "Собери цветы в корзину";
                 B = new Bitmap("33.png");
                 B1 = new Bitmap("3.png");
                 B2 = new Bitmap("fl.png");
            }
            if (N == 3)
            {
                a = "Выпусти рыбок в пруд";
                B = new Bitmap("44.png");
                 B1 = new Bitmap("4.png");
                 B2 = new Bitmap("444.png");
            }
            if (N == 4)
            {
                a = "Помоги пчелкам добраться до улья";
                B = new Bitmap("2.png");
                B1 = new Bitmap("22.png");
                B2 = new Bitmap("bz.png");
            }
            sounddistribution.label1.Text = a;
            sounddistribution.pictureBox1.BackgroundImage = B;           
            sounddistribution.pictureBox2.BackgroundImage = B1;          
            sounddistribution.pictureBox3.BackgroundImage = B2;
            sounddistribution.Show();
        }
           /* public WhereSound()
        {
            InitializeComponent();
            
            /*this.label1.BackColor = System.Drawing.Color.Transparent;
            

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
        }*/
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
                           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
           // SoundDistribution sounddistribution = new SoundDistribution();
           // sounddistribution.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GameTheme gametheme = new GameTheme();
            gametheme.Show();
        }
    }
}
