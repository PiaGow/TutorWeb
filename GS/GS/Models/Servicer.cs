using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Servicer
{
    [Key]
    public int Id { get; set; }

    public string? Nameservice { get; set; }

    public double? Moneyse { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
