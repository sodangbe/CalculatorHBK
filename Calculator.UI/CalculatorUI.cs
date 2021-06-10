using CalculatorHBK;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Linq;
using CalculatorHBK.Properties;

namespace Calculator.UI
{
    public partial class Form : KryptonForm
    {

    #region Global variables and Methods
        //Create calculator object for operations
        CalculatorHBK.Calculator myCalculator = new CalculatorHBK.Calculator();
        ArrayList collectTheOperationList = new ArrayList();
        bool operationComplete = false;
    

        public Form()
        {
            InitializeComponent();

        }

     
        private void CalculatorUI_Load(object sender, EventArgs e)
        {

        }

     #endregion

    #region Numeric Button Click Events 


        //cannot start a new operation with a 0 so we will not need to call the numericKeySelection function
        private void kButton0_Click(object sender, EventArgs e)
    {
        if ((kryptonRichTBResults.Text != string.Empty) && operationComplete == false)
        {
            kryptonRichTBResults.Text += kButton0.Text;
        }
        else
        {
                //kryptonRichTBResults.Clear();
                kryptonRichTBResults.Text = kButton0.Text;
                operationComplete = (false);
        }
    }

    private void kButton1_Click(object sender, EventArgs e)
    {

       
        // Already ran the calculator - we will check the flag 
        if (kryptonRichTBResults.Text != string.Empty && operationComplete == false)
        {
          
                kryptonRichTBResults.Text += kButton1.Text;

        }
        else
        {            
            kryptonRichTBResults.Text = kButton1.Text;
            operationComplete = (false);
        }

    }

    private void kButton2_Click(object sender, EventArgs e)
    {
        
        if ((kryptonRichTBResults.Text != string.Empty) && operationComplete == false)
        {
            kryptonRichTBResults.Text += kButton2.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton2.Text;
            operationComplete = false;
        }

    }

    private void kButton3_Click(object sender, EventArgs e)
    {
          
        if ((kryptonRichTBResults.Text != string.Empty) && operationComplete == false)
        {
            kryptonRichTBResults.Text += kButton3.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton3.Text;
            operationComplete = false ;

        }
    }

    private void kButton4_Click(object sender, EventArgs e)
    {
            
        if ((kryptonRichTBResults.Text != string.Empty) && operationComplete.Equals(false))
        {
            
            kryptonRichTBResults.Text += kButton4.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton4.Text;
            operationComplete = false ;

        }

    }

    private void kButton5_Click(object sender, EventArgs e)
    {
   

        if ((kryptonRichTBResults.Text != string.Empty) && operationComplete.Equals(false))
        {
            kryptonRichTBResults.Text += kButton5.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton5.Text;
                operationComplete = (false);

        }
    }

    private void kryptonButton6_Click(object sender, EventArgs e)
    {
        // numericKeySelection(kryptonButton6.Text);

        if ((kryptonRichTBResults.Text != string.Empty) && operationComplete.Equals(false))
        {
            kryptonRichTBResults.Text += kryptonButton6.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kryptonButton6.Text;
                operationComplete = false;

        }
    }

    private void kButton7_Click(object sender, EventArgs e)
    {
        // numericKeySelection(kButton7.Text);

        if ((kryptonRichTBResults.Text != string.Empty) && operationComplete.Equals(false))
        {
            kryptonRichTBResults.Text += kButton7.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton7.Text;
                operationComplete = (false);

        }
    }

    private void kButton8_Click(object sender, EventArgs e)
    {
        //numericKeySelection(kButton8.Text);

        if ((kryptonRichTBResults.Text != string.Empty) && operationComplete.Equals(false))
        {
            kryptonRichTBResults.Text += kButton8.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton8.Text;
            operationComplete = (false);

        }

    }

    private void kButton9_Click(object sender, EventArgs e)
    {
        //numericKeySelection(kButton9.Text);

        if ((kryptonRichTBResults.Text != string.Empty) && operationComplete.Equals(false))
        {
            kryptonRichTBResults.Text += kButton9.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton9.Text;
            operationComplete = (false);

        }
    }

        #endregion

