using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Homework
{
    [Key]
    public int Id { get; set; }
    [DisplayName("Tên Bài Tập")]
    public string? Namehk { get; set; }
    [DisplayName("Trạng Thái Bài Tập")]
    public string? Assignmentsubmitted { get; set; }
    [DisplayName("Thời Gian Bắt Đầu")]
    public DateTime? Timestart { get; set; }
    [DisplayName("Hạn Nộp")]
    public DateTime? Timeend { get; set; }

    public int? Idce { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Course? IdceNavigation { get; set; }
}
