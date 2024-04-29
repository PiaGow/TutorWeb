using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Requiredscore
{
    [Key]
    public int Id { get; set; }

    public double? Gpa { get; set; }

    public string? Achievements { get; set; }

    public int? Idtr { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Tutor? IdtrNavigation { get; set; }
}
