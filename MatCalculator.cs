

namespace Algorithms
{
    // porwer 2^4 = 2x2x2x2 = 16
    public static class MatCalculator
    {
        public static int Power(int number, int power)
        {
            if (power == 0)
                return 1;
            else
                return number * Power(number, power - 1);
            //int rep = 1;
            //int result = 1*number;
            //while(rep < power)
            //{
            //    result = result * number;
            //    rep++;
            //} 

            //return result;
        }

        //factorial 5 = 5x4x3x2x1 = 120
        public static int Factorial(int number)
        {
            if (number == 0) return 1;

            return number * Factorial(number - 1);
            
        }
    }
}
