using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace QuestionTime.Test
{
    [TestFixture]
    class GUI_GameTest
    {
        MainController tempMain; //Subject Under Test
        GUI_Game sut;

        [OneTimeSetUp]
        public void TestSetup()
        {

            tempMain = new MainController();
            tempMain.setPlayerName("Player 1");
            tempMain.setNumberQuestions(1);

            tempMain.makeQuestions();
            
            sut = new GUI_Game();
            sut.setController(ref tempMain);
            tempMain.setGUI_GAME(sut);
            tempMain.setBasicInfo();
            tempMain.setQuestion();
            //_guiGame.Show();
        }

        [Test]
        public void ShouldSetPlayerGUI_GameName()
        {
            string expectedResult = sut.player_name_txt.Text;
            Assert.IsNotNull(expectedResult);
            Assert.That(expectedResult, Is.EqualTo("Player 1"));
        }

        [Test]
        public void ShouldFinishGame()
        {
            sut.finishGame();
            string expectedResult = sut.final_game_txt.Text;
            Assert.IsNotNull(expectedResult);
            Assert.That(expectedResult, Is.EqualTo("Game Finished\nScore: 0\nPlayer: Player 1"));
        }

        [Test]
        public void ShouldSetPlayerGUI_GameScore()
        {
            string expectedResult = sut.player_score_txt.Text;
            Assert.IsNotNull(expectedResult);
            Assert.That(expectedResult, Is.EqualTo("0"));
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            sut = null;
        }
    }
}
