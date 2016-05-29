using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        core mycore = new core();

        // C
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            
            mycore.clear();

        }

        // CE
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            mycore.clear_all();
        }

        // +-
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                double val = mycore.inversare_semn(textBox1.Text);
                textBox1.Text = " " + val;
            }
        }

        // backspace
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                string val = mycore.backspace(textBox1.Text);
                textBox1.Text = val;
            }
            
        }

        // 7
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        //8
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        //9
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        //4
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        //5
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        //6
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        //1
        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        //2
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        //3
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        //0
        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        // , 
        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + "0,";
            }
            else {
                if (mycore.virg == 0) {
                    textBox1.Text = textBox1.Text + ",";
                    mycore.virg = 1;
                }
            }
        }


        // +
        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double val = mycore.adunare(textBox1.Text);
                label1.Text = "" + val + "+";
                //label1.Text = label1.Text + textBox1.Text + "+";
                textBox1.Text ="";
            }
            if (textBox1.Text == "" &&( mycore.oper != 0 || mycore.oper==1))
            {

                mycore.oper = 1;
                label1.Text = "" + mycore.result + "+";
                textBox1.Text = "";
            }
        }

        //-
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double val = mycore.scadere(textBox1.Text);
                label1.Text = "" + val + "-";
                textBox1.Text = "";
            }
            if (textBox1.Text == "" && (mycore.oper != 0 || mycore.oper==2))
            {
                mycore.oper = 2;
                label1.Text = "" + mycore.result + "-";
                textBox1.Text = "";
            }
        }

        //*
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double val = mycore.inmultire(textBox1.Text);
                label1.Text = "" + val + "*";
                textBox1.Text = "";
            }
            if (textBox1.Text == "" && ( mycore.oper != 0 || mycore.oper==3))
            {
                mycore.oper = 3;
                label1.Text = "" + mycore.result + "*";
                textBox1.Text = "";
            }
        }

        // /
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double val = mycore.impartire(textBox1.Text);
                label1.Text = "" + val + "/";
                textBox1.Text = "";
            }
            if (textBox1.Text == "" && ( mycore.oper != 0 || mycore.oper==4))
            {
                mycore.oper = 4;
                label1.Text = "" + mycore.result + "/";
                textBox1.Text = "";
            }
        }

        // pow
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double val = mycore.putere(textBox1.Text);
                label1.Text = "" + val + "^";
                textBox1.Text = "";
            }
            if (textBox1.Text == "" && (  mycore.oper != 0 || mycore.oper==5))
            {
                mycore.oper = 5;
                label1.Text = "" + mycore.result + "^";
                textBox1.Text = "";
            }
        }

        // sqrt
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double val = mycore.radical(textBox1.Text);
                label1.Text = "√(" + textBox1.Text + ")";
                textBox1.Text = "" + val;
            }
            if (textBox1.Text == "" && ( mycore.oper != 0 || mycore.oper==6))
            {
                mycore.oper = 6;
                label1.Text = "√(" + mycore.result + ")";
                textBox1.Text = "";
            }
        }

        // egal
        private void button16_Click(object sender, EventArgs e)
        {
            double val;

            if (textBox1.Text != "")
            {
                if (mycore.is_set==0) {
                    mycore.operand = double.Parse(textBox1.Text);
                    mycore.is_set = 1;
                } 

                val = mycore.egal();
                
                label1.Text = " ";
                textBox1.Text = " " + val;
            }
            
        }

        // ------------------------------------------------------------------------------------
        // keyboard events
        // ------------------------------------------------------------------------------------

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            switch ((int)e.KeyChar) { 
                case 108:
                    button16.PerformClick();
                    break;

                case 107:
                    button22.PerformClick();
                    break;

                case 105:
                    button17.PerformClick();
                    break;

                case 100:
                    button12.PerformClick();
                    break;

                case 95:
                    button7.PerformClick();
                    break;
            }
           
        }

    }
    
}
