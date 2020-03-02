using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    public abstract class Model
    {
        [JsonProperty(PropertyName = "id")] public string Id { get; set; }
    }
}