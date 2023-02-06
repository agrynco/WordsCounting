using FluentAssertions;
using Xunit;

namespace WordsCounting.Tests;

public class WordCountingHelpers_Tests
{
    [Fact]
    public void CountWords_ShouldReturnNonEmpty()
    {
        var expected = new[]
        {
            new WordCount("Go", 1), new WordCount("do", 2), new WordCount("that", 2), new WordCount("thing", 1),
            new WordCount("you", 1), new WordCount("so", 1), new WordCount("well", 1)
        };

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
        string input = "singlewordstring";

        var expected = new[]
        {
            new WordCount("singlewordstring", 1)
        };

        var actual = input.CountWords();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReadAsText_ShouldRaiseException()
    {
        Assert.Throws<FileDoesNotExistException>(() => "NotExistedFileName".ReadAsText());
    }
    
    [Fact]
    public void ReadAsText_ShouldReadFileOk()
    {
        string fileName = "testFile.txt";
        string fileContent = "some content";
        
        File.WriteAllText(fileName, fileContent);

        fileName.ReadAsText().Should().Be(fileContent);
    }
}