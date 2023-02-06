using System.Diagnostics.CodeAnalysis;

namespace WordsCounting;

public static class WordCountingHelpers
{
    [ExcludeFromCodeCoverage]
    public static void PrintResult(this IEnumerable<WordCount> wordsCount)
    {
        wordsCount.ToList().ForEach(wordCount => { Console.WriteLine(wordCount.ToString()); });
    }

    public static string ReadAsText(this string fileName)
    {
        if (!File.Exists(fileName))
        {
            throw new FileDoesNotExistException(fileName);
        }

        return File.OpenText(fileName).ReadToEnd();
    }

    public static IEnumerable<WordCount> CountWords(this string input)
    {
        return input.Split(" ")
            .Where(word => !string.IsNullOrEmpty(word))
            .GroupBy(word => word)
            .Select(group => new WordCount(group.Key, group.Count())).ToList();
    }
}