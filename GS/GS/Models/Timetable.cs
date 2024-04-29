namespace GS.Models
{
    public class TimeTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeOnly TimeStart { get; set; }
        public TimeOnly TimeEnd { get; set; }
    }
}
