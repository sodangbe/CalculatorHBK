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
            //ArrayList equationParsed = new ArrayList();

            //string _equationToCompute = equation;

            //string[] equationArray = new string[_equationToCompute.Length];
            // var equation = _equationToCompute;
            //var results = Regex.Split(_equationToCompute, @"\s*([-+/*])\s*").Where(n => !string.IsNullOrEmpty(n)).ToList();
            
            //_equationToCompute ="10-2*6/4";
            var results = Regex.Split(_equationToCompute, @"\s*([-+/*])\s*").Where(n => !string.IsNullOrEmpty(n)).ToList();

            string[] equationArray = new string[results.Count];
            Console.WriteLine(_equationToCompute);

            for (int i = 0; i < results.Count(); i++)
            {
               equationArray[i] = results[i].ToString();
            }
            Console.WriteLine(equationArray[0]);
            Console.WriteLine(equationArray[equationArray.Length].ToString());
            try
            {
                //Check if the first and last item are numbers 
                if (IsNumeric(equationArray[0].ToString()) && IsNumeric(equationArray[equationArray.Length].ToString()))
                {
                    //compute from left to right for multiplication and divison first 
                    for (int i = 1; i < equationArray.Length - 1; i++)
                    {
                        string item = equationArray[i];

                        int num = 0;
                        switch (item)
                        {
                            case "*":
                                num = Convert.ToInt32(equationArray[i - 1]) * Convert.ToInt32(equationArray[i + 1]);
                                //SetOperator(item);
                                //SetLeft(equationArray[i - 1]);
                                // SetRight(equationArray[i + 1]);
                                // num = Calculate();
                                break;
                            case "/":
                                num = Convert.ToInt32(equationArray[i - 1]) / Convert.ToInt32(equationArray[i + 1]);
                                //SetOperator(item);
                                //SetOperator(item);
                                // SetLeft(equationArray[i - 1]);
                                // SetRight(equationArray[i + 1]);
                                //  num = Calculate();
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
                                num = Convert.ToInt32(equationArray[i - 1]) + Convert.ToInt32(equationArray[i + 1]);
                                // SetOperator(item);
                                // SetOperator(item);
                                // SetLeft(equationArray[i - 1]);
                                //  SetRight(equationArray[i + 1]);
                                //  num = Calculate();
                                break;
                            case "-":
                                num = Convert.ToInt32(equationArray[i - 1]) - Convert.ToInt32(equationArray[i + 1]);
                                // SetOperator(item);
                                // SetOperator(item);
                                // SetLeft(equationArray[i - 1]);
                                //  SetRight(equationArray[i + 1]);
                                //  num = Calculate();
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

            string result = string.Join("", equationArray);
          
            return int.Parse(result);
        }
       
    }
}
