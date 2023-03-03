using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciselneSoustavy05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dec = int.Parse(textBox1.Text);
            MessageBox.Show("Binární číslo je: " + DecToBin(dec));
        }
        static private string DecToBin(int decimalniCislo)
        {
            string bin = "";
            while(decimalniCislo > 0)
            {
                if (decimalniCislo % 2 == 0) bin = "0" + bin;
                else bin = "1" + bin;
                decimalniCislo/=2;
            }
            return bin;
        }
    }
}
