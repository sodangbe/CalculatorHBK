using System;
using System.Collections;
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
        public string error { get; set; }
        public ArrayList arrayResults { get; set; }
        

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
        public Calculator() { this.arrayResults = new ArrayList(); }

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

            this.arrayResults = new ArrayList();
        }

        // Method Calculate 
        public int Calculate()
        {
            //int.Parse(this.left) != Convert.ToInt32(this._left);  //int.parse the other casting alternative will throw an ArgumentNullException when passing a null value

            int result = 0;

            try
            {
                //addition 
                if (this._operator == "+")
                    //checking for aritmetic flow
                    checked
                    {
                        result += Convert.ToInt32(this._left) + Convert.ToInt32(this._right);
                    }
                //multiplication
                if (this._operator == "*")
                    //checking for arithmetic overflow 
                    checked
                    {
                        result += Convert.ToInt32(this._left) * Convert.ToInt32(this._right);
                    }
                //substraction
                if (this._operator == "-")
                    //checking for arithmetic overflow 
                    checked
                    {
                        result += Convert.ToInt32(this._left) - Convert.ToInt32(this._right);
                    }

            }
            catch (OverflowException oex)
            {

                error = oex.Message;
            }
            
            try 
            { 
            //division  with divide by zero exception 
            if ((this._operator == "/"))
                checked
                {
                    result += Convert.ToInt32(this._left) / Convert.ToInt32(this._right);
                }
            }
            catch (DivideByZeroException e)
            {

                error = e.Message;
            }
            

            return result;
        }
        public string GetResult()
        {
            return Calculate().ToString();

        }


        public string GetPreviousResult(int index)
        {

            return (string)arrayResults[index];

        }

        //Method to check if the property is numeric
        public static bool IsNumeric(string s)
        {
            return double.TryParse(s, out double n);
        }
    }
}
