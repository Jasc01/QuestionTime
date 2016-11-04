using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuestionTime
{
    public partial class GUI_Game : Form
    {
        MainController _mainController;

        public GUI_Game()
        {
            InitializeComponent();
        }

        public void setController(ref MainController pMainController)
        {
            _mainController = pMainController;
        }

        private void option_a_Click(object sender, EventArgs e)
        {
            checkAnsView(_mainController.checkAnswer(0));
        }

        private void checkAnsView(bool pAns)
        {
            if(pAns)
            {
                this.right_answer_pic.Visible = true;
                _mainController.sumPoint();
                _mainController.setQuestion();
            } else
            {
                this.wrong_answer_pic.Visible = true;
                MessageBox.Show("The right answer was: " + _mainController.getRightAnswer());
                _mainController.setQuestion();
            }
        }

        public void finishGame()
        {
            this.option_a.Visible = false;
            this.option_b.Visible = false;
            this.option_c.Visible = false;
            this.option_d.Visible = false;
            this.player_name_txt.Visible = false;
            this.player_score_txt.Visible = false;
            this.question_text_txt.Visible = false;

            this.final_game_txt.Text = "Game Finished\n" + "Score: " + _mainController.getScore() + "\nPlayer: " + _mainController.getName();
            this.final_game_txt.Visible = true;
        }

        private void option_b_Click(object sender, EventArgs e)
        {
            checkAnsView(_mainController.checkAnswer(1));
        }

        private void option_c_Click(object sender, EventArgs e)
        {
            checkAnsView(_mainController.checkAnswer(2));
        }

        private void option_d_Click(object sender, EventArgs e)
        {
            checkAnsView(_mainController.checkAnswer(3));
        }

        private void wrong_answer_pic_Click(object sender, EventArgs e)
        {
            this.wrong_answer_pic.Visible = false;
        }

        private void right_answer_pic_Click(object sender, EventArgs e)
        {
            this.right_answer_pic.Visible = false;
        }
    }
}
