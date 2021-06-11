using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorHBK
{
    public class CalculatorPlus : Calculator
    {
        public string _equationToCompute { get; set; }
        
        public CalculatorPlus()
        {
       
        
        }

        public int Calculate(string equationToCompute)
        {
          
            //1 - Turning the equation string into an array of strings using delimiter "+,-,*,/"
            string[] equation = convertToArrayOfString(equationToCompute);

            //2 - Compute first multiplication and division by order o precendence from left to right 
            for (int i = 1; i < equation.Length - 1; i++)
            {
                string item = equation[i];
                int num = 0;
                switch (item)
                {
                    case "*":
                       
                        SetOperator(item);
                        SetLeft(equation[i - 1]);
                        SetRight(equation[i + 1]);
                        num = Calculate();
                        break;
                    case "/":
                       
                        SetOperator(item);
                        SetLeft(equation[i - 1]);
                        SetRight(equation[i + 1]);
                        num = Calculate();
                        break;
                }
                if (num > 0)
                {
                    equation[i - 1] = "";
                    equation[i] = "";
                    equation[i + 1] = num.ToString();
                }
            }
            //equation = string.Join(" ", equation).Split(' ');
            //3 - Removing all the empty index from the array and join the the array for only addition and substraction 
            List<string> y = equation.ToList<string>();
            y.RemoveAll(p => string.IsNullOrEmpty(p));
            equation = y.ToArray();

            //4 - //2 - Compute second addition and substraction by order of precendence from left to right 
            for (int i = 1; i < equation.Length - 1; i++)
            {
                string item = equation[i];
                int num = 0;
                switch (item)
                {
                    case "+":
                     
                        SetOperator(item);
                        SetLeft(equation[i - 1]);
                        SetRight(equation[i + 1]);
                        num = Calculate();
                        break;
                    case "-":
                        
                        SetOperator(item);
                        SetLeft(equation[i - 1]);
                        SetRight(equation[i + 1]);
                        num = Calculate();
                        break;
                }
                if (num > 0)
                {
                    equation[i - 1] = "";
                    equation[i] = "";
                    equation[i + 1] = num.ToString();
                }
            }
            string total = string.Join("", equation);
           
           return int.Parse(total);

           
        }

        // convert to string to array of string and check for first string and last string for numbers 
        private string[] convertToArrayOfString (string equation)
        {
           List<string> newList =  Regex.Split(equation, @"\s*([-+/*])\s*").Where(n => !string.IsNullOrEmpty(n)).ToList();

            bool firststringisNumeric = IsNumeric(newList[0]);
            bool laststringisNumeric = IsNumeric(newList[newList.Count - 1]);

            if (firststringisNumeric && laststringisNumeric)
                return newList.ToArray();
            else
                return new string[0];
        }
       
    }
}

