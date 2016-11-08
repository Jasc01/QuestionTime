using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;


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
            sut.makeQuestions();
            sut.getAnotherQuestion();
        }

        [Test]
        public void ShouldSetPlayerGame()
        {
            string expectedResult = sut.getName();
            Assert.IsNotNull(expectedResult);
            Assert.That(expectedResult, Is.EqualTo("Player 1"));
        }

        [Test]
        public void ShouldSumPoint()
        {
            sut.sumPoint();
            int expectedResult = sut.getScore();
            Assert.That(expectedResult, Is.EqualTo(1));
        }

        [Test]
        public void ShouldGetRightAnswer()
        {
            string expectedResult = sut.getRightAnswer();
            Assert.That(expectedResult, Is.EqualTo("A").Or.EqualTo("B").Or.EqualTo("C").Or.EqualTo("D"));
        }

        [Test]
        public void ShouldCheckWrongAnswerUpToLimit()
        {
            bool expectedResult = sut.checkAnswer(5);
            Assert.IsFalse(expectedResult);
        }

        [Test]
        public void ShouldCheckWrongAnswerDownToLimit()
        {
            bool expectedResult = sut.checkAnswer(-1);
            Assert.IsFalse(expectedResult);
        }
    }
}
