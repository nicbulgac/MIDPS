using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public class core
    {
        
        
        public double result = 0;
        public double operand = 0;

        public int oper = 0;
        public int is_set = 0;
        public int is_egal = 0;
        public int virg = 0;

        public void clear() {
            operand = 0;
            virg = 0;
        }
        public void clear_all() {
            result = 0;
            operand = 0;
            oper = 0;
            virg = 0;

        }

        public double adunare(string val) {
            is_set = 0;
            double number = double.Parse(val);
            

            if (result == 0 || is_egal == 1){
                result = number;
            }
            else {
                operand = number;
                egal();
            }

            oper = 1;
            is_egal = 0;
            return result;
        }

        public double scadere(string val){
            is_set = 0;
            double number = double.Parse(val);


            if (result == 0 || is_egal == 1)
            {
                result = number;
            }
            else
            {
                operand = number;
                egal();
            }

            oper = 2;
            is_egal = 0;
            return result;
        }


        public double inmultire(string val){
            is_set = 0;
            double number = double.Parse(val);


            if (result == 0 || is_egal == 1)
            {
                result = number;
            }
            else
            {
                operand = number;
                egal();
            }

            oper = 3;
            is_egal = 0;
            return result;
        }

        public double impartire(string val){
            is_set = 0;
            double number = double.Parse(val);


            if (result == 0 || is_egal == 1)
            {
                result = number;
            }
            else
            {
                operand = number;
                egal();
            }

            oper = 4;
            is_egal = 0;
            return result;
        }


        public double putere(string val){
            is_set = 0;
            double number = double.Parse(val);


            if (result == 0 || is_egal == 1)
            {
                result = number;
            }
            else
            {
                operand = number;
                egal();
            }

            oper = 5;
            is_egal = 0;
            return result;
        }

        public double radical(string val){
            double number = double.Parse(val);

            oper = 6;
            result = Math.Sqrt(number);

            return result;
        }


        

        public double egal()
        {
            
            switch (oper)
            {
                case 0:
                    break;
                case 1:
                    result = result + operand;
                    break;
                case 2:
                    result = result - operand;
                    break;
                case 3:
                    result = result * operand;
                    break;
                case 4:
                    result = result / operand;
                    break;
                case 5:
                    result = Math.Pow(result,operand);
                    break;
                case 6:
                    result = Math.Sqrt(result);
                    break;

            }

            is_egal = 1;
            return result;
        }


        public double inversare_semn(string  val)
        {
           
            double number = double.Parse(val);
            number = number * -1;

            return number;
        }

        public string backspace(string val) {
           

            string res;
            int number = val.Count();

            
                if (number != 0)
                {
                    res = val.Substring(0, number - 1);
                }
                else
                {
                    res = " ";
                }
            
            return res;
        }


    }
    
    
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
        
    }
    
}
