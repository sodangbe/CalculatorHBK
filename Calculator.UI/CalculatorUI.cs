using CalculatorHBK;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Text;
using System.Windows.Forms;

namespace Calculator.UI
{
    public partial class CalculatorUI : KryptonForm
    {
        //Create calculator object for operations
        CalculatorHBK.Calculator myCalculator = new CalculatorHBK.Calculator();
        string collectTheOperation = string.Empty;
        public CalculatorUI()
        {
            InitializeComponent();
        }

        // int n = myCalculator.Calculate();



        private void CalculatorUI_Load(object sender, EventArgs e)
        {
            int n = myCalculator.Calculate();
        }



        #region ButtonClickEvents 

        private void kButton0_Click(object sender, EventArgs e)
        {
            if ((kryptonRichTBResults.Text != string.Empty))
            {
                kryptonRichTBResults.Text += kButton0.Text;
            }
        }

        private void kButton1_Click(object sender, EventArgs e)
        {

            if((kryptonRichTBResults.Text != string.Empty))
            {
                kryptonRichTBResults.Text += kButton1.Text;
            }
            else
            {
                kryptonRichTBResults.Text = kButton1.Text;
                
            }

            //BuildTheArithmeticEquation(kryptonRichTBResults.Text);
        }

        private void kButton2_Click(object sender, EventArgs e)
        {
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
                }*/
    }
}
