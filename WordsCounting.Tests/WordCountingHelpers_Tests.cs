using FluentAssertions;
using Xunit;

namespace WordsCounting.Tests;

public class WordCountingHelpers_Tests
{
    [Fact]
    public void CountWords_ShouldReturnNonEmpty()
    {
        var expected = new Dictionary<string, int>
        {
            { "Go", 1 },
            { "do", 2 },
            { "that", 2 },
            { "thing", 1 },
            { "you", 1 },
            { "so", 1 },
            { "well", 1 }
        }.ToWordCountArray();

        var actual = "Go do that thing that you do so well".CountWords().ToArray();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CountWords_ShouldReturnEmpty()
    {
        var actual = "".CountWords();

        actual.Count().Should().Be(0);
    }

    [Fact]
    public void CountWords_ShouldReturnOneElement()
    {
        const string INPUT = "singlewordstring";

        var expected = new[]
        {
            new WordCount(INPUT, 1)
        };

        var actual = INPUT.CountWords();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReadAsText_ShouldRaiseException()
    {
        const string EXPECTED = "NotExistedFileName";
        
        var fileDoesNotExistException = Assert.Throws<FileDoesNotExistException>(() => EXPECTED.ReadAsText());
        
        fileDoesNotExistException.FileName.Should().Be(EXPECTED);
    }

    [Fact]
    public void ReadAsText_ShouldReadFileOk()
    {
        const string FILE_NAME = "testFile.txt";
        const string FILE_CONTENT = "some content";

        File.WriteAllText(FILE_NAME, FILE_CONTENT);

        FILE_NAME.ReadAsText().Should().Be(FILE_CONTENT);
    }
}