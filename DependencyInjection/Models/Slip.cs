namespace DependencyInjection.Models
{
    public class Slip
    {
        public int Id { get; set; }
        public string Advice { get; set; }
    }

    public class SlipObject
    {
        public Slip Slip { get; set; }
    }
}
