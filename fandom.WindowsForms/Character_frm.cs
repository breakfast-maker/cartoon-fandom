using fandom.Model;
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
    public partial class Character_frm : Form
    {
        private readonly APIService _apiService = new APIService("Character");

        public Character_frm()
        {
            InitializeComponent();
        }

        private async void Character_frm_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<MCharacter>>();
            dataGridView1.DataSource = result;
        }
    }
}
