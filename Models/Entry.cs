namespace Prog_poe.Models
{
    public class Entry
    {

        public int Id { get; set; }

        public int ParticipantId { get; set; }

        public User? Participant { get; set; }

        public int EventId { get; set; }

        public Event? Event { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public DateTime EntryDate { get; set; } = DateTime.UtcNow;
    }
}
