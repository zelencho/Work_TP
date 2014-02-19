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
        int[] randomCharPositions = new int[3];
       
    //    public  char[] charListArray = new char[2];

       public int getStrLenght()
        {        
            int len = str.Length;
            return len;
        }
         public void randomNumbers()
        {
           
                // compare the random numbers to the values entered by the user

               randomCharPositions[0] = str[0];
                randomCharPositions[1] = str[1];
                randomCharPositions[2] = str[2];

               char one = Convert.ToChar(comboBoxCharOne.SelectedItem);
               char two = Convert.ToChar(comboBoxCharTwo.SelectedItem);
               char three = Convert.ToChar(comboBoxCharThree.SelectedItem);

                if (randomCharPositions[0] == one && randomCharPositions[1] == two && randomCharPositions[2] == three)
                {
                    MessageBox.Show("Well Done!!!",  "Perfect Match.");
                }
                else
                {
                    MessageBox.Show("The entered characters do not exist!! /n Please try again.");
                    onFormLoad();
                }
        }

         /* public void getChars(char one, char two, char three)
         {
             one = Convert.ToChar(comboBoxCharOne.Text);
             two = Convert.ToChar(comboBoxCharTwo.Text);
             three = Convert.ToChar(comboBoxCharThree);

             for (int i = 0; i < getStrLenght(); i++)
             {
                 one = str[i];
             }
         } */

         public Form1()
        {
            InitializeComponent();
            onFormLoad();
         }
         public void cleanEnteredComboBoxValues()
         {
             comboBoxCharOne.Text = " ";
             comboBoxCharTwo.Text = " ";
             comboBoxCharThree.Text = " ";
         }
        public void onFormLoad()
        {
            Random rnd = new Random();
            int ranNum;

            for (int i = 0; i < randomCharPositions.Length; i++)
            {
                ranNum = rnd.Next(1, getStrLenght() + 1); // the 1 should ensure that the Random number is not 0
                // the + 1 should ensure that the value from the lenght is taken
                randomCharPositions[i] = ranNum;
                if (i > 0 && randomCharPositions[i - 1] == ranNum)
                {
                    i--;
                    continue;
                }
            }
            // assign the random numbers to the labels
            charOne.Text = randomCharPositions[0].ToString();
            charTwo.Text = randomCharPositions[1].ToString();
            charThree.Text = randomCharPositions[2].ToString();

            cleanEnteredComboBoxValues();
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
