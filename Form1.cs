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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
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

            this.label1.BackColor = System.Drawing.Color.Transparent;
            SizeChanged += (sender, args) =>
            {
                var y = this.Height - label1.Height;
               // label1.Location = new Point(y/2, y/4);
               // label1.Size = new Size(ClientSize.Width, ClientSize.Height);
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exit exit = new Exit();
            exit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameSelection gameselection = new GameSelection();
            gameselection.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guide guide = new Guide();
            guide.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
