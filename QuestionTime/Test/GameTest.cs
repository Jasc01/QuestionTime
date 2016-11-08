using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace QuestionTime.Test
{
    [TestFixture]
    class GameTest
    {
        Game sut; //Subject Under Test

        [OneTimeSetUp]
        public void TestSetup()
        {
            sut = new Game();
        }

        [Test]
        public void ShouldCreateNewGame()
        {
            Assert.IsNotNull(sut);
        }
    }
}
