using FluentAssertions;
using Xunit;

namespace WordsCounting.Tests;

public class WordCountingHelpers_Tests
{
    [Fact]
    public void CountWords_Test()
    {
        var actual = "Go do that thing that you do so well".CountWords().ToArray();
        
        actual.Single(cw => cw.Word == "Go").Count.Should().Be(1);
        actual.Single(cw => cw.Word == "do").Count.Should().Be(2);
        actual.Single(cw => cw.Word == "that").Count.Should().Be(2);
        actual.Single(cw => cw.Word == "thing").Count.Should().Be(1);
        actual.Single(cw => cw.Word == "you").Count.Should().Be(1);
        actual.Single(cw => cw.Word == "so").Count.Should().Be(1);
        actual.Single(cw => cw.Word == "well").Count.Should().Be(1);
    }
}