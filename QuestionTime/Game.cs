using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuestionTime
{
    class Game
    {
        private List<Question> _questions;
        private int _numberOfQuestions;
        private int _realNumberOfQuestions;
        private int _currentQuestion;
        private string path = AppDomain.CurrentDomain.BaseDirectory; //http://stackoverflow.com/a/1776377/4752488


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
                Console.WriteLine(_currentQuestion);
                return tempQuestion;
            } else
            {
                return null;
            }
        }

        public void resetQuestionList()
        {
            _questions.Clear();
        }

        public void makeQuestions()
        {
            prepareQuestions();
            randomQuestions();
            cutList();
            orderQuestionsByDifficulty();
        }

        public void orderQuestionsByDifficulty()
        {
            Question[] tempList = _questions.ToArray();
            Question t;
            for (int a = 1; a < tempList.Length; a++)
            {
                for (int b = tempList.Length - 1; b >= a; b--)
                {
                    if (tempList[b - 1].Difficulty > tempList[b].Difficulty)
                    {
                        t = tempList[b - 1];
                        tempList[b - 1] = tempList[b];
                        tempList[b] = t;
                    }
                }
            }
            _questions = tempList.ToList();
        }

        public void cutList()
        {
            if (_questions.Count > _numberOfQuestions)
            {
                if (_numberOfQuestions == 0)
                {
                    _questions.Clear();
                }else
                {
                    _questions.RemoveRange(_numberOfQuestions - 1, _questions.Count - _numberOfQuestions);
                }
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
            formatTextLines(txtLines);
        }

        public void setDefaultQuestions()
        {
            string[] questions = new string[] { "What is B?*/*A]B]C]D*/*1*/*1", "What is C?*/*A]B]C]D*/*2*/*2", "What is D?*/*A]B]C]D*/*3*/*3", "What is A?*/*A]B]C]D*/*0*/*4" };
            // Create a writer and open the file:
            StreamWriter log = new StreamWriter(path + "questions.txt");
            // Write to the file:
            foreach (string line in questions)
            {
                log.WriteLine(line);
            }
            // Close the stream:
            log.Close();
        }

        public void formatTextLines(string[] txtLines)
        {
            foreach (string line in txtLines)
            {
                Console.WriteLine(line);
                string[] formatedLine = line.Split(new string[] { "*/*" }, StringSplitOptions.None);
                List<string> answers = formatAnswers(formatedLine[1]);
                Question newQuestion = new Question(formatedLine[0], answers, Int32.Parse(formatedLine[2]), Int32.Parse(formatedLine[3]));
                _questions.Add(newQuestion);
            }
        }

        public string[] readFile()
        {
            return System.IO.File.ReadAllLines(path+"questions.txt");
        }

        private List<string> formatAnswers(string pAnswers)
        {
            return pAnswers.Split(']').ToList();
        }

        public bool editQuestion(int pIndex, string pQuestion)
        {
            try
            {
                string[] txtLines = readFile();
                txtLines[pIndex] = pQuestion;
                writeFile(txtLines);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool addQuestion(string pQuestion)
        {   
            try
            {
                string[] txtLines = readFile();
                List<string> tempList = txtLines.ToList();
                tempList.Add(pQuestion);
                txtLines = tempList.ToArray();
                writeFile(txtLines);
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }
        }

        public bool deleteQuestion(int pIndex)
        {
            try
            {
                string[] txtLines = readFile();
                List<string> tempList = txtLines.ToList();
                tempList.RemoveAt(pIndex);
                txtLines = tempList.ToArray();
                writeFile(txtLines);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void writeFile(string[] pArray)
        {
            System.IO.File.WriteAllLines(path + "questions.txt", pArray);
        }

        public int NumberOfQuestions { get { return _numberOfQuestions; } set { _numberOfQuestions = value; } }
        public int RealNumberOfQuestions { get { return _realNumberOfQuestions; } }
        public List<Question> QuestionList { get { return _questions; } }
    }
}
