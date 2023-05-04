using Assignment6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cli
{
    internal static class NumericFunctionsExtended
    {
        public static string AllEven(this NumericFunction numericfunction ,int start,int end)
        {
            StringBuilder stringBuilder=new StringBuilder();    
            for(int i=start; i<end; i++) { 
            if(i%2==0)
                {
                    stringBuilder.Append(i+"\n");
                }
            return stringBuilder.ToString();
            }

        }
    }
}
