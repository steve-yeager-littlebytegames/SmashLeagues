using Microsoft.Azure.Mobile.Server;

namespace SmashLeaguesService.DataObjects
{
    public class User : EntityData
    {
        public string UserId { get; set; }
        public string Username { get; set; }
    }
}