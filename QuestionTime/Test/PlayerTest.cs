using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace QuestionTime.Test
{
    [TestFixture]
    class PlayerTest
    {
        Player sut; //Subject Under Test
        [OneTimeSetUp]
        public void TestSetup()
        {
            sut = new Player();
        }

        [Test]
        public void ShouldCreatePlayerWithDefaultZeroScore()
        {
            int expectedResult = sut.Score;
            Assert.That(expectedResult, Is.EqualTo(0));
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            sut = null;
        }
    }
}
