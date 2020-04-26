namespace Try.S3626
{
    using System;
    using NSubstitute;
    using Xunit;

    public class UnitTest1
    {
        public readonly ICalculator SUT = Substitute.For<ICalculator>();

        [Fact]
        public void Test1_Compliant()
        {
            SUT.Add(-1, -1).Returns(x => { throw new Exception(); });

            Assert.Throws<Exception>(() => SUT.Add(-1, -1));
        }

        [Fact]
        public void Test1_Noncompliant()
        {
            SUT.Add(-1, -1).Returns(x => throw new Exception());

            Assert.Throws<Exception>(() => SUT.Add(-1, -1));
        }
    }
}
