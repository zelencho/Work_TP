using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Collections;

namespace HalifaxChar
{
    public partial class Form1 : Form
    {
        public string str = "1je4na";
       
    //    public  char[] charListArray = new char[2];

       public int getStrLenght()
        {        
            int len = str.Length;
            return len;
        }
         public void randomNumbers()
        {
            Random rnd = new Random();
            int ranNum;

            int[] randomCharPositions = new int[3];

            for (int i = 0;  i < randomCharPositions.Length; i++)
            {
                ranNum = rnd.Next(1, getStrLenght() + 1); // the 1 should ensure that the Random number is not 0
                                                         // the + 1 should ensure that the value from the lenght is taken
                randomCharPositions[i] = ranNum;
                if (randomCharPositions[i] > 0 && randomCharPositions[i - 1] == ranNum) i--;
            }
             
             // need to ensure that the values in the array are unique
            var allSame = Array.TrueForAll(randomCharPositions, x => x == randomCharPositions[0]);

            if(allSame)
            {
                MessageBox.Show("Values in the array are the same. Need to rerun");
                randomNumbers();
            }
            else
            {
                charOne.Text = randomCharPositions[0].ToString();
                charTwo.Text = randomCharPositions[1].ToString();
                charThree.Text = randomCharPositions[2].ToString();
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            randomNumbers();
        }
    }
}
