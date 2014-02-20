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
        public string str = " 1je4na"; // add space to set str[0] = nothing and no need to select 0
       // public  int[] randomCharPositions = new int[3];
        int lblCharOneValue, lblCharTwoValue, lblCharThreeValue;

       public int getStrLenght()
        {        
            int len = str.Length;
            return len;
        }
         public void runInputCharCheck()
        {
                //get the userinput from the drop down boxes and convert them to chars as default for comboBox is string
               char one = Convert.ToChar(comboBoxCharOne.SelectedItem);
               char two = Convert.ToChar(comboBoxCharTwo.SelectedItem);
               char three = Convert.ToChar(comboBoxCharThree.SelectedItem);

               //get the randomly generated numbers and pull the exact char from the str string
               lblCharOneValue = Convert.ToInt16(charOne.Text);
               lblCharTwoValue = Convert.ToInt16(charTwo.Text);
               lblCharThreeValue = Convert.ToInt16(charThree.Text);
             
               // compare the random numbers to the values entered by the user
               if (str[lblCharOneValue] == one && str[lblCharTwoValue] == two && str[lblCharThreeValue] == three)
                {
                   DialogResult dialogYesNoFeedback = MessageBox.Show("Well Done!!!" + "\n" + "Would you like to try again?",  "Perfect Match.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    
                   if(dialogYesNoFeedback == DialogResult.Yes)
                   {
                       onFormLoad();
                   }
                   else if(dialogYesNoFeedback == DialogResult.No)
                   {
                       Environment.Exit(1);
                   }
                }
                else
                {
                    DialogResult retryCancelDialogFeedback = MessageBox.Show("The entered characters do not exist!!" + "\n" + "Soo, what is next.....", "Wrong", MessageBoxButtons.RetryCancel);
                    switch(retryCancelDialogFeedback)
                    {
                        case DialogResult.Retry: onFormLoad();
                            break;
                        case DialogResult.Cancel: Environment.Exit(1);
                            break;
                    }
                }
        }

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
            int[] randomCharPositions = new int[3];
            int ranNum;

            for (int i = 0; i < randomCharPositions.Length; i++)
            {
                ranNum = rnd.Next(1, getStrLenght()); // the 1 should ensure that the Random number is not 0
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
           
            //randomNumbers();
            cleanEnteredComboBoxValues();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            runInputCharCheck();
        }
    }
}
