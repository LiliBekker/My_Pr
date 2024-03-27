using System;
using System.Drawing;
using System.Windows.Forms;

namespace VoicedAndDeafConsonants
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            foreach (var item in Controls) //обходим все элементы формы
            {
                if (item is Button) // проверяем, что это кнопка
                {
                    ((Button)item).BackColor = Color.Transparent;
                    ((Button)item).FlatAppearance.BorderSize = 0;
                    ((Button)item).FlatStyle = FlatStyle.Flat;
                    ((Button)item).FlatAppearance.MouseDownBackColor = Color.Transparent;
                    ((Button)item).FlatAppearance.MouseOverBackColor = Color.Transparent;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
