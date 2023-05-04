namespace Assignment5
{
    internal class Program
    {
        static void Main()
        {
            char ch;
            Console.WriteLine("Enter type of Employment:\n p:on payroll\nc:on contract");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'p')
            {
                PayRoll pemp = new PayRoll();
                pemp.getDetails();
                pemp.displayDetails();
            }
            else if (ch == 'c')
            {
                OnContract cemp = new OnContract();
                cemp.getDetails();
                cemp.displayDetails();
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}