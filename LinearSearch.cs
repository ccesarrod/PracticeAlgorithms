using System;

namespace Algorithms
{
    public  class LinearSearch
    {
        private int[] _array;
        private int pos;      

        public int BinarySearch(int[] Array, int number)
        {
            pos = 0;

            return BinarySearch(Array, number, pos, Array.Length-1);
        }

        private int BinarySearch(int[] array, int number, int start, int end)
        {

            if (start <= end)
            {
                int middle =start+ (end - start) / 2;                

                int midValue = array[middle];
                if (midValue == number) return number;

                if (number > midValue)
                {
                    return BinarySearch(array, number, middle + 1, array.Length-1);
                }
                else if (number < midValue)
                    return BinarySearch(array, number, start, middle - 1);

            }   

            return -1;

        }
    }
}
