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

        public int Calculate(string _equationToCompute)
        {
           // string[] equation = { "10", "-", "2", "*", "6", "/", "4" };
             //var _equationToCompute = "10-2*6/4";
            // var results = Regex.Split(_equationToCompute, @"\s*([-+/*])\s*").Where(n => !string.IsNullOrEmpty(n)).ToList();

            //string[] equation = new string[results.Count];

            string[] equation = convertToArrayOfString(_equationToCompute);

            for (int i = 1; i < equation.Length - 1; i++)
            {
                string item = equation[i];
                int num = 0;
                switch (item)
                {
                    case "*":
                        num = Convert.ToInt32(equation[i - 1]) * Convert.ToInt32(equation[i + 1]);
                        break;
                    case "/":
                        num = Convert.ToInt32(equation[i - 1]) / Convert.ToInt32(equation[i + 1]);
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
            List<string> y = equation.ToList<string>();
            y.RemoveAll(p => string.IsNullOrEmpty(p));
            equation = y.ToArray();

            for (int i = 1; i < equation.Length - 1; i++)
            {
                string item = equation[i];
                int num = 0;
                switch (item)
                {
                    case "+":
                        num = Convert.ToInt32(equation[i - 1]) + Convert.ToInt32(equation[i + 1]);
                        break;
                    case "-":
                        num = Convert.ToInt32(equation[i - 1]) - Convert.ToInt32(equation[i + 1]);
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
            //display what x is
           return int.Parse(total);

           
        }


        private string[] convertToArrayOfString (string equation)
        {
           List<string> newList =  Regex.Split(equation, @"\s*([-+/*])\s*").Where(n => !string.IsNullOrEmpty(n)).ToList();

            return newList.ToArray();
        }
       
    }
}

/* var results = Regex.Split(_equationToCompute, @"\s*([-+/*])\s*").Where(n => !string.IsNullOrEmpty(n)).ToList();

            string[] equationArray = Array.Empty<string>();


            for (int i = 0; i < results.Count(); i++)
            {
               equationArray[i] = results[i].ToString();
            }

            try
            {
                //Check if the first and last item are numbers 
                if (IsNumeric(equationArray[0].ToString()))
                {
                    //compute from left to right for multiplication and divison first 
                    for (int i = 1 ; i < equationArray.Length - 1; i++)
                    {
                        string item = equationArray[i];

                        int num = 0;
                        switch (item)
                        {
                            case "*":
                                //num = Convert.ToInt32(equationArray[i - 1]) * Convert.ToInt32(equationArray[i + 1]);
                                SetOperator(item);
                                SetLeft(equationArray[i - 1]);
                                SetRight(equationArray[i + 1]);
                                 num = Calculate();
                                break;
                            case "/":
                                num = Convert.ToInt32(equationArray[i - 1]) / Convert.ToInt32(equationArray[i + 1]);
                                SetOperator(item);
                                SetOperator(item);
                                SetLeft(equationArray[i - 1]);
                                SetRight(equationArray[i + 1]);
                                 num = Calculate();
                                break;
                        }
                        if (num > 0)
                        {
                            equationArray[i - 1] = "";
                            equationArray[i] = "";
                            equationArray[i + 1] = num.ToString();
                        }
                    }

                    //remove all the empty spaces after the multiplication and division are evaluated 
                    List<string> y = equationArray.ToList<string>();
                    y.RemoveAll(p => string.IsNullOrEmpty(p));
                    equationArray = y.ToArray();

                    for (int i = 1; i < equationArray.Length - 1; i++)
                    {
                        string item = equationArray[i];

                        int num = 0;
                        switch (item)
                        {
                            case "+":
                                //num = Convert.ToInt32(equationArray[i - 1]) + Convert.ToInt32(equationArray[i + 1]);
                                SetOperator(item);
                                SetOperator(item);
                                SetLeft(equationArray[i - 1]);
                                 SetRight(equationArray[i + 1]);
                                 num = Calculate();
                                break;
                            case "-":
                                //num = Convert.ToInt32(equationArray[i - 1]) - Convert.ToInt32(equationArray[i + 1]);
                                 SetOperator(item);
                                 SetOperator(item);
                                 SetLeft(equationArray[i - 1]);
                                 SetRight(equationArray[i + 1]);
                                 num = Calculate();
                                break;
                        }
                        if (num > 0)
                        {
                            equationArray[i - 1] = "";
                            equationArray[i] = "";
                            equationArray[i + 1] = num.ToString();
                        }
                    }


                }
            }
            catch (FormatException e)
            {
                error = e.Message;  //Grab this from the parent class
            }
            finally{
                Console.WriteLine("end");
            }
            string result = string.Join("", equationArray);

            return int.Parse(result);*/