    #region  Operators Button Click Events        
        private void kButton_Add_Click(object sender, EventArgs e)
        {
   
            operatorSelection(kButton_Add.Text, kryptonRichTBResults.Text);
            kryptonRichTBResults.Clear();

        }

       

        private void kButton_Subtract_Click(object sender, EventArgs e)
        {
     
            operatorSelection(kButton_Subtract.Text, kryptonRichTBResults.Text);
            kryptonRichTBResults.Clear();
        }

        private void kButton_Divide_Click(object sender, EventArgs e)
        {

            operatorSelection(kButton_Divide.Text, kryptonRichTBResults.Text);
            kryptonRichTBResults.Clear();


        }

        private void kButton_Multiply_Click(object sender, EventArgs e)
        {
           
            operatorSelection(kButton_Multiply.Text, kryptonRichTBResults.Text);
            kryptonRichTBResults.Clear();
        }

        #endregion

        private void kButton_Equal_Click(object sender, EventArgs e)
        {
            //Empty result textbox the equal click will not trigger the events below
            
                if (kryptonRichTBResults.Text != string.Empty)
                {

                    //1 - String in the texbox is added to our result arraylist
                    collectTheOperationList.Add(kryptonRichTBResults.Text);
                    collectTheOperationList.Add("=");

                    //2 - Set the second operand of the operation to our calculator
         
                    myCalculator.SetRight(kryptonRichTBResults.Text);
                

                    //3 - Compute the operation 
                    myCalculator.Calculate();
                
                    //4 - Display the result in the resultTextbox 

                    kryptonRichTBResults.Text = errorHandler();
                    collectTheOperationList.Add(kryptonRichTBResults.Text);

                    //5 - Add the operation to the ListBox
                    kryptonListBox_Results.Items.Add(formatOperationList(collectTheOperationList));


                    //6 - Clear the arraylist and set operation finished flag to true 
                    collectTheOperationList.Clear();
                    operationComplete = true;


                }
                      

        }

    #region Helper Methods 
       
        
        //Method to format arraylist to a string for the list box 
        private string formatOperationList (ArrayList arrayList)
        {
            string rowOfListbox = string.Empty;
            foreach (string s in arrayList)
            {
                rowOfListbox += s;
            }

            return rowOfListbox;
        }

      
         
        //Method to select the font of the calculator numbers in the results textbox
        private void kryptonRichTBResults_TextChanged(object sender, EventArgs e)
        {
            this.kryptonRichTBResults.SelectAll();
            this.kryptonRichTBResults.SelectionFont = new Font("Tahoma", 20);
            //"Comic Sans MS"
        }




        private void operatorSelection (string typeOfOperator , string input )
        {

            if ((input != string.Empty))
            {
                //1- Setting the left value of the operation
                myCalculator.SetLeft(input);

                //2 - Setting the operator for the calculator
                myCalculator.SetOperator(typeOfOperator);

                //3 -Adding the operand and the aoperator to the arraylist 
                collectTheOperationList.Add(input);
                collectTheOperationList.Add(typeOfOperator);
            }
          


        }


        private void numericKeySelection(string number )
        {
            // Already ran the calculator - we will check the flag 
            if (operationComplete.Equals(true))
            {
                kryptonRichTBResults.Clear();
                operationComplete.Equals(false);
                kryptonRichTBResults.Text = number;
            }
            else // starting calculator and order of selection for the keys 
            {

                if (kryptonRichTBResults.Text != string.Empty)
                {

                    kryptonRichTBResults.Text += number;

                }
                else
                {
                    kryptonRichTBResults.Text = number;

                }
            }

        }


        private void kButtonCE_Click(object sender, EventArgs e)
        {
            kryptonRichTBResults.Clear();
            kryptonListBox_Results.Items.Clear();
            collectTheOperationList.Clear();
            operationComplete = false;
        }

        //This method handles the error messages from exception thrown by calculator class
        private string errorHandler()
        {
            string ValidText = string.Empty;

            if (myCalculator.error != null)
            {
               
               ValidText = myCalculator.error.ToString();
                    
            } else 
            
            {
               ValidText = myCalculator.GetResult();
                             
            }

            kryptonRichTBResults.Clear();
            myCalculator.error = null;
            operationComplete.Equals(true);

            return ValidText;

        }

        #endregion


       
    }
}
