using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Contract
{
    public int Idct { get; set; }

    public string? Namect { get; set; }

    public string? Contentcontract { get; set; }

    public string? Rulect { get; set; }

    public double? Forfeit { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
