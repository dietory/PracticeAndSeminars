using System;

namespace SeminarArr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            var arr = new int[5] { 1, 2, 3, 4, 5 };
            foreach (var item in arr)
                Console.Write(" " + item.ToString());
            shiftArr(ref arr, 5);

            Console.WriteLine("\n-----------");
            foreach (var item in arr)
                Console.Write(" " + item.ToString());
        }

        public static void shiftArr(ref int[] arrayToShift, int shiftNumber)
        {
            for (int i = 0; i < arrayToShift.Length; i++)
            {
                if (arrayToShift.Length - i > shiftNumber)
                    arrayToShift[i] = arrayToShift[i + shiftNumber];
                else
                    arrayToShift[i] = 0;
            }
        }
    }
}
