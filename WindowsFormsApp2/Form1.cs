using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numder = 15;
            numder = numder + 10;
            numder = 36 * 15;
            numder = 12 - (42 / 7);
            numder += 10;
            numder *= 3;
            numder = 71 / 3;

            int count = 0;
            count ++;
            count --;

            String result = "hello";
            result += " again " + result;
            MessageBox.Show(result);
            result = "the value is: " + count;
            result = "";

            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !!!anotherBool;
        }
    }
}
