using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Assess
{
    public int Idas { get; set; }

    public string? Content { get; set; }

    public DateTime? Timeas { get; set; }

    public string? Rolseas { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
}
