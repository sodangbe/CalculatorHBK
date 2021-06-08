using CalculatorHBK;
using ComponentFactory.Krypton.Toolkit;
using System;

namespace Calculator.UI
{
    public partial class CalculatorUI : KryptonForm
    {
        //Create calculator object for operations
        CalculatorHBK.Calculator myCalc = new CalculatorHBK.Calculator();    
        public CalculatorUI()
        {
            InitializeComponent();
                  

        }

       //myCalc.Calculate();

        private void CalculatorUI_Load(object sender, EventArgs e)
        {

        }

        private void kButton1_Click(object sender, EventArgs e)
        {

        }




        /*private void kButton1_Click(object sender, EventArgs e)
        {
            myCalc.SetLeft(kButton1.Text);
            kryptonRichTBResults.Text = myCalc.GetLeft();
        }*/
    }
}
