using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPracticeLibrary
{
    public class RepeatedNumber
    {
        public static int MostRepeatedNumber(int[] numbers)
        {
            var dictionary = new Dictionary<int, int>();
            int mostRepeatedValue = 0;
            int mostRepeatedNumber = 0;

            if (numbers == null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i <= numbers.Length-1; i++)
            {
                if (!dictionary.ContainsKey(numbers[i]))
                {
                    dictionary.Add(numbers[i], 1);
                }
                else 
                {
                    dictionary[numbers[i]] += 1;
                    mostRepeatedValue = mostRepeatedValue < dictionary[numbers[i]] ? dictionary[numbers[i]] : mostRepeatedValue;
                    mostRepeatedNumber = mostRepeatedValue <= dictionary[numbers[i]] ? numbers[i] : mostRepeatedNumber;
                }
            }

            return mostRepeatedNumber;
        }
    }
}
