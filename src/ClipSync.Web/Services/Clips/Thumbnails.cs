using Newtonsoft.Json;

namespace ClipSync.Handler.Services.Clips
{
    public class Thumbnails
    {
        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("tiny")]
        public string Tiny { get; set; }
        
    }
}