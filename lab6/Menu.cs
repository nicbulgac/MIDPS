using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Runtime.InteropServices;

namespace _1010alfa
{
    public partial class Menu : Form
    {        
        public Menu()
        {
            InitializeComponent();
            SetCursor();
        }

        Game f = new Game();        
       
        private void Menu_Load(object sender, EventArgs e)
        {
            panel1.Top = panel1.Height * -1;            
            System.IO.StreamWriter sr1 = new System.IO.StreamWriter(System.IO.File.Open("name.txt", System.IO.FileMode.Create, System.IO.FileAccess.Write));
            {
                sr1.WriteLine(textBox1.Text);
                sr1.Close();
            }

            System.IO.StreamReader sr = new System.IO.StreamReader(System.IO.File.Open("score.txt", System.IO.FileMode.Open, System.IO.FileAccess.Read));
            label1.Text = sr.ReadLine();
            sr.Close();

            listBox1.Items.Clear();
            System.IO.StreamReader sr3 = new System.IO.StreamReader(System.IO.File.Open("champions.txt", System.IO.FileMode.Open));
            {
                string s = sr3.ReadLine();
                while (s != null)
                {
                    listBox1.Items.Add(s);
                    s = sr3.ReadLine();
                }
                sr3.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {            
            this.Hide();
            f.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (f.voice == true)
            {
                f.voice = false;
                pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + @"\\images\\voise_off.png");
            }
            else
            {
                f.voice = true;
                pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + @"\\images\\voise_on.png");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (f.day_night == true)
            {
                f.day_night = false;
                this.BackColor = Color.White;
                label1.ForeColor = Color.SeaGreen;
            }
            else
            {
                label1.ForeColor = Color.White;
                f.day_night = true;
                this.BackColor = Color.Gray;                
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        bool a = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Top = panel1.Top + 20;
            if (panel1.Top >= 100 && a == true)
            {
                timer1.Stop();
                a = false;
            }
            if (panel1.Top >= this.Height)
            {
                timer1.Stop();
                a = true;
                panel1.Top = panel1.Height * -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.IO.StreamWriter sr1 = new System.IO.StreamWriter(System.IO.File.Open("name.txt", System.IO.FileMode.Create, System.IO.FileAccess.Write));
            {
                sr1.WriteLine(textBox1.Text);
                sr1.Close();
            }
        }

        [DllImport("User32.dll")]
        private static extern IntPtr LoadCursorFromFile(String str);
        IntPtr hCursor;

        public void SetCursor()
        {
            hCursor = LoadCursorFromFile(Application.StartupPath + "\\amaya-arrow.cur");
            this.Cursor = new Cursor(hCursor);
            pictureBox3.Cursor = new Cursor(hCursor);
            label1.Cursor = new Cursor(hCursor);
            button2.Cursor = new Cursor(hCursor);
            button1.Cursor = new Cursor(hCursor);
            pictureBox1.Cursor = new Cursor(hCursor);
            pictureBox4.Cursor = new Cursor(hCursor); 
            pictureBox5.Cursor = new Cursor(hCursor);
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
