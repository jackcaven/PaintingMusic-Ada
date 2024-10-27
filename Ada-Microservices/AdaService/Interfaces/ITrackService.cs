using AdaService.Models;

namespace AdaService.Interfaces
{
    public interface ITrackService
    {
        public IEnumerable<TrackBasicInfo> GetTracks(string queryString);
        public string GetTrackId(string artist, string songTitle);
        public TrackProperties GetTrackInfo(string trackId);
    }
}
