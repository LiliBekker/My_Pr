using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace VoicedAndDeafConsonants
{
    public partial class Game : Form
    {
        XmlDocument doc = new XmlDocument();
        List<int> list = new List<int>();

        public Game()
        {
            InitializeComponent();

            FormClosing += Form_FormClosing;

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


        private void SoundDistribution_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            buttonSound.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;


            label2.Parent = pictureBox3;
            label2.SetBounds(0, 0, 130, 130);
            label2.TextAlign = ContentAlignment.MiddleCenter;
            pictureBox4.Visible = false;

            label2.ForeColor = Color.Black;
            Bitmap B3 = new Bitmap("gl.png");
            this.pictureBox4.BackgroundImage = B3;

            label1.Text = Theme.str;
            this.pictureBox1.BackgroundImage = Theme.bitmap1;
            this.pictureBox2.BackgroundImage = Theme.bitmap2;
            this.pictureBox3.BackgroundImage = Theme.bitmap3;
            pictureBox3.BackColor = Color.Transparent;//transparent. Устанавливает прозрачный фон

            buttonSound.Visible = false;
            doc.Load("XMLSounds.xml");
            if ((TypeLevel.type == 2)|| (TypeLevel.type == 3))
            {
                list.Add(5);//ж
                list.Add(17);//ц
                list.Add(18);//ш
            }
            Type(TypeLevel.type);
            Lev(TypeLevel.level);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (label2.BorderStyle == BorderStyle.FixedSingle)
            {
                foreach (XmlNode node in doc.DocumentElement)
                {
                    if (label2.Text.Substring(1, 1) == node.Attributes["sound"].Value)
                    {
                        if (((!bool.Parse(node["Sonority"].InnerText)) && (pictureBox1.BackgroundImage == Theme.bitmap1)) || ((bool.Parse(node["Sonority"].InnerText)) && (pictureBox1.BackgroundImage == Theme.bitmap2)))
                        {
                            Bitmap bitmap = new Bitmap("gl.png");
                            PictureOkError(bitmap, true);
                        }
                        else
                        {
                            Bitmap bitmap1 = new Bitmap("kr.png");
                            PictureOkError(bitmap1, false);
                        }
                    }
                }
            }
            label2.BorderStyle = BorderStyle.None;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (label2.BorderStyle == BorderStyle.FixedSingle)
            {
                foreach (XmlNode node in doc.DocumentElement)
                {
                    if (label2.Text.Substring(1, 1) == node.Attributes["sound"].Value)
                    {
                        if (((bool.Parse(node["Sonority"].InnerText)) && (pictureBox2.BackgroundImage == Theme.bitmap2)) || ((!bool.Parse(node["Sonority"].InnerText)) && (pictureBox2.BackgroundImage == Theme.bitmap1)))
                        {
                            Bitmap bitmap = new Bitmap("gl.png");
                            PictureOkError(bitmap, true);
                        }
                        else
                        {
                            Bitmap bitmap1 = new Bitmap("kr.png");
                            PictureOkError(bitmap1, false);
                        }
                    }
                }
                label2.BorderStyle = BorderStyle.None;
            }
        }

        private void PictureOkError(Bitmap bitmap, bool ok)
        {
            pictureBox4.BackgroundImage = bitmap;
            pictureBox4.Visible = true;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (x, y) => { timerTick(x, ok); };
            timer.Start();
        }
        void timerTick(object sender, bool ok)//Действия которые происходят по истечении 3 секунд
        {
            pictureBox4.Visible = false;
            ((Timer)sender).Stop();
            if (ok)
            {
                Type(TypeLevel.type);
                Lev(TypeLevel.level);
            }
        }

        private void Play(XmlDocument doc, List<int> arr, int t)
        {
            switch (t)
            {
                case 1:
                    {
                        if (list.Count == 17)
                        {
                            list.Clear();
                            GoodJob goodJob = new GoodJob();
                            goodJob.ShowDialog();
                            if (TypeLevel.level == 4)
                            {
                                this.Hide();
                                Levels levels = new Levels();
                                levels.Show();
                            }
                        }
                        int randval = RandomFromRangeWithExceptions(1, 18, list);
                        list.Add(randval);
                        OutLetter("", randval);
                        t = TypeLevel.type;
                        break;
                    }
                case 2:
                    {
                        if (list.Count == 20)//попробовать 21
                        {
                            list.Clear();
                            GoodJob goodJob = new GoodJob();
                            goodJob.ShowDialog();
                        }
                        int randval = RandomFromRangeWithExceptions(1, 21, list);
                        list.Add(randval);
                        OutLetter("'", randval);
                        t = TypeLevel.type;
                        break;
                    }
                default: break;
            }

        }

        private void OutLetter(string soft, int randvalue)//exclude -- список чисел которые НЕ должны входить в результат
        {
            foreach (XmlNode node in doc.DocumentElement)
            {
                if (randvalue == int.Parse(node["Numder"].InnerText))
                    label2.Text = "[" + node.Attributes["sound"].Value + soft + "]";
            }
        }

        private int RandomFromRangeWithExceptions(int rangeMin, int rangeMax, List<int> exclude)//exclude -- список чисел которые НЕ должны входить в результат
        {
            var _rand = new Random();
            var range = Enumerable.Range(rangeMin, rangeMax).Where(i => !exclude.Contains(i));//создаем  колекцию допустимых значений

            int index = _rand.Next(rangeMin, rangeMax - exclude.Count());//генерируем индекс ячейки
            return range.ElementAt(index);//возвращаем значение ячейки
        }

        private int Type(int t)
        {
            switch (t)
            {
                case 1:
                    {
                        Play(doc, list, t);
                        break;
                    }
                case 2:
                    {
                        Play(doc, list, t);
                        break;
                    }
                case 3:
                    {
                        Random rnd = new Random();
                        t = rnd.Next(1, 3);
                        Play(doc, list, t);
                        break;
                    }
                default: break;
            }
            return t;
        }

        private int Lev(int t)
        {
            switch (t)
            {
                case 1:
                    {
                        pictureBox1.BackgroundImage = Theme.bitmap1;
                        pictureBox2.BackgroundImage = Theme.bitmap2;
                        buttonSound.Visible = true;
                        SoundPlay();
                        break;
                    }
                case 2:
                    {
                        RandPicture();
                        buttonSound.Visible = true;
                        SoundPlay();
                        break;
                    }
                case 3:
                    {
                        RandPicture();
                        break;
                    }
                default: break;
            }
            return t;
        }

        private void RandPicture()
        {
            Random rnd = new Random();
            int xe = rnd.Next(1, 3);
            switch (xe)
            {
                case 1:
                    {
                        pictureBox1.BackgroundImage = Theme.bitmap1;
                        pictureBox2.BackgroundImage = Theme.bitmap2;
                        break;
                    }
                case 2:
                    {
                        pictureBox1.BackgroundImage = Theme.bitmap2;
                        pictureBox2.BackgroundImage = Theme.bitmap1;
                        break;
                    }
                default: break;
            }
        }

        private void SoundPlay()
        {
            string path;
            foreach (XmlNode node in doc.DocumentElement)
            {
                if (label2.Text.Substring(1, 1) == node.Attributes["sound"].Value)
                {
                    if ((label2.Text.Substring(2, 1) == "'") && ((node.Attributes["sound"].Value != "Й")) && (node.Attributes["sound"].Value != "Ч") && (node.Attributes["sound"].Value != "Щ"))
                        path = Application.StartupPath + "\\Звуки\\" + node.Attributes["sound"].Value + "1.wav";
                    else
                        path = Application.StartupPath + "\\Звуки\\" + node.Attributes["sound"].Value + ".wav";

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
                    player.Play();
                }
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)//кнопка назад
        {
            this.Hide();
            Levels levels = new Levels();
            levels.Show();
        }

        private void buttonSound_Click(object sender, EventArgs e)
        {
            SoundPlay();
        }
                       
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}