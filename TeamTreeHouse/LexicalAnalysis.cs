using System.Collections.Generic;

namespace Treehouse.CodeChallenges
{
    public class LexicalAnalysis
    {
        public Dictionary<string, int> WordCount = new Dictionary<string, int>();

        //Code the AddWord method such that, WordCount will contain the number of times the AddWord method has been called with a given word.
        //For example, if AddWord is called twice with the word "rock" then WordCount["rock"] will be 2.

        public void AddWord(string word)
        {
            if (WordCount.ContainsKey(word))
            {
                WordCount[word] = WordCount[word] + 1;
            }

            else
            {
                WordCount.Add(word, 1);
            }
        }
        //The method should return a dictionary of 
        //all of the words that have a count greater than the parameter passed in. The dictionary should contain the word and the word's count.
        public Dictionary<string, int> WordsWithCountGreaterThan(int idonkknow)
        {
            Dictionary<string, int> biggerWords = new Dictionary<string, int>();
            foreach (var wordCountKey in WordCount.Keys)
            {
                if (WordCount[wordCountKey] > idonkknow)
                {
                    biggerWords.Add(wordCountKey, WordCount[wordCountKey]);
                }

            }
            return biggerWords;
        }
    }
}
