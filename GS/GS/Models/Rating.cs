using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Rating
{
    [Key]
    public int Id{ get; set; }

    public int? Coursenumber { get; set; }

    public int? Reviewnumber { get; set; }

    public int? Idtr { get; set; }

    public int? Idas { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Assess? IdasNavigation { get; set; }

    public virtual Tutor? IdtrNavigation { get; set; }
}
