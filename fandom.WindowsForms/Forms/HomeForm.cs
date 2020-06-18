using fandom.WindowsForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fandom.WindowsForms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void userLabel_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            userForm.Show();
        }

        private void seasonLabel_Click(object sender, EventArgs e)
        {
            var seasonForm = new SeasonForm();
            seasonForm.Show();
        }

        private void episodeLabel_Click(object sender, EventArgs e)
        {
            var episodeForm = new EpisodeForm();
            episodeForm.Show();
        }

        private void characterLabel_Click(object sender, EventArgs e)
        {
            var characterForm = new CharacterForm();
            characterForm.Show();
        }
    }
}
