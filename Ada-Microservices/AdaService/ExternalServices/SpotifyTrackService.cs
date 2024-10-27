using AdaService.Interfaces;
using AdaService.Models;

namespace AdaService.ExternalServices
{
    public class SpotifyTrackService : ITrackService

    {
        private readonly HttpClient _httpClient;

        public SpotifyTrackService(HttpClient httpClient) => _httpClient = httpClient;

        public string GetTrackId(string artist, string songTitle)
        {
            throw new NotImplementedException();
        }

        public TrackProperties GetTrackInfo(string trackId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TrackBasicInfo> GetTracks(string queryString)
        {
            throw new NotImplementedException();
        }
    }
}
