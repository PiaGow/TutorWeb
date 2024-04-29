using System.ComponentModel.DataAnnotations;

namespace GS.Models
{
    public class DetailTimeTable
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int TimeTableId { get; set; }
        public TimeTable? TimeTable { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set;}
    }
}
