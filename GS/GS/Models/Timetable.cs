using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Timetable
{
    public int Idtime { get; set; }

    public DateTime? Timestart { get; set; }

    public DateTime? Timeend { get; set; }

    public string? Dayintweek { get; set; }

    public int? Idtr { get; set; }

    public int? Idcr { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Customer? IdcrNavigation { get; set; }

    public virtual Tutor? IdtrNavigation { get; set; }
}
