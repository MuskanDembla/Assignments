using Assignment6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    internal static class NumericFunctionExtended
    {
        public static string AllEven(this NumericFunction numericFunction,
             int start, int end)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                    stringBuilder.Append(i + "\n");
            }
            return stringBuilder.ToString();
        }
        public static string PrintTable(this NumericFunction numericFunction, int num)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                stringBuilder.Append(num + " * " + i + " = " + num * i + "\n");
            }
            return stringBuilder.ToString();
        }
        public static string AllOdd(this NumericFunction numericFunction,
             int start, int end)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = start; i < end; i++)
            {
                if (i % 2 != 0)
                    stringBuilder.Append(i + "\n");
            }
            return stringBuilder.ToString();
        }
        public static string Reverse(this NumericFunction numericFunction, int s)
        {
            string s1 = s.ToString();
            char[] charArray = s1.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string AllPrime(this NumericFunction numericFunction,
             int start, int end)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            for (int i = start; i < end; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i!=1)
                {
                    stringBuilder.Append(i + "\n");
                }
            }
            return stringBuilder.ToString();
        }

    }
}

