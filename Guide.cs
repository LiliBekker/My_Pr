using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoicedAndDeafConsonants
{
    public partial class Guide : Form
    {
        public Guide()
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
        }

        private void Guide_Load(object sender, EventArgs e)
        {

        }

        private  void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Theory theory = new Theory();
            theory.Show();
            theory.label1.Text = "Что такое звук?";
           
            StreamReader reader = new StreamReader("1.txt");
            string result = reader.ReadToEnd();
            int i = theory.richTextBox1.SelectionStart;
            theory.richTextBox1.Text += "";         
            theory.richTextBox1.AppendText(result);
            theory.richTextBox1.SelectionStart = i;
            reader.Close();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Theory theory = new Theory();
            theory.Show();
            theory.label1.Text = "Звонкие и глухие согласные";
            StreamReader reader = new StreamReader("2.txt");
            string result = reader.ReadToEnd();
            int i = theory.richTextBox1.SelectionStart;
            theory.richTextBox1.Text += "";
            theory.richTextBox1.AppendText(result);
            theory.richTextBox1.SelectionStart = i;
            reader.Close();
        }


            private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Theory theory = new Theory();
            theory.Show();
            theory.label1.Text = "Парные и непарные согласные";
            StreamReader reader = new StreamReader("3.txt");
            string result = reader.ReadToEnd();
            int i = theory.richTextBox1.SelectionStart;
            theory.richTextBox1.Text += "";
            theory.richTextBox1.AppendText(result);
            theory.richTextBox1.SelectionStart = i;
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Theory theory = new Theory();
            theory.Show();
            theory.label1.Text = "Твердые и мягкие согласные";
            StreamReader reader = new StreamReader("4.txt");
            string result = reader.ReadToEnd();
            int i = theory.richTextBox1.SelectionStart;
            theory.richTextBox1.Text += "";
            theory.richTextBox1.AppendText(result);
            theory.richTextBox1.SelectionStart = i;
            reader.Close();
        }
    }
}
