using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    public class Score : Model
    {
        [JsonProperty(PropertyName = "profileId")]
        public string ProfileId { get; set; }

        [JsonProperty(PropertyName = "score")] public int HighScore { get; set; }

        [JsonProperty(PropertyName = "gameMode")]
        public string GameMode { get; set; }

        [JsonProperty(PropertyName = "gameRegion")]
        public string GameRegion { get; set; }
    }
}