using Newtonsoft.Json;

namespace ClipSync.Services.Clips
{
    public class Vod
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}