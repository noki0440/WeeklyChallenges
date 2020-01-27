using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2) //CONSTRUCTOR
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var subtract = minuend - subtrahend;
            return subtract;
            
        }

        public int Add(int number1, int number2)
        {
            var add = number1 + number2;
            return add;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if(number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            var multiply = factor1 * factor2;
            return multiply;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //var names = new[] { "John Thomes", "John", "Leigh Ann", "Leigh" };

            //foreach (var name in names)
            //{
            //    var message = "Hello," + names + "!";
            //}


            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
        }   
         
       

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
