using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Accounttype
{
    public int Idtype { get; set; }

    public string? Position { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
