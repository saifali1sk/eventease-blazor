namespace EventEase.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime Date { get; set; }
        public List<string> Attendees { get; set; } = new();
    }
}
