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
    public partial class GameType : Form
    {       

        public GameType()
        {
            InitializeComponent();
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.FormClosing += Form_FormClosing;
            InitializeComponent();
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
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
        }              

        private void buttonHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypeLevel.type = 1;
            GameTheme gametheme = new GameTheme();
            gametheme.Show();
        }

        private void buttonSoft_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypeLevel.type = 2;
            GameTheme gametheme = new GameTheme();
            gametheme.Show();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypeLevel.type = 3;
            GameTheme gametheme = new GameTheme();
            gametheme.Show();
        }
        
    }
}
