using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class StringFunction
    {
        public int CountCharacter()
        {
            Console.WriteLine("enter the sentence");
            string str=Console.ReadLine();
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    count++;
            }

            return count;
        }
        //public static string Reverse(int s)
        //{
        //    string s1 = s.ToString();
        //    char[] charArray = s1.ToCharArray();
        //    Array.Reverse(charArray);
            
        //}

    }
}

