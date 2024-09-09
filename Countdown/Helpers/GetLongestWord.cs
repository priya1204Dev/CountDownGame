using Countdown.Interfaces;
using NHunspell;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Countdown
{
    public class GetLongestWord : IGetLongestWord
    {
        int totallength = 10;
        string noLongestWord = "No Word found";

        public string getLongestMeaningfullWord(string letterDisplay)
        {
            List<string> result = new List<string>();

            // Get all combinations
            for (int len = 1; len <= letterDisplay.Length; len++)
            {
                GenerateCombinations(letterDisplay.ToCharArray(), 0, "", len, result);

            }

            return getLongestValidWordCheck(result);

        }

        public string getLongestValidWordCheck(List<string> result)
        {
            string longestWordFound = noLongestWord;
            if(result.Count!=0)
            {
                longestWordFound = HunspellCheck(result);
            }
          

            return longestWordFound;
        }

        // Function to generate combinations of a given length
        static void GenerateCombinations(char[] input, int start, string current, int length, List<string> result)
        {
            if (current.Length == length)
            {
                // Add permutations of the current combination
                GeneratePermutations(current, 0, result);
                return;
            }

            for (int i = start; i < input.Length; i++)
            {
                GenerateCombinations(input, i + 1, current + input[i], length, result);
            }
        }


        // Function to generate permutations of a given string
        static void GeneratePermutations(string str, int index, List<string> result)
        {
            if (index == str.Length - 1)
            {
                result.Add(str);
                return;
            }

            for (int i = index; i < str.Length; i++)
            {
                str = Swap(str, index, i);
                GeneratePermutations(str, index + 1, result);
                str = Swap(str, index, i); // Backtrack
            }
        }

        // Function to swap two characters in a string
        static string Swap(string str, int i, int j)
        {
            char[] charArray = str.ToCharArray();
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            return new string(charArray);
        }

        public string HunspellCheck(List<string> result )
        {
            using (Hunspell hunspell = new Hunspell("en_US.aff", "en_US.dic"))
            {
                while (totallength > 1)
                {
                    foreach (var word in result.FindAll(x => x.Length == totallength))
                    {
                        if (hunspell.Spell(word))
                        {
                            return word;

                        }

                    }

                    --totallength;

                }

            }
            return noLongestWord;

        }


    }
}
