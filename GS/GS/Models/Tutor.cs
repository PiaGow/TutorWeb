using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Tutor
{
    public int Idtr { get; set; }

    public string? Nametr { get; set; }

    public int? Phonenumbertr { get; set; }

    public string? Addresstr { get; set; }

    public int? IdcardTr { get; set; }

    public string? IdcardImg { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    public virtual ICollection<Requiredscore> Requiredscores { get; set; } = new List<Requiredscore>();

    public virtual ICollection<Studentlist> Studentlists { get; set; } = new List<Studentlist>();

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();

    public virtual ICollection<Timetable> Timetables { get; set; } = new List<Timetable>();
}
