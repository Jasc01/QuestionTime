using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;

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
            sut.NumberOfQuestions = 4;
        }

        [Test]
        public void ShouldMakeQuestions()
        {
            sut.makeQuestions();
            List<Question> realList = sut.QuestionList;
            Assert.IsNotEmpty(realList);
        }

        [Test]
        public void ShouldorderQuestionsByDifficulty()
        {
            sut.setDefaultQuestions();
            sut.resetQuestionList();
            sut.NumberOfQuestions = 4;
            sut.makeQuestions();
            Question expected = sut.getQuestion();
            Assert.That(expected.Difficulty, Is.EqualTo(1));
        }

        [Test]
        public void ShouldSetNumberOfQuestions()
        {
            sut.NumberOfQuestions = 4;
            int expected = sut.NumberOfQuestions;
            Assert.That(expected, Is.EqualTo(4));
        }

        [Test]
        public void ShouldSetGameWithoutQuestions()
        {
            sut.NumberOfQuestions = 0;
            sut.makeQuestions();
            Question expectedResult = sut.getQuestion();
            Assert.IsNull(expectedResult);
        }

        

        [Test]
        public void ShouldFormatTextLines()
        {
            string[] array = new string[] { "What is B?*/*A]B]C]D*/*1*/*1", "What is C?*/*A]B]C]D*/*2*/*1", "What is D?*/*A]B]C]D*/*3*/*1", "What is A?*/*A]B]C]D*/*0*/*1" };
            sut.formatTextLines(array);
            List<Question> realList = sut.QuestionList;
            Assert.That(realList.Count(), Is.EqualTo(array.Length));
        }

        [Test]
        public void ShouldReadFile()
        {
            string[] array = new string[] { "What is B?*/*A]B]C]D*/*1*/*1", "What is C?*/*A]B]C]D*/*2*/*1", "What is D?*/*A]B]C]D*/*3*/*1", "What is A?*/*A]B]C]D*/*0*/*1" };
            string[] realList = sut.readFile();
            Assert.That(realList.Count(), Is.EqualTo(array.Length));
        }

        [Test]
        public void ShouldAddQuestion()
        {
            bool expected = sut.addQuestion("Question Add Dummy*/*A]B]C]D*/*2*/*1");
            Assert.IsTrue(expected);
        }

        [Test]
        public void ShouldDeleteQuestion()
        {
            bool expected = sut.deleteQuestion(1);
            Assert.IsTrue(expected);
        }

        [Test]
        public void ShouldEditQuestion()
        {
            bool expected = sut.editQuestion(1, "Question Edit Dummy*/*A]B]C]D*/*2*/*1");
            Assert.IsTrue(expected);
        }


        [OneTimeTearDown]
        public void TestTearDown()
        {
            sut = null;
        }

    }
}
