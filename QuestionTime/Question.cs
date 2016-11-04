using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTime
{
    class Question
    {
        private string _questionText;
        private List<string> _answers;
        private int _idAnswer;
        private int _difficulty;

        public Question(string pQuestionText, List<string> pAnswers, int pIdAnswer, int pDifficulty)
        {
            _questionText = pQuestionText;
            _difficulty = pDifficulty;
            _answers = pAnswers;
            _idAnswer = pIdAnswer;
        }

        public string QuestionText { get { return _questionText; } }
        public int Difficulty { get { return _difficulty; } }
        public List<string> Answers { get { return _answers; } }
        public int IDAnswer { get { return _idAnswer; } }
    }
}
