using fandom.Model.Models;
using fandom.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fandom.WindowsForms.Forms.Season
{
    public partial class AddSeason : Form
    {
        private readonly APIService _episodeApiService = new APIService("Episode");

        public AddSeason()
        {
            InitializeComponent();
        }

        private async void AddSeason_Load(object sender, EventArgs e)
        {
            var result = await _episodeApiService.Get<List<MEpisode>>(new EpisodesSeasonRequest { isAssigned = false });
            this.dataGridView1.DataSource = result;
        }


    }
}
