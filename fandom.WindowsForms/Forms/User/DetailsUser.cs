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

namespace fandom.WindowsForms.Forms.User
{
    public partial class DetailsUser : Form
    {
        private readonly int _uId;
        private readonly UserForm uForm = UserForm.GetForm;

        private readonly APIService _userApiService = new APIService("User");


        public DetailsUser(int id)
        {
            _uId = id;
            InitializeComponent();
        }

        private async void DetailsUser_Load(object sender, EventArgs e)
        {
            var result = await _userApiService.GetById<MUser>(_uId);

            BindData(result);

        }

        private void BindData(MUser user)
        {
            this.label1.Text = user.Username;
            this.label2.Text = user.Email;
            foreach (var item in user.Roles)
            {
                if (item.Name == "Administrator")
                {
                    this.label3.Visible = true;
                    this.button1.Enabled = false;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            await _userApiService.Delete<MUser>(_uId);
            await RefreshUserList();
    
            MessageBox.Show($"User is removed");
        }

        private async Task RefreshUserList()
        {
            var usersListView = uForm.usersListView;
            usersListView.Items.Clear();
            await uForm.PopulateListView();
        }

    }
}
