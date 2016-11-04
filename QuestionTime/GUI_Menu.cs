using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionTime
{
    public partial class GUI_Menu : Form
    {
        private MainController _menuController;

        public GUI_Menu()
        {
            InitializeComponent();
            _menuController = new MainController();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            _menuController.setPlayerName(this.player_name_txtbox.Text);
            _menuController.setNumberQuestions(Decimal.ToInt32(this.number_questions_box.Value));
            GUI_Menu tempGui = this;
            _menuController.makeQuestions();
            _menuController.goNextScreen(ref tempGui);
        }
    }
}
