using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Contract
{
    [Key]
    public int Id { get; set; }

    public string? Namt { get; set; }

    public string? Contentcontract { get; set; }

    public string? Rulect { get; set; }

    public double? Forfeit { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
