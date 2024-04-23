using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Transactionhistory
{
    public int Idth { get; set; }

    public string? Sender { get; set; }

    public string? Receiver { get; set; }

    public DateTime? Dateth { get; set; }

    public int? Idbill { get; set; }

    public virtual Bill? IdbillNavigation { get; set; }
}
