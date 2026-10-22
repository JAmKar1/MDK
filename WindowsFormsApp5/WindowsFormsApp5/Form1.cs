using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
//cccbbbc
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string text = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text += "b";
            string result = text.Length >= 7 ? text.Substring(text.Length - 7) : text;
            if (result == "cccbbbc")
            {
                if (label1.BackColor == Color.Red)
                {
                    label1.BackColor = Color.Blue;
                }
                else
                {
                    label1.BackColor = Color.Red;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            text += "c";
            string result = text.Length >= 7 ? text.Substring(text.Length - 7) : text;
            if (result == "cccbbbc")
            {
                if (label1.BackColor == Color.Red)
                {
                    label1.BackColor = Color.Blue;
                }
                else
                {
                    label1.BackColor = Color.Red;
                }
            }
        }
    }
}
