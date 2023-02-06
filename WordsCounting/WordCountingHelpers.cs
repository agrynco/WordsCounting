using System;
using System.Collections.Generic;
using System.Linq;

namespace WordsCounting;

public static class WordCountingHelpers
{
    public static void PrintResult(this IEnumerable<WordCount> wordsCount)
    {
        wordsCount.ToList().ForEach(wordCount =>
        {
            Console.Write($"{wordCount.Count}:".PadRight(5));
            Console.WriteLine(wordCount.Word);
        });
    }
    
    public static IEnumerable<WordCount> CountWords(this string input)
    {
        return input.Split(" ").GroupBy(word => word).Select(group => new WordCount(group.Key, group.Count())).ToList();
    }

}