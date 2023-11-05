using FluentAssertions;
using FluentAssertions.LanguageExt;
using LanguageExt.Common;

namespace FluentAssertionsSuccessExample;

public class FinFailTest
{
    [Fact]
    public void BeFail_Should_Not_Throw_Missing_Method_Exception()
    {
        var action = () => FinFail<int>(Error.New("")).Should().BeFail();
        action.Should().NotThrow();
    }
}