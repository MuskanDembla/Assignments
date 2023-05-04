using System.IO;
using static System.Net.WebRequestMethods;

namespace Assignment7
{
    internal class Program
    {
        public static void Main()
        {
            //if (!Directory.Exists("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo"))
            //{
            //    Directory.CreateDirectory("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo");
            //}
            //Directory.CreateDirectory("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\demo1");
            //Directory.CreateDirectory("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\demo2");

            //File.Create("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\demo1\\file1.txt");
            //FileInfo fs=new FileInfo("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\demo2\\file2.txt");
            //fs.Create();

            //string str = "Hello and Welcome";
            //File.AppendAllText("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\demo1\\file1.txt", str);
            //File.AppendAllText("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\demo2\\file2.txt", "GoodBye");

            //string[] list = Directory.GetDirectories("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo");
            //File.Copy("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\demo1\\file1.txt", "C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\demo2\\file2.txt");

            //string[] list = Directory.GetDirectories("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo");
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(Directory.GetCreationTime("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo"));
            // System.IO.File.Delete("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\demo1\\file1.txt");

            //FileStream fs = new FileStream("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\text3.txt", FileMode.Append, FileAccess.Write);
            //StreamWriter writer = new StreamWriter(fs);

            //writer.WriteLine("hello my name is xyz");
            //writer.Close();


            StreamReader reader = new StreamReader("C:\\Users\\Muskan.Dembla\\source\\repos\\Assignment1\\Assignment7\\demo\\text3.txt");
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();

        }

    }
}
