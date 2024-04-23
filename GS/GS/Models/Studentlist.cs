using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Studentlist
{
    public int Idstt { get; set; }

    public string? Namest { get; set; }

    public int? Quantity { get; set; }

    public int? Idtr { get; set; }

    public int? Idcr { get; set; }

    public int? Idce { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Course? IdceNavigation { get; set; }

    public virtual Customer? IdcrNavigation { get; set; }

    public virtual Tutor? IdtrNavigation { get; set; }
}
