using Assignment6;

namespace ClientApp
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Assignment6.NumericFunction numericFunction=new Assignment6.NumericFunction();

            Console.WriteLine("Main Menu");
            //Console.WriteLine("1. Add ");
            //int ch = Byte.Parse(Console.ReadLine());
            //switch (ch)
            //{
            //    case 1:
            //        Console.WriteLine(Obj.Add(1, 2, 3, 4, 5, 65, 67, 7));
            //        break;
            //    case 2:
            //        int? num1 = null;
            //        int num2 = 20;
            //        num1 = Int32.TryParse(Console.ReadLine(), out int i) ? i : null;
            //        Obj.Subtract(num1, num2);
            //        break;
            //    case 3:
            //        Console.WriteLine(Obj.Divide(10, 2));
            //        break;
            //}

                  
                    //Console.WriteLine(numericFunctions.Add(1, 2, 3, 4, 5, 6));
                    //numericFunctions.Add(1, 2, 3, 4, 5, 6);
                    string AllEvens = numericFunction.AllEven(4, 30);
                    Console.WriteLine(AllEvens);
                    Console.WriteLine(numericFunction.PrintTable(7));
            string AllOdds = numericFunction.AllOdd(1, 10);
            Console.WriteLine(AllOdds);
            string AllPrimes = numericFunction.AllPrime(1, 10);
            Console.WriteLine(AllPrimes);
            Console.WriteLine(numericFunction.Reverse(123));

            ClientApp.StringFunction stringFunction = new ClientApp.StringFunction();

            int count = stringFunction.CountCharacter();
            Console.WriteLine(count);
        }
        }
    }
