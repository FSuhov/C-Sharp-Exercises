using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool

            //sbyte - signed byte
            Console.WriteLine("sbyte:\n min: {0} max: {1} || size: {2}", sbyte.MinValue, sbyte.MaxValue, sizeof(sbyte)); 

            //byte - unsigned byte
            Console.WriteLine("byte:\n min: {0} max: {1} || size: {2}", byte.MinValue, byte.MaxValue, sizeof(byte));

            //short
            Console.WriteLine("short:\n min: {0} max: {1} || size: {2}", short.MinValue, short.MaxValue, sizeof(short));

            //ushort - unsigned short
            Console.WriteLine("ushort:\n min: {0} max: {1} || size: {2}", ushort.MinValue, ushort.MaxValue, sizeof(ushort));

            //int 
            Console.WriteLine("int:\n min: {0} max: {1} || size: {2}", int.MinValue, int.MaxValue, sizeof(int));

            //uint 
            Console.WriteLine("uint:\n min: {0} max: {1} || size: {2}", uint.MinValue, uint.MaxValue, sizeof(uint));

            //long
            Console.WriteLine("long:\n min: {0} max: {1} || size: {2}", long.MinValue, long.MaxValue, sizeof(long));

            //ulong 
            Console.WriteLine("ulong:\n min: {0} max: {1} || size: {2}", ulong.MinValue, ulong.MaxValue, sizeof(ulong));

            //float
            Console.WriteLine("float:\n min: {0} max: {1} || size: {2}", float.MinValue, float.MaxValue, sizeof(ulong));
            //double
            Console.WriteLine("double:\n min: {0} max: {1} || size: {2}", double.MinValue, double.MaxValue, sizeof(double));
            //decimal
            Console.WriteLine("decimal:\n min: {0} max: {1} || size: {2}", decimal.MinValue, decimal.MaxValue, sizeof(decimal));


            //char
            Console.WriteLine("char:\n min: {0} max: {1} || size: {2}", char.MinValue, char.MaxValue, sizeof(char));


            //string


            //stringbuilder

            StringBuilder text1 = new StringBuilder();
            StringBuilder text2 = new StringBuilder("To be or not to be");
            StringBuilder text3 = new StringBuilder("Hello Dot Net", 1, 5, 5);

            for(char i = 'a'; i <= 'z'; i++)
            {
                text1.Append(i);
            }

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);

        }
    }
}
