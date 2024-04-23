using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Ad
{
    public int Idad { get; set; }

    public string? Namead { get; set; }

    public int? Phonenumberad { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
