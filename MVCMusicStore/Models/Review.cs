namespace MVCMusicStore.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public Album Album { get; set; }
        public string Contents { get; set; }
        public string ReviewerEmail { get; set; }

    }
}