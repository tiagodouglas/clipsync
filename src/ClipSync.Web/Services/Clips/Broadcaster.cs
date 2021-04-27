using Newtonsoft.Json;

namespace ClipSync.Services.Clips
{
    public class Broadcaster
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
        public string logo { get; set; }
    }
}