using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Int64 factor_answer = 1;
                if (!Int64.TryParse(inputbox.Text, out Int64 number) || number < 0 || number>24)
                {
                    answer.Text = "Please enter a valid non-negative integer or < 24.";
                    return;
                }

                do
                {
                    factor_answer *= number;
                    number--;
                }
                while (number > 0);

                answer.Text = $"{factor_answer}";

               
            }
            catch 
            {
                answer.Text = $"Error";            }

            
         
                
        }
    }
}
