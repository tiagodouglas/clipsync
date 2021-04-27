using System.Collections.Generic;

namespace ClipSync.Services.Clips
{
    public class TopClipsResponse
    {
        public IEnumerable<Clip> Clips { get; set; }
    }
}