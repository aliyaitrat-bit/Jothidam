using Xunit;

namespace Jothidam.Tests
{
    public class FirstLaunchTest : BaseTest
    {
        [Fact]
        public void AppLaunchesSuccessfully()
        {
            Assert.NotNull(Driver.SessionId);
        }
    }
}