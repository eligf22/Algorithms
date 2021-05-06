using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPracticeLibrary
{
    public class Palindrome
    {
        public static bool IsPalindrome(char[] text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }

            if (text.Length > 1)
            {
                int endIndex = text.Length - 1;

                for (int i = 0; i <= endIndex; i++)
                {
                    if (text[i] != text[endIndex])
                    {
                        return false;
                    }
                    endIndex--;
                }
            }

            return true;
        }

    }
}
