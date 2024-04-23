using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Customer
{
    public int Idcr { get; set; }

    public string? Namect { get; set; }

    public int? Phonenumber { get; set; }

    public string? Addressct { get; set; }

    public int? IdcardCr { get; set; }

    public string? IdcardImg { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Studentlist> Studentlists { get; set; } = new List<Studentlist>();

    public virtual ICollection<Timetable> Timetables { get; set; } = new List<Timetable>();
}
