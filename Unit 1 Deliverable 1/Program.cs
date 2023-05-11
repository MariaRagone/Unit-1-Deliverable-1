using System;
namespace SnackInventory
{
    class Program
    {
        public static void Main()
        {
            //Starting stock values and restock values
            int sodaStock = 100;
            int sodaRestock = 40;
            int chipsStock = 40;
            int chipsRestock = 20;
            int candyStock = 60;
            int candyRestock = 40;
            {
                //Ask how many sodas were sold
                Console.Write("How many sodas have been sold today? 100 in stock. ");
                int sodaSold = int.Parse(Console.ReadLine());
                int sodaLeft = sodaStock - sodaSold;


                if (sodaLeft > sodaRestock)

                    Console.WriteLine("You now have: " + sodaLeft);
                if (sodaLeft <= sodaRestock && sodaSold <= sodaStock)

                    Console.WriteLine("You now have: " + sodaLeft);
                if (sodaSold > sodaStock)
                    Console.WriteLine("That value is too high. Stock not adjusted. ");

                {
                    //Ask how many chips were sold
                    Console.Write("How many chips have been sold today? 40 in stock. ");
                    int chipsSold = int.Parse(Console.ReadLine());
                    int chipsLeft = chipsStock - chipsSold;

                    if (chipsLeft > chipsRestock)
                        Console.WriteLine("You now have: " + chipsLeft);

                    if (chipsLeft <= chipsRestock && chipsSold <= chipsStock)
                        Console.WriteLine("You now have: " + chipsLeft);

                    if (chipsSold > chipsStock)
                        Console.WriteLine("That value is too high. Stock not adjusted.");

                    //Ask how many candies were sold
                    Console.Write("How many candies have been sold today? 60 in stock. ");
                    int candySold = int.Parse(Console.ReadLine());
                    int candyLeft = candyStock - candySold;

                    if (candyLeft > candyRestock)
                        Console.WriteLine("You now have: " + candyLeft);

                    if (candyLeft <= candyRestock && candySold <= candyStock)
                        Console.WriteLine("You now have: " + candyLeft);

                    if (candySold > candyStock)
                        Console.WriteLine("That value is too high. Stock not adjusted.");

                    //Notify which items need to be ordered
                    Console.WriteLine("Here is what you need to order.");

                    if (sodaLeft <= sodaRestock && sodaSold <= sodaStock)
                        Console.Write("soda, ");

                    if (chipsLeft <= chipsRestock && chipsSold <= chipsStock)
                        Console.Write("chips, ");

                    if (candyLeft <= candyRestock && candySold <= candyStock)

                        Console.WriteLine("candy");
                }

            }
        }
    }
}
