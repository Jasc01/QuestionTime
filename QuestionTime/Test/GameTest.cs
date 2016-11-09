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
        List<String> answerList = new List<String>();

        [OneTimeSetUp]
        public void TestSetup()
        {
            sut = new Game();
            answerList.Add("A");
            answerList.Add("B");
            answerList.Add("C");
            answerList.Add("D");
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
        public void ShouldSetNumberOfQuestions()
        {
            int expected = sut.NumberOfQuestions;
            Assert.That(expected, Is.EqualTo(4));
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
