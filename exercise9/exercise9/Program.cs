namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print a number of asterisk in a row 
            Console.WriteLine("Enter number of asterisk");
            int asterisk = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < asterisk; j++)
                    {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            //print number of A in a row 
            Console.WriteLine("Enter the number of A");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }
        }
    }
}