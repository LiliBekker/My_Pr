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
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
            
            this.label1.BackColor = System.Drawing.Color.Transparent;
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
        private void buttonLev1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypeLevel.level = 1;
            Game sounddistribution = new Game();
            sounddistribution.Show();
        }

        private void buttonLev2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypeLevel.level = 2;
            Game sounddistribution = new Game();
            sounddistribution.Show();
        }

        private void buttonLev3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypeLevel.level = 3;
            Game sounddistribution = new Game();
            sounddistribution.Show();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GameTheme gametheme = new GameTheme();
            gametheme.Show();
        }

        private void Levels_Load(object sender, EventArgs e)
        {

        }
    }
}
