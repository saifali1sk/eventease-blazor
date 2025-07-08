using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        public List<EventModel> Events { get; set; } = new()
        {
            new EventModel { Id = 1, Title = "Blazor Meetup", Description = "Learn Blazor with us!", Date = DateTime.Today.AddDays(3) },
            new EventModel { Id = 2, Title = "Hackathon", Description = "24-hour coding event", Date = DateTime.Today.AddDays(10) }
        };

        public EventModel? GetEventById(int id) =>
            Events.FirstOrDefault(e => e.Id == id);

        public void AddAttendee(int id, string name)
        {
            var ev = GetEventById(id);
            if (ev != null && !ev.Attendees.Contains(name))
            {
                ev.Attendees.Add(name);
            }
        }
    }
}
