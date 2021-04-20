using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //double answer = 7.0 / 2.0;

            //int remainder = 7 % 2;
            //level level
            var isPaliPhrase=PalidromeEquality.IsPalindromePhrase("Red rum, sir, is murder");
            var isPalinWord = PalidromeEquality.IsPalindrome("isLevel");
            int quotient = 7 / 2;
            //HanoiTower.Move(5, "A", "C", "B");
            int []array =new int[] { 1, 2, 3,5,7,9 };
            var linear = new LinearSearch();
            var result = linear.BinarySearch(array, 11);
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
