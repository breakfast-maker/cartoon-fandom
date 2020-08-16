using fandom.Model;
using fandom.WindowsForms.Custom_controls;
using fandom.WindowsForms.Forms.Character;
using fandom.WindowsForms.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fandom.WindowsForms.Forms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private static CharacterForm characterInstance;

        private readonly APIService _characterApiService = new APIService("Character");

        public static CharacterForm GetForm
        {
            get
            {
                if (characterInstance == null || characterInstance.IsDisposed)
                    characterInstance = new CharacterForm();
                return characterInstance;
            }
        }

        private async void CharacterForm_Load(object sender, EventArgs e)
        {
            var data = await _characterApiService.GetAll<List<MCharacter>>();

            foreach(var item in data)
            {
                var character = new CharacterFamilyControl
                {
                    Id = item.Id.ToString(),
                    Icon = ImageWorker.ConvertFromByteArray(item.CharacterMediaFile.Thumbnail),
                    CharacterLabel = $"{item.FirstName} {item.LastName}"
                };

                this.flowLayoutPanel1.Controls.Add(character);
                
            }

        }

        private void addEpisodeButton_Click(object sender, EventArgs e)
        {


            var form = new CreateCharacter();
            form.Show();
        }
    }
}
