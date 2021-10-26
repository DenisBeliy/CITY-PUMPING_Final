using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace city_pumping
{
    public partial class tree_nuke : Form
    {
        public static FileStream stream_sheep = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "sheep" + ".d&d", FileMode.OpenOrCreate);

        public tree_nuke()
        {
            stream_sheep.Close();          
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Orange;

            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Orange;

            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;

            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Orange;

            pictureBox4.Parent = pictureBox1;
            pictureBox4.BackColor = Color.Transparent;

            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Orange;

            pictureBox5.Parent = pictureBox1;
            pictureBox5.BackColor = Color.Transparent;

        }
        public static SoundPlayer Back_Player = new SoundPlayer("текстовые файлы\\наука.wav");
                
        public static int a;
        private void label1_Click(object sender, EventArgs e)
        {

        }
  
                private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = a.ToString();
            /*FileStream stream_scientist = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_scientist_residents" + ".d&d", FileMode.OpenOrCreate);

            StreamReader reader = new StreamReader(stream_scientist);

            a = int.Parse(reader.ReadLine());

            reader.Close();
            stream_scientist.Close();
*/
            if (a == 1)
            {
                pictureBox2.Image = Properties.Resources.кувшин;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
                

            /*          FileStream stream_scientist = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_scientist_residents" + ".d&d", FileMode.OpenOrCreate);

                        StreamWriter reader = new StreamWriter(stream_scientist);
                        int a = 0;
                        a++;
                        reader.Write("21");

                        reader.Close();
                        stream_scientist.Close();*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(File.ReadAllText(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_scientist_residents" + ".d&d"));
            }
            catch { a = 1; }
                label4.Text = Accounting_resources.uchonaya_mana.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (a >= 1)
            {

                pictureBox2.Image = Properties.Resources.кувшин;
        
                pictureBox4.Visible = true;
                pictureBox2.Enabled = false;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "вход";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "выход";
           
        }

      
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (a >= 1)
            {
                pictureBox3.Image = Properties.Resources.овцы;
                FileStream stream_sheep_pictureBox3 = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "sheep" + ".d&d", FileMode.OpenOrCreate);
                StreamWriter writer_sheep_pictureBox3 = new StreamWriter(stream_sheep_pictureBox3);

                writer_sheep_pictureBox3.Write("3");

                writer_sheep_pictureBox3.Close();
                stream_sheep_pictureBox3.Close();

                 pictureBox2.Visible = true;
                pictureBox3.Enabled = false;
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "вход2";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "выход2";
        }

        private void tree_nuke_Load(object sender, EventArgs e)
        {
            label4.Text = Accounting_resources.uchonaya_mana.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (a >= 1)
            {
                pictureBox4.Image = Properties.Resources.кирка;
        
                pictureBox5.Visible = true;
                pictureBox4.Enabled = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (a >= 1)
            {
                pictureBox5.Image = Properties.Resources.солнце;
   
                /*pictureBox5.Visible = true;*/
                pictureBox5.Enabled = false;
            }
        }
    }
}
