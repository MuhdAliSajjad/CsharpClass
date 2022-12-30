//using System;

//namespace StockProfit
//{
//    class Program
//    {


//        public static int MaxProfit(int[] prices)
//        {
//            // Edge case: if the array has fewer than 2 elements, we can't make a profit
//            if (prices.Length < 2)
//            {
//                return 0;
//            }

//            // Initialize the minimum price and maximum profit to the first element in the array
//            int minPrice = prices[0];
//            int maxProfit = 0;

//            // Iterate through the rest of the array and update the minimum price and maximum profit as needed
//            for (int i = 1; i < prices.Length; i++)
//            {
//                // Update the minimum price if we find a new lowest price
//                minPrice = Math.Min(minPrice, prices[i]);

//                // Update the maximum profit if we find a new highest profit
//                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
//            }

//            return maxProfit;
//        }

//        static void Main(string[] args)
//        {
//            // Test cases
//            int[] prices1 = { 7, 1, 5, 3, 6, 4 };
//            int[] prices2 = { 7, 6, 4, 3, 1 };

//            Console.WriteLine("The maximum profit for first price: " + MaxProfit(prices1)); // should output 5
//            Console.WriteLine("The maximum profit for second price: " + MaxProfit(prices2)); // should output 0
//        }
//    }
//}
