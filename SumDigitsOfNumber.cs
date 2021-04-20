using System;

namespace Algorithms
{
    public  class SumDigitsOfNumber
    {
        public int SumpUp(int number)
        {
            //14 = 1+4  = 5
            string numberString = number.ToString();
            var temp = numberString.ToCharArray();
            var result = 0;
            Array.ForEach(temp,x=> result+= int.Parse(x.ToString()));
            
            //foreach(var digit in numberString)
            //{
            //    result += int.Parse(digit.ToString());
            //}

            return result;
        }

    
        public int SumpUpMath(int number)
        {
            //14 = 1+4  = 5
            if (number != 0)
            {
                int reminder = 0;
                Math.DivRem(number, 10, out reminder);
                var num = reminder + SumpUpMath(number / 10);

                return num;
            }
            return 0;
        }

        public int SumpUpRecursive(int number)
        {
            if ( number !=0)
            {
                return number % 10 + SumpUpRecursive(number / 10);
            }

            return 0;
        }
    }
}
