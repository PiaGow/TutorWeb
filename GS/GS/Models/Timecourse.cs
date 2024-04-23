using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GS.Models;

public partial class Timecourse
{
    public int Idtimece { get; set; }
    [DisplayName("Giờ Học")]
    public DateTime? Timestart { get; set; }
    [DisplayName("Giờ Kết Thúc")]
    public DateTime? Timeend { get; set; }
    [DisplayName("Học Vào Ngày")]
    public string? Daysinweek { get; set; }
    [DisplayName("Ngày Bắt Đầu")]
    public string? Daystart { get; set; }
    [DisplayName("Ngày Kết Thúc")]
    public string? Daysend { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
