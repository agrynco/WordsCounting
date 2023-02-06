using FluentAssertions;
using Xunit;

namespace WordsCounting.Tests;

public class WordCount_Tests
{
    [Fact]
    public void ToString_ShouldReturnCorrect()
    {
        new WordCount("word", 125).ToString()
            .Should().Be("125: word");
    }
    
    [Fact]
    public void Constructor_ShouldRiseExceptionOnEmptyWord()
    {
        var exception = Assert.Throws<ArgumentException>(() => new WordCount("", 1));
        exception.Message.Should().Contain("word");
    }
    
    [Fact]
    public void Constructor_ShouldRiseExceptionOnWrongCount()
    {
        var exception = Assert.Throws<ArgumentException>(() => new WordCount("word", 0));
        exception.Message.Should().Contain("count");
    }
}