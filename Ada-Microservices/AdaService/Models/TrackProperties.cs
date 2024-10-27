namespace AdaService.Models
{
    public record TrackProperties
    {
        public double Accousticness { get; }
        public double Danceability { get; }
        public double Energy { get; }
        public double Instrumentalness { get; }
        public double Key { get; }
        public double Loudness { get; }
        public double Tempo { get; }
        public double Valence { get; }
    }
}
