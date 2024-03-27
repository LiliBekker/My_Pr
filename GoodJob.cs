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
    public partial class GoodJob : Form
    {
        public GoodJob()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
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

        private void GoodJob_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TypeLevel.level = 4;
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}
