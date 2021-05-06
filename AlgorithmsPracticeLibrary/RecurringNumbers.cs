using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPracticeLibrary
{
    public class RecurringNumbers
    {
        public static int[] GetRecurringNumbers(int[][] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            var recurringNumbers = new List<int>();
            var tempDict = new Dictionary<int, int>();

            foreach (int[] subArray in input)
            {
                for (int i = 0; i <= subArray.Length - 1; i++)
                {
                    if (!tempDict.ContainsKey(subArray[i]))
                    {
                        tempDict.Add(subArray[i], 1);
                    }
                    else {

                        if (!recurringNumbers.Contains(subArray[i]))
                        {
                            recurringNumbers.Add(subArray[i]);
                        }
                    }
                }
            }


           return recurringNumbers.ToArray();
        }
    }
}
