namespace WordsCounting;

public record WordCount
{
    public WordCount(string word, int count)
    {
        if (word == "")
        {
            throw new ArgumentException("Parameter can not be empty", nameof(word));
        }

        if (count < 1)
        {
            throw new ArgumentException("Parameter can not be 0 or negative", nameof(count));
        }

        Word = word;
        Count = count;
    }

    public int Count { get; }

    public string Word { get; }

    public override string ToString()
    {
        return $"{Count}: " + Word;
    }
}