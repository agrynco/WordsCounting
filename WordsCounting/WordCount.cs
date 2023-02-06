namespace WordsCounting;

public record WordCount(string Word, int Count)
{
    public override string ToString()
    {
        return $"{Count}:".PadRight(5) + Word;
    }
}