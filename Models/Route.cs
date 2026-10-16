namespace Prog_poe.Models
{
    public class Route
    {

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string StartLocation { get; set; } = string.Empty;

        public string EndLocation { get; set; } = string.Empty;

        public double Distance { get; set; }

        public int EventId { get; set; }
    }
}
