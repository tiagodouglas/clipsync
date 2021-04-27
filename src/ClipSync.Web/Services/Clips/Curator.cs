using Newtonsoft.Json;

namespace ClipSync.Services.Clips
{
    public class Curator
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("channel_url")]
        public string ChannelUrl { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
        
    }
}