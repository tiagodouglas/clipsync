using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ClipSync.Services.Clips;
using Newtonsoft.Json;

namespace ClipSync.Web.Services.Clips
{
    public class ClipService
    {
        private readonly HttpClient _client;

        public ClipService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.twitch.tv/kraken/");
            _client.DefaultRequestHeaders.Add("Client-ID", "");
            _client.DefaultRequestHeaders.Add("Accept", "");
        }

        public async Task<Clip> GetClip(string url)
        {
            var clip = url.Split("https://clips.twitch.tv/"); ;
            var slug = clip[1];

            var response = await _client.GetAsync($"clips/{slug}");

            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<Clip>(await response.Content.ReadAsStringAsync());
        }

        public async Task<IEnumerable<Clip>> GetTopClips(string channel)
        {
            var response = await _client.GetAsync($"clips/top?channel={channel}&period=month&trending=true&limit=20");

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<TopClipsResponse>(json);

            return result.Clips;
        }
    }
}