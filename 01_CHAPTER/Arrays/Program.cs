using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //способы объявления массива
            // тип данных[] имя массива

            int[] myArray;
            int[] myArrayFixedSize = new int[5];
            int[] myFilledArray = { 1, 2, 3, 4, 5 };

            int[][] twoDiamensionalArray;

            Random rnd = new Random();

            for(int i = 0; i < myArrayFixedSize.Length; i++)
            {
                myArrayFixedSize[i] = rnd.Next();
            }

            Console.Write("[ ");
            for (int i = 0; i < myArrayFixedSize.Length; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
        }
    }
}
