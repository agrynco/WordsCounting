namespace WordsCounting.Tests;

public static class DictionaryHelpers
{
    public static WordCount[] ToWordCountArray(this Dictionary<string, int> dictionary)
    {
        return dictionary.Select(g => new WordCount(g.Key, g.Value)).ToArray();
    }
}