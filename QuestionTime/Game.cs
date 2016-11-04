using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTime
{
    class Game
    {
        private List<Question> _questions;
        private int _numberOfQuestions;
        private int _realNumberOfQuestions;
        private int _currentQuestion;
        
        public Game()
        {
            _numberOfQuestions = 0;
            _currentQuestion = 0;
            _questions = new List<Question>();
        } 

        public Question getQuestion()
        {
            if(_currentQuestion < _questions.Count)
            {
                Question tempQuestion = _questions.ElementAt(_currentQuestion);
                _currentQuestion++;
                return tempQuestion;
            } else
            {
                return null;
            }
        }

        public void makeQuestions()
        {
            prepareQuestions();
            randomQuestions();
            cutList();
        }

        public void cutList()
        {
            if (_questions.Count > _numberOfQuestions)
            {
                _questions.RemoveRange(_numberOfQuestions - 1, _questions.Count - _numberOfQuestions);
                _realNumberOfQuestions = _numberOfQuestions;
            } else
            {
                _realNumberOfQuestions = _questions.Count;
            }
        }

        public void randomQuestions()
        {
            _questions.Shuffle();
        }

        private void prepareQuestions()
        {
            string[] txtLines = readFile();

            foreach (string line in txtLines)
            {
                Console.WriteLine(line);
                string[] formatedLine = line.Split(new string[] { "*/*" }, StringSplitOptions.None);
                List<string> answers = formatAnswers(formatedLine[1]);
                Question newQuestion = new Question(formatedLine[0], answers, Int32.Parse(formatedLine[2]), Int32.Parse(formatedLine[3]));
                _questions.Add(newQuestion);
            } 
        }

        private string[] readFile()
        {
            return System.IO.File.ReadAllLines("questions.txt");
        }

        private List<string> formatAnswers(string pAnswers)
        {
            return pAnswers.Split(']').ToList();
        }

        public int NumberOfQuestions { get { return _numberOfQuestions; } set { _numberOfQuestions = value; } }
        public int RealNumberOfQuestions { get { return _realNumberOfQuestions; } }
        public List<Question> QuestionList { get { return _questions; } }
    }
}
