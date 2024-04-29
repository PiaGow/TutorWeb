using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Subject
{
    [Key]
    public int Id { get; set; }
    [DisplayName("Tên Môn Học")]
    public string? Namest { get; set; }

    public int? Idtr { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual Tutor? IdtrNavigation { get; set; }
}
