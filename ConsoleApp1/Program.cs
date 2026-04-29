namespace ConsoleApp1
{
    internal class Program
    {



        static void Main(string[] args)
        {
            int smallPrice = 25;
            int largePrice = 35;
            double Taxrate = 0.06;


            Console.Write("Number of small carpets:");
            int countsmall = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets:");

            int countlarage = Convert.ToInt32(Console.ReadLine());



            double totalcost = (countsmall * smallPrice) + (countlarage * largePrice);
            double tax = totalcost * Taxrate;






            Console.WriteLine($"Price per small room: {smallPrice:C}");
            Console.WriteLine($"Price per large room: {largePrice:C}");
            Console.WriteLine($"cost:{totalcost:C}");
            Console.WriteLine($"tax:{tax:C}");
            Console.WriteLine("===============================");

            double totalsum = tax + totalcost;

            //Console.WriteLine($"cost:${totalcost,C}}");
            Console.WriteLine($" Price per large room:{totalsum:C} ");
            Console.WriteLine("This estimate is valid for 30 days");




            //Console.WriteLine("salesare tax ate 6%");









        }
    }
}