using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            int x = 3;
            while (x > 0)
            {

                if (x > 2)
                {
                    result = result + "a";
                }

                x = x - 1;
                result = result + "-";

                if (x == 2)
                {
                    result = result + "b c";
                }

                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }


            }
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Result = "";
            int x = 3;
            while (x > 0)
            {
                if (x > 2)
                {
                    Result = Result + "a";
                }
                x = x - 1;
                Result = Result + "-";
                if (x == 1)
                {
                    Result = Result + "d";
                    x = x - 1;
                }
                if (x == 2)
                {
                    Result = Result + "b c";
                }

            }
            MessageBox.Show(Result);
        }
    }
}