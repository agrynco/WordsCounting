using FluentAssertions;
using Xunit;

namespace WordsCounting.Tests;

public class FileDoesNotExistExceptionTests
{
    [Fact]
    public void FileDoesNotExistException_ShouldInitializeFileNameProperty()
    {
        const string EXPECTED = "fileName";
        
        var actual = new FileDoesNotExistException(EXPECTED);

        actual.FileName.Should().Be(EXPECTED);
    }
}