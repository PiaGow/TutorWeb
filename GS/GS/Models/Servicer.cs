using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Servicer
{
    public int Idservice { get; set; }

    public string? Nameservice { get; set; }

    public double? Moneyse { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
