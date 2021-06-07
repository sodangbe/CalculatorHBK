using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorHBK
{
    public class Calculator
    {
        //Encapsulation of the calculator properties 

        //Allowed operators as a string of 4 characters 
        private readonly string AllowedOperator = "+-*/";

        // Declaring left property with Get and Set methods

        private string _left;   //backing field
        //getter
        public string GetLeft()
        {
            return _left;

        }

        //setter
        public void SetLeft(string value)
        {
            if (IsNumeric(value) && !string.IsNullOrEmpty(value))
            {
                _left = value; ;
            }
            else
            {
                throw new ArgumentException($"Invalid Number, {value}");

            }

        }

        // Declaring right property with Get and Set methods

        private string _right;  //backing field

        //public string Right { get => _right; set => _right = value; } auto-implemented properties will not allow for validation 

        //getter
        public string GetRight()
        {
            return _right;

        }

        //setter
        public void SetRight(string value)
        {
            if (IsNumeric(value) && !string.IsNullOrEmpty(value))
            {
                _right = value; ;
            }
            else
            {
                throw new ArgumentException($"Invalid Number, {value}");

            }

        }

        // Declaring operator property with Get and Set methods

        private string _operator; //backing field

        //getter
        public string GetOperator()
        {
            return _operator;

        }

        //setter
        public void SetOperator(string value)
        {


            if (this.AllowedOperator.Contains(value))
            {
                _operator = value;
            }
            else
            {
                throw new ArgumentException($"Operator Not Allowed,{value}");

            }

        }

        //class calculator default constructor
        public Calculator() { }

        //class calculator constructor overloading 
        public Calculator(string left, string right, string allowedOperator)
        {
                       
            if(IsNumeric(left) && !string.IsNullOrEmpty(left))
            {
                _left = left;
            }
            else
            {
               throw new ArgumentException($"Invalid Number, {left}");

            }
            
            if (IsNumeric(right) && !string.IsNullOrEmpty(left))
            {
                _right = right;
            }
            else
            {
                throw new ArgumentException($"Invalid Number, {right}");

            }
            if (AllowedOperator.Contains(allowedOperator))
            {
                _operator = allowedOperator;
            }
            else
            {
                throw new ArgumentException($"Operator Not Allowed,{allowedOperator}");

            }
        }

        // Method Calculate 
        public int Calculate()
        {
            //int.Parse(this.left) != Convert.ToInt32(this._left);  //int.parse the other casting alternative will throw an ArgumentNullException when passing a null value

            int result = 0;


            //addition 
            if (this._operator == "+")
                //checking for aritmetic flow
                checked
                {
                    result += Convert.ToInt32(this._left) + Convert.ToInt32(this._right);
                }
            //multiplication
            if (this._operator == "*")
                //checking for arithmetic flow 
                checked
                {
                    result += Convert.ToInt32(this._left) * Convert.ToInt32(this._right);
                }
            //substraction
            if (this._operator == "-")
                //checking for arithmetic flow 
                checked
                {
                    result += Convert.ToInt32(this._left) - Convert.ToInt32(this._right);
                }
            //division 
            if ((this._operator == "/"))
            checked
            {
                result += Convert.ToInt32(this._left) / Convert.ToInt32(this._right);
            }

            return result;
        }
        public string GetResult()
        {
            return Calculate().ToString();

        }

#pragma warning disable IDE0060 // Remove unused parameter
        public int GetPreviousResult(int index)
        {

            return index;

        }
#pragma warning restore IDE0060 // Remove unused parameter
        //Method to check if the property is numeric
        public static bool IsNumeric(string s)
        {
            return double.TryParse(s, out double n);
        }
    }
}
