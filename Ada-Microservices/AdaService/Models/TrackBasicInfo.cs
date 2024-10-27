namespace AdaService.Models
{
    public record TrackBasicInfo
    {
        public required string Id { get; set; } 
        public required string Name { get; set; }
        public required string Artist { get; set; }
        public string? Album { get; set; }
    }
}
