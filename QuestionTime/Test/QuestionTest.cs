using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace QuestionTime.Test
{
    [TestFixture]
    class QuestionTest
    {
        Question sut; //SetUp Object (First instance)
        List<String> answerList;
        int idAnswer,difficulty;

        [OneTimeSetUp]
        public void TestSetup()

        {
            answerList = new List<String>();
            answerList.Add("A");
            answerList.Add("B");
            answerList.Add("C");
            idAnswer = 1;
            difficulty = 1;
            sut = new Question("¿Question?",answerList,idAnswer,difficulty);
        }

        [Test]
        public void ShouldGetQuestion()
        {
            string expectedResult = sut.QuestionText;
            Assert.That(expectedResult, Is.EqualTo("¿Question?"));
        }

        [Test]
        public void ShouldGetAnswerList()
        {
            List<String> expectedResult = sut.Answers;
            CollectionAssert.AreEqual(expectedResult, answerList);
        }

        [Test]
        public void ShouldGetAnswerId()
        {
            int expectedResult = sut.IDAnswer;
            Assert.That(expectedResult, Is.EqualTo(idAnswer));
        }

        [Test]
        public void ShouldGetDifficulty()
        {
            int expectedResult = sut.Difficulty;
            Assert.That(expectedResult, Is.EqualTo(difficulty));
        }
    }
}
