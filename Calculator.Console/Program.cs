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
            myCalc.arrayResults = new ArrayList();

            myCalc.Calculate();
            System.Console.WriteLine($"5 + 1 = {myCalc.GetResult()}");
            myCalc.arrayResults.Add(myCalc.GetResult());
            myCalc.SetLeft("3");
            myCalc.SetRight("9");
            myCalc.SetOperator("*");
            myCalc.Calculate();
            System.Console.WriteLine($"3 * 9 = {myCalc.GetResult()}");
            myCalc.arrayResults.Add(myCalc.GetResult());
            System.Console.WriteLine($"previous result: + {myCalc.GetPreviousResult(0)}");


           
            
            
            //Divide by zero 
            myCalc.SetLeft("9");
            myCalc.SetRight("0");
            myCalc.SetOperator("/");
            myCalc.Calculate();
            System.Console.WriteLine(myCalc.error);
            System.Console.WriteLine($"9/0 = {myCalc.GetResult()}");
            myCalc.arrayResults.Add(myCalc.GetResult());
            //Overflow Error
            myCalc.SetLeft("2147483647");
            myCalc.SetRight("2147483647");
            myCalc.SetOperator("*");
            myCalc.Calculate();
            System.Console.WriteLine(myCalc.error);
            System.Console.WriteLine($"2147483647*2147483647 = {myCalc.GetResult()}");

          
            System.Console.ReadLine();

        }

  
    }
}
