using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace QuestionTime.Test
{
    [TestFixture]
    class MainControllerTest
    {
        MainController sut; //Subject Under Test

        [OneTimeSetUp]
        public void TestSetup()
        {
            sut = new MainController();
            sut.setPlayerName("Player 1");
            sut.setNumberQuestions(3);
        }

        [Test]
        public void ShouldSetPlayerGame()
        {
            string expectedResult = sut.getName();
            Assert.That(expectedResult, Is.EqualTo("Player 1"));
        }

        [Test]
        public void ShouldSetNumberQuestions()
        {
            
            int expectedResult = sut.num();
            Assert.That(expectedResult, Is.EqualTo("Player 1"));
        }
    }
}
