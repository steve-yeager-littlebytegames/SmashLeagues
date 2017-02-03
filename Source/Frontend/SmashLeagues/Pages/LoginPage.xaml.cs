using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmashLeagues.Pages
{
    public partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnSubmit(object sender, EventArgs e)
        {
            App.Username = await CreateUsername();
            await Navigation.PushAsync(new TodoList());
        }

        private async Task<string> CreateUsername()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                {"id", App.User.UserId},
                {"username", UsernameEntry.Text}
            };
            var task = await App.Client.InvokeApiAsync("Test/SetUser", HttpMethod.Post, parameters);
            return task["username"].ToString();
        }
    }
}