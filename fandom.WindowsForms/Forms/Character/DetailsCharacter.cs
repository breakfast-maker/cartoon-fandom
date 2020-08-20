using fandom.Model;
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

namespace fandom.WindowsForms.Forms.Character
{
    public partial class DetailsCharacter : Form
    {
        private readonly int _characterId;
        private readonly APIService _characterApiService = new APIService("Character");

        public DetailsCharacter(int id)
        {
            InitializeComponent();
            _characterId = id;
        }

        private async void DetailsCharacter_Load(object sender, EventArgs e)
        {
            ClearData();
            var data = await _characterApiService.GetById<MCharacter>(_characterId);

            BindData(data);

        }

        private void BindData(MCharacter character)
        {
            this.pictureBox1.Image = ImageWorker.ConvertFromByteArray(character.CharacterMediaFile.Thumbnail);
            this.label1.Text = $"{character.FirstName} {character.LastName}";
            this.label2.Text = character.Biography;
            this.label5.Text = character.BirthDate.ToString("dd-MM-yyyy");
            this.label6.Text = character.Occupation;
        }

        private void ClearData()
        {
            this.label1.Text = "";
            this.label2.Text = "";
            this.label5.Text = "";
            this.label6.Text = "";
        }

    }
}
