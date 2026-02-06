namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To islam's carpet cleaning service ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("enter number of Small carpets : ");
            int smallcarpet = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number of large carpets : ");
            int largecarpet = int.Parse(Console.ReadLine());
            int countSmallCarpet = smallcarpet * 25 ;
            int countLargeCarpet = largecarpet * 35 ;
            int cost = countSmallCarpet + countLargeCarpet ;
            Console.WriteLine($"Equation: {countSmallCarpet} + {countLargeCarpet} = {countSmallCarpet + countLargeCarpet:C}");
            double tax = cost * 0.06 ;
            Console.WriteLine("Total estimate : " + ($"Equation: {cost} + {tax} = {cost + tax:C}") );
        }
    }
}
