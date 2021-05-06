using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPracticeLibrary
{
    public class AppleStock
    {
        public static int GetMaxProfit(int[] stockPrices)
        {
            if (stockPrices.Length < 2)
            {
                throw new ArgumentException();
            }

            int minPrice = stockPrices[0];
            int maxPrice = 0;
            int minPriceIndex = 0;

            for (int i = 0; i <= stockPrices.Length - 1; i++)
            {
                minPriceIndex = stockPrices[i] < minPrice ? i : minPriceIndex;
                minPrice = stockPrices[i] < minPrice ? stockPrices[i] : minPrice;
            }

            if(minPriceIndex < stockPrices.Length - 1)
            {
                for (int i = minPriceIndex + 1; i <= stockPrices.Length - 1; i++)
                {
                    maxPrice = stockPrices[i] > maxPrice ? stockPrices[i] : maxPrice;
                }

            }

            int maxProfit = maxPrice - minPrice;

            return maxProfit;

        }
    }
}
