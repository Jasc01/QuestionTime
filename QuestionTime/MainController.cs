using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionTime
{
    public class MainController
    {
        private Player _player;
        private Game _mainGame;
        private GUI_Game _guiGame;
        private GUI_Menu _guiMenu;
        private Question _tempQuestion;

        public MainController()
        {
            _player = new Player();
            _mainGame = new Game();
        }

        public void makeQuestions()
        {
            _mainGame.makeQuestions();
        }

        public void setNumberQuestions(int pNumberQuestions)
        {
            _mainGame.NumberOfQuestions = pNumberQuestions;
        }

        public void setPlayerName(string pPlayerName)
        {
            _player.Name = pPlayerName;
        }

        public void goNextScreen(ref GUI_Menu pGuiMenu)
        {
            _guiMenu = pGuiMenu;
            _guiGame = new GUI_Game();
            MainController tempController = this;
            _guiGame.setController(ref tempController);
            setBasicInfo();
            setQuestion();
            _guiGame.Show();
            _guiGame.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            pGuiMenu.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _guiMenu.Close();
        }

        public void getAnotherQuestion()
        {
            _tempQuestion = _mainGame.getQuestion();
        }

        public void setQuestion()
        {
            getAnotherQuestion();
            if(_tempQuestion != null)
            {
                _guiGame.question_text_txt.Text = _tempQuestion.QuestionText;
                _guiGame.option_a.Text = _tempQuestion.Answers.ElementAt(0);
                _guiGame.option_b.Text = _tempQuestion.Answers.ElementAt(1);
                _guiGame.option_c.Text = _tempQuestion.Answers.ElementAt(2);
                _guiGame.option_d.Text = _tempQuestion.Answers.ElementAt(3);
            }
            else
            {
                _guiGame.finishGame();
            }
        }

        public void setBasicInfo()
        {
            _guiGame.player_name_txt.Text = _player.Name;
            _guiGame.player_score_txt.Text = "" + getScore();
        }

        public bool checkAnswer(int pAnswer)
        {
            return _tempQuestion.IDAnswer == pAnswer;
        }

        public void sumPoint()
        {
            _player.Score += 1;
        }

        public void updateScore()
        {
            _guiGame.player_score_txt.Text = "" + _player.Score;
        }

        public int getScore()
        {
            return _player.Score;
        }

        public string getName()
        {
            return _player.Name;
        }

        public string getRightAnswer()
        {
            return _tempQuestion.Answers.ElementAt(_tempQuestion.IDAnswer);
        }

        public void editQuestion(int pIndex, string pQuestion)
        {
            _mainGame.editQuestion(pIndex, pQuestion);
        }

        public void addQuestion(string pQuestion)
        {
            _mainGame.addQuestion(pQuestion);
        }

        public void deleteQuestion(int pIndex)
        {
            _mainGame.deleteQuestion(pIndex);
        }
    }
}
