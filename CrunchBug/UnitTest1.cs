using ApprovalTests;
using Xunit;

namespace CrunchBug
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() => Approvals.Verify("blah1");
        [Fact]
        public void Test2() => Approvals.Verify("blah2");
    }
}
