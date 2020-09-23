using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();

            //foreach (var scrambledWord in scrambledWords)
            //{
            //    foreach (var word in wordList)
            //    {
            //        //scrambled word already matches word
            //        if (scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
            //        {
            //            matchedWords.Add(BuildMatchedWord(scrambledWord, word));
            //        }
            //        else
            //        {
            //            //convert strings into char array
            //            char [] scrambledWordArray = scrambledWords.ToCharArray();
            //            char[] wordListArray = wordList.ToCharArray();

            //            //sort both character arrays (Array.sort())
            //            Array.Sort(scrambledWordArray);
            //            Array.Sort(wordListArray);
            //            //act -> sort -> act
            //            //cat -> sort -> act

            //            //compare sorted char arrays or convert to string and compare 
            //            scrambledWordArray.ToString();
            //            wordListArray.ToString();

            //            foreach (var scrambledWord2 in scrambledWordArray)
            //            {
            //                foreach (var word2 in wordList)
            //                {
            //                    //if they are equal, add to matchedWords list
            //                    if (scrambledWord2.Equals(word2, StringComparison.OrdinalIgnoreCase))
            //                    {
            //                        matchedWords.Add(BuildMatchedWord(scrambledWord2, word2));
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            MatchedWord BuildMatchedWord(string scrambledWord, string word)
            {
                MatchedWord matchedWord = new MatchedWord
                {
                    ScrambledWorld = scrambledWord,
                    Word = word
                };

                return matchedWord;
            }

            return matchedWords;
        }

    }
}
