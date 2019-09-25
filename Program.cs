using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyConversion();
        }
        private static void CurrencyConversion()
        {
            Console.WriteLine("Please enter your CopperCoin amount");
            int coins = int.Parse(Console.ReadLine());
            int platinumCoin, goldCoin, silverCoin, copperCoin;
            string exit;

            Converting(coins, out platinumCoin, out goldCoin, out silverCoin, out copperCoin);
            Overview(platinumCoin, goldCoin, silverCoin, copperCoin);

            Console.WriteLine();
            Console.WriteLine("Would you like to convert any other CopperCoin amount? Yes | No");
            exit = Console.ReadLine();
            switch (exit)
            {
                case "Yes":
                    Console.Clear();
                    CurrencyConversion();
                    break;
                case "yes":
                    Console.Clear();
                    CurrencyConversion();
                    break;
                default:
                    break;
            }
            Console.ReadLine();

        }

        private static void Overview(int platinumCoin, int goldCoin, int silverCoin, int copperCoin)
        {
            Console.WriteLine("Platinum coins: " + platinumCoin);
            Console.WriteLine("Gold coins: " + goldCoin);
            Console.WriteLine("Silver coins: " + silverCoin);
            Console.WriteLine("Copper coins: " + copperCoin);
        }

        private static void Converting(int coins, out int platinumCoin, out int goldCoin, out int silverCoin, out int copperCoin)
        {
            platinumCoin = coins / 1000;
            int coinRest = coins % 1000;
            goldCoin = coinRest / 100;
            coinRest = coins % 100;
            silverCoin = coinRest / 10;
            copperCoin = coinRest % 10;
        }
    }
}
