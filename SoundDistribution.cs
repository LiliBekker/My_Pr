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
    public partial class SoundDistribution : Form
    {
       public SoundDistribution()
        {
            InitializeComponent();
            
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox3;
            label2.SetBounds(23, 20, -1, -1);
            label2.ForeColor = Color.Black;
            Bitmap B3 = new Bitmap("gl.png");
            this.pictureBox4.BackgroundImage = B3;
          
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            WhereSound wheresound = new WhereSound(0);
            wheresound.Show();
        }

        private void SoundDistribution_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
