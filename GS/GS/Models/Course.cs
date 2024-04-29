using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Course
{
    [Key]
    public int Id { get; set; }
    [Required, StringLength(100)]
    [DisplayName ("Ngày Bắt Đầu")]
    public DateTime? Starttime { get; set; }
    [DisplayName ("Ngày Kết Thúc")]

    public DateTime? Endtime { get; set; }
    [DisplayName("Thông Tin Khóa Học")]

    public string? Courseinformation { get; set; }

    public int? Idtimece { get; set; }

    public int? Idst { get; set; }

    public int? Idtr { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
    [DisplayName("Bài Tập")]
    public virtual ICollection<Homework> Homeworks { get; set; } = new List<Homework>();
    [DisplayName("Môn Học")]
    public virtual Subject? IdstNavigation { get; set; }
    [DisplayName("Thời Gian Học")]

    public virtual Timecourse? IdtimeceNavigation { get; set; }
    [DisplayName("Gia Sư")]

    public virtual Tutor? IdtrNavigation { get; set; }
    [DisplayName("Danh Sách Học Sinh")]
    public virtual ICollection<Studentlist> Studentlists { get; set; } = new List<Studentlist>();
}
