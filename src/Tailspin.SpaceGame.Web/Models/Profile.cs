using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    public class Profile : Model
    {
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty(PropertyName = "achievements")]
        public string[] Achievements { get; set; }
    }
}