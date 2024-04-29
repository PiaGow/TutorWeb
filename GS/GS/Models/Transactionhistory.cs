using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Transactionhistory
{
    [Key]
    public int Id { get; set; }

    public string? Sender { get; set; }

    public string? Receiver { get; set; }

    public DateTime? Dateth { get; set; }

    public int? Idbill { get; set; }

    public virtual Bill? IdbillNavigation { get; set; }
}
