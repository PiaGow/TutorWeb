using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Requiredscore
{
    public int Idrc { get; set; }

    public double? Gpa { get; set; }

    public string? Achievements { get; set; }

    public int? Idtr { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Tutor? IdtrNavigation { get; set; }
}
