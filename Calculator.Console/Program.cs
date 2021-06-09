using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorHBK;

namespace Calculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorHBK.Calculator myCalc = new CalculatorHBK.Calculator("5", "1", "+");
            ArrayList collectTheOperationList = new ArrayList();

            myCalc.Calculate();
            System.Console.WriteLine($"5 + 1 = {myCalc.GetResult()}");
            myCalc.SetLeft("3");
            myCalc.SetRight("9");
            myCalc.SetOperator("*");
            myCalc.Calculate();
            System.Console.WriteLine($"3 * 9 = {myCalc.GetResult()}");
            System.Console.ReadLine();



        }
    }
}
