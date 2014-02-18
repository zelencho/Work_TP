using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looopyloops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = {"Krasi", "James", "Bob" };
            foreach(string s in names)
            {
                MessageBox.Show(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
         /*  while(i < 10)
            {
                textBox1.Text += i.ToString(); // this will print the numbers form 0 to 9
                i++;
            }*/
            do
            {
                textBox1.Text += i.ToString();
                i++;
            }
            while (i < 10);
        }
    }
}
