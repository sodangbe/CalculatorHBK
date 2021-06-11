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
            System.Console.WriteLine($"5 + 1 = {myCalc.GetResult()}");

            myCalc.arrayResults.Add(myCalc.GetResult());
            myCalc.SetLeft("3");
            myCalc.SetRight("9");
            myCalc.SetOperator("*");
            
            myCalc.Calculate();
          
            System.Console.WriteLine($"3 * 9 = {myCalc.GetResult()}");
          
            myCalc.arrayResults.Add(myCalc.GetResult());
            System.Console.WriteLine($"previous result: {myCalc.GetPreviousResult(0)}");
     
            
            
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

            System.Console.WriteLine();
            CalculatorPlus calc = new CalculatorPlus();

            System.Console.WriteLine($"1 - The result of the equation 4-1+12*4 = {calc.Calculate("4-1+12*4").ToString()}");
            calc.arrayResults.Add(calc.Calculate("4-1+12*4"));
            calc.Dispose();
            System.Console.WriteLine($"2 - The result of the equation 10-5*6 = {calc.Calculate("10-5+6").ToString()}");
            calc.arrayResults.Add(calc.Calculate("10-5+6"));
            calc.Dispose();
            System.Console.WriteLine($"3 -The result of the equation 6/4+12*4 = {calc.Calculate("6/4+12*4").ToString()}");
            calc.arrayResults.Add(calc.Calculate("6/4+12*4"));
            calc.Dispose();
            System.Console.WriteLine($"4 -The result of the equation 1+12*4 = {calc.Calculate("1+12*4").ToString()}");
            calc.arrayResults.Add(calc.Calculate("1+12*4"));
            calc.Dispose();
            System.Console.WriteLine($"5 -The result of the equation 105*64+2 = {calc.Calculate("105*64+2").ToString()}");
            calc.arrayResults.Add(calc.Calculate("105*64+2"));
            calc.Dispose();
            System.Console.WriteLine($"6 -The result of the equation 41+12*4 = {calc.Calculate("41+12*4").ToString()}");
            calc.arrayResults.Add(calc.Calculate("41+12*4"));
            calc.Dispose();
            System.Console.WriteLine($"7 -The result of the equation 10-5*6/4 = {calc.Calculate("10-5*6/4").ToString()}");
            calc.arrayResults.Add(calc.Calculate("10-5*6/4"));
            calc.Dispose();
            System.Console.WriteLine($"8 -The result of the equation 105*6+12*4 = {calc.Calculate("105*6+12*4").ToString()}");
            calc.arrayResults.Add(calc.Calculate("105*6+12*4"));
            calc.Dispose();
            System.Console.WriteLine($"9 -The result of the equation 64-112/4 = {calc.Calculate("64-112/4").ToString()}");
            calc.arrayResults.Add(calc.Calculate("64-112/4"));
            calc.Dispose();
            System.Console.WriteLine($"10 - The result of the equation 10*6/4-1+12*4 = {calc.Calculate("10*6/4-1+12*4").ToString()}");
            calc.arrayResults.Add(calc.Calculate("10*6/4-1+12*4"));
            calc.Dispose();
            System.Console.WriteLine();
            System.Console.WriteLine($"The last 10 results of the equation computation by CalculatorPlus:" );
            foreach(int x in calc.arrayResults)
            {
                System.Console.Write($"{x}  ");
            }




            myCalc.Dispose();
            calc.Dispose();
            System.Console.ReadLine();

        }

  
    }
}
