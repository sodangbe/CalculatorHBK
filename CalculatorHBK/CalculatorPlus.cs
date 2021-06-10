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
        public CalculatorPlus(string equationToCompute)
        {
            this._equationToCompute = equationToCompute;
        }

        public new int Calculate()
        {
            // ArrayList equationParsed = new ArrayList();

            /* foreach (var match in Regex.Matches(equation, @"([*+/\-)(])|([0-9]+)"))
              {

                  //equationParsed.Add(match.ToString());

              }*/
            //string _equationToCompute = equation;

            string[] equationArray = new string[ _equationToCompute.Length];
            for (int i = 0; i < _equationToCompute.Length; i++)
            {
                equationArray[i] = _equationToCompute[i].ToString();
            }


            try
            {
                //Check if the first and last item are numbers 
                if (IsNumeric(equationArray[0].ToString()) && IsNumeric(equationArray[equationArray.Length - 1].ToString()))
                {
                    //compute from left to right for multiplication and divison first 
                    for (int i = 1; i < equationArray.Length - 1; i++)
                    {
                        string item = equationArray[i];
                        
                        int num = 0;
                        switch (item)
                        {
                            case "*":
                                //SetOperator(equationParsed[i].ToString());
                                SetOperator(item);
                                SetLeft(equationArray[i - 1]);
                                SetRight(equationArray[i + 1]);
                                num = Calculate();
                                break;
                            case "/":
                                // SetOperator(equationParsed[i].ToString());
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
                        //SetOperator(equationParsed[i].ToString());
                        int num = 0;
                        switch (item)
                        {
                            case "+":
                                //SetOperator(equationParsed[i].ToString());
                                SetOperator(item);
                                SetOperator(item);
                                SetLeft(equationArray[i - 1]);
                                SetRight(equationArray[i + 1]);
                                num = Calculate();
                                break;
                            case "-":
                                //SetOperator(equationParsed[i].ToString());
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

            string result = string.Join("", equationArray);
          
            return int.Parse(result);
        }
    }
}
