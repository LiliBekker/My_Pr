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
    public partial class Theory : Form
    {
        public Theory()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
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
           
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guide guide = new Guide();
            guide.Show();
        }

        private void Theory_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
