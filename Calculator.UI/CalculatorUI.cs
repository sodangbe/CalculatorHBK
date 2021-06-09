using CalculatorHBK;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Linq;

namespace Calculator.UI
{
    public partial class Form : KryptonForm
    {
        //Create calculator object for operations
        CalculatorHBK.Calculator myCalculator = new CalculatorHBK.Calculator();
        ArrayList collectTheOperationList = new ArrayList();
        bool operationComplete = false;


        public Form()
        {
            InitializeComponent();

        }

        //private void InitializeComponent()
       // {
       //     throw new NotImplementedException();
        //}

        private void CalculatorUI_Load(object sender, EventArgs e)
        {

        }

   /// if (operationComplete.Equals(true))
               //{
      //             kryptonRichTBResults.Clear();
      //             operationComplete.Equals(false);
       //            kryptonRichTBResults.Text = kButton1.Text;
    //           } 
  //  else // starting calculator and order of selection for the keys 
               
   // {

    #region ButtonClickEvents 

    //cannot start a new operation with a 0 so we will not need to call the numericKeySelection function
    private void kButton0_Click(object sender, EventArgs e)
    {
        if ((kryptonRichTBResults.Text != string.Empty))
        {
            kryptonRichTBResults.Text += kButton0.Text;
        }
    }

    private void kButton1_Click(object sender, EventArgs e)
    {

        //numericKeySelection(kButton1.Text);
        // Already ran the calculator - we will check the flag 



        if (kryptonRichTBResults.Text != string.Empty)
        {

            kryptonRichTBResults.Text += kButton1.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton1.Text;

        }

    }

    private void kButton2_Click(object sender, EventArgs e)
    {
        // numericKeySelection(kButton2.Text);
        if ((kryptonRichTBResults.Text != string.Empty))
        {
            kryptonRichTBResults.Text += kButton2.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton2.Text;

        }

    }

    private void kButton3_Click(object sender, EventArgs e)
    {
        // numericKeySelection(kButton3.Text);
        if ((kryptonRichTBResults.Text != string.Empty))
        {
            kryptonRichTBResults.Text += kButton3.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton3.Text;


        }
    }

    private void kButton4_Click(object sender, EventArgs e)
    {
        //numericKeySelection(kButton4.Text);
        if ((kryptonRichTBResults.Text != string.Empty))
        {
            kryptonRichTBResults.Text += kButton4.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton4.Text;


        }

    }

    private void kButton5_Click(object sender, EventArgs e)
    {
        //numericKeySelection(kButton5.Text);

        if ((kryptonRichTBResults.Text != string.Empty))
        {
            kryptonRichTBResults.Text += kButton5.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton5.Text;


        }
    }

    private void kryptonButton6_Click(object sender, EventArgs e)
    {
        // numericKeySelection(kryptonButton6.Text);

        if ((kryptonRichTBResults.Text != string.Empty))
        {
            kryptonRichTBResults.Text += kryptonButton6.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kryptonButton6.Text;


        }
    }

    private void kButton7_Click(object sender, EventArgs e)
    {
        // numericKeySelection(kButton7.Text);

        if ((kryptonRichTBResults.Text != string.Empty))
        {
            kryptonRichTBResults.Text += kButton7.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton7.Text;


        }
    }

    private void kButton8_Click(object sender, EventArgs e)
    {
        //numericKeySelection(kButton8.Text);

        if ((kryptonRichTBResults.Text != string.Empty))
        {
            kryptonRichTBResults.Text += kButton8.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton8.Text;


        }

    }

    private void kButton9_Click(object sender, EventArgs e)
    {
        //numericKeySelection(kButton9.Text);

        if ((kryptonRichTBResults.Text != string.Empty))
        {
            kryptonRichTBResults.Text += kButton9.Text;

        }
        else
        {
            kryptonRichTBResults.Text = kButton9.Text;


        }
    }

    #endregion
    
     //}              
        private void kButton_Add_Click(object sender, EventArgs e)
        {
            /* if (kryptonRichTBResults.Text != string.Empty )
             {
                //1- Setting the left value of the operation
                 myCalculator.SetLeft(kryptonRichTBResults.Text);

                //2 - Setting the operator for the calculator
                 myCalculator.SetOperator(kButton_Add.Text);

                //3 -Adding the operand and the aoperator to the arraylist 
                 collectTheOperationList.Add(kryptonRichTBResults.Text);
                 collectTheOperationList.Add(kButton_Add.Text);

                //4 - Clear the result textbox 
                 kryptonRichTBResults.Clear();

             }*/
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

        private void kButton_Equal_Click(object sender, EventArgs e)
        {
            //Empty result textbox the equal click will not trigger the events below
            
                if (kryptonRichTBResults.Text != string.Empty )
                {

                    //1 - String in the texbox is added to our result arraylist
                    collectTheOperationList.Add(kryptonRichTBResults.Text);
                    collectTheOperationList.Add("=");

                    //2 - Set the second operand of the operation to our calculator
                    myCalculator.SetRight(kryptonRichTBResults.Text);

                    //3 - Compute the operation 
                    myCalculator.Calculate();

                    //4 - Display the result in the resultTextbox 
                    kryptonRichTBResults.Text = myCalculator.GetResult();
                    collectTheOperationList.Add(kryptonRichTBResults.Text);

                    //5 - Add the operation to the ListBox

                    //kryptonListBox_Results.Items.AddRange(collectTheOperationList.Cast<string>.ToArray());

                    //kryptonListBox_Results.DataSource = collectTheOperationList;
                    kryptonListBox_Results.Items.Add(formatOperationList(collectTheOperationList));



                    //6 - Clear the arraylist and set operation finished flag to true 
                    collectTheOperationList.Clear();
                    operationComplete = true;
                    
            }
            

        }


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

      
         
        //Method to select the font of the calculator number
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
        }




        /*
         //We are going to build the arithmetic function by appending the text from every button clicked 
         private string BuildTheArithmeticEquation(string buttonTextReturned)
         {
             StringBuilder sb = new StringBuilder();

             sb.Append(buttonTextReturned);

             return sb.ToString();

         }


         //We will split the string to store into our calculator properties 
         private void SetCalculatorValues(string arithmeticOperation )
         {
             Char[] operators = { '+', '-', '*', '/' };
             String[] calculatorPropertySetters = arithmeticOperation.Split(operators);

              for (int i = 0; i < calculatorPropertySetters.Length; i++)
              {

              }

             myCalculator.SetLeft(calculatorPropertySetters[0]);
             myCalculator.SetOperator(calculatorPropertySetters[1]);
             myCalculator.SetRight(calculatorPropertySetters[2]);

         }


         private int ResultOfOperation()
         {
             return myCalculator.Calculate();
         }

         private void kButton_Equal_Click(object sender, EventArgs e)
         {
             kryptonRichTBResults.Text = ResultOfOperation().ToString();

         }

         /*private void kButton1_Click(object sender, EventArgs e)
         {
             myCalc.SetLeft(kButton1.Text);
             kryptonRichTBResults.Text = myCalc.GetLeft();
         }

           //We will split the string to store into our calculator properties 
       private void SetCalculatorValues(string arithmeticOperation)
       {
           Char[] operators = { '+', '-', '*', '/' };
           String[] calculatorPropertySetters = arithmeticOperation.Split(operators);

           //for (int i = 0; i < calculatorPropertySetters.Length; i++)
           //{

           //}

           myCalculator.SetLeft(calculatorPropertySetters[0]);
           //myCalculator.SetOperator(calculatorPropertySetters[1]);
           myCalculator.SetRight(calculatorPropertySetters[2]);

       }*/
    }
}
