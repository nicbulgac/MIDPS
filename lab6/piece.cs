using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _1010alfa
{
    class piece
    {
       
        public string[] form;
        public Bitmap color;
        public Boolean visible;
        public int complexity = 6;
        
        string[] form1 = new string[5] 
                                   {"00000", 
                                    "00000",
                                    "00100",
                                    "00000",
                                    "00000"};

        string[] form2 = new string[5] 
                                   {"00000", 
                                    "00000",
                                    "00110",
                                    "00000",
                                    "00000"};

        string[] form3 = new string[5] 
                                   {"00000", 
                                    "00100",
                                    "00100",
                                    "00000",
                                    "00000"};

        string[] form4 = new string[5] 
                                   {"00000", 
                                    "00100",
                                    "00100",
                                    "00100",
                                    "00000"};
        string[] form5 = new string[5] 
                                   {"00000", 
                                    "00000",
                                    "01110",
                                    "00000",
                                    "00000"};

        string[] form6 = new string[5] 
                                   {"00100", 
                                    "00100",
                                    "00100",
                                    "00100",
                                    "00000"};
        string[] form7 = new string[5] 
                                   {"00000", 
                                    "00000",
                                    "11110",
                                    "00000",
                                    "00000"};

        string[] form8 = new string[5] 
                                   {"00100", 
                                    "00100",
                                    "00100",
                                    "00100",
                                    "00100"};
        string[] form9 = new string[5] 
                                   {"00000", 
                                    "00000",
                                    "11111",
                                    "00000",
                                    "00000"};

        string[] form10 = new string[5] 
                                   {"00000", 
                                    "01000",
                                    "01100",
                                    "00000",
                                    "00000"};
        string[] form11 = new string[5] 
                                   {"00000", 
                                    "01100",
                                    "00100",
                                    "00000",
                                    "00000"};

        string[] form12 = new string[5] 
                                   {"00000", 
                                    "01100",
                                    "01100",
                                    "00000",
                                    "00000"};

        string[] form13 = new string[5] 
                                   {"01000", 
                                    "01000",
                                    "01110",
                                    "00000",
                                    "00000"};
        string[] form14 = new string[5] 
                                   {"00000", 
                                    "00000",
                                    "01110",
                                    "01000",
                                    "01000"};
        string[] form15 = new string[5] 
                                   {"00000",
                                    "00000", 
                                    "01110",
                                    "00010",                                    
                                    "00010"};
        string[] form16 = new string[5] 
                                   {"00000",
                                    "00010", 
                                    "00010",
                                    "01110",
                                    "00000"};


        string[] form17 = new string[5] 
                                   {"00000",
                                    "00100", 
                                    "01110",
                                    "00000",
                                    "00000"};
        string[] form18 = new string[5] 
                                   {"00000",
                                    "00000", 
                                    "01110",
                                    "00100",
                                    "00000"};
        string[] form19 = new string[5] 
                                   {"00000",
                                    "00100", 
                                    "01110",
                                    "00100",
                                    "00000"};

        string[] form20 = new string[5] 
                                   {"00000",
                                    "01110", 
                                    "01110",
                                    "01110",
                                    "00000"};

        string[] form21 = new string[5] 
                                   {"00000",
                                    "01000", 
                                    "00100",
                                    "00010",
                                    "00000"};
        string[] form22 = new string[5] 
                                   {"00000",
                                    "00010", 
                                    "00100",
                                    "01000",
                                    "00000"};
        public void get_piece()
        {
            visible = true;
            int a;
            Random rand = new Random();
            if (complexity >= 22)
            {
                a = rand.Next(1, 22);                
            }
            else
            {
                a = rand.Next(1, complexity);    
            }                              
            
            switch (a)
            {
                case 1:
                    form = form1;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\1.png"));
                    break;
                case 2:
                    form = form2;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\2.png"));
                    break;
                case 3:
                    form = form3;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\2.png"));
                    break;
                case 4:
                    form = form4;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\3.png"));
                    break;
                case 5:
                    form = form5;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\3.png"));
                    break;
                case 6:
                    form = form6;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\4.png"));
                    break;
                case 7:
                    form = form7;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\4.png"));
                    break;
                case 8:
                    form = form8;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\5.png"));
                    break;
                case 9:
                    form = form9;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\5.png"));
                    break;
                case 10:
                    form = form10;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\3angel.png"));
                    break;
                case 11:
                    form = form10;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\3angel.png"));
                    break;
                case 12:
                    form = form11;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\4rec.png"));
                    break;
                case 13:
                    form = form12;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\5angel.png"));
                    break;
                case 14:
                    form = form13;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\5angel.png"));
                    break;
                case 15:
                    form = form14;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\5angel.png"));
                    break;
                case 16:
                    form = form15;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\5angel.png"));
                    break;
                    
                case 17:
                    form = form16;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\d1.png"));
                    break;
                case 18:
                    form = form17;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\d1.png"));
                    break;
                case 19:
                    form = form18;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\d1.png"));
                    break;
                case 20:
                    form = form19;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\4rec.png"));
                    break;
                case 21:
                    form = form20;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\d2.png"));
                    break;
                case 22:
                    form = form21;
                    color = new Bitmap(Image.FromFile(Application.StartupPath + @"\images\d2.png"));
                    break; 
            }
        }
    }
}
