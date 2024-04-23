using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Revenue
{
    public int Idre { get; set; }

    public double? Totalmoneyforthemonth { get; set; }

    public double? Totalmoneyfortheyear { get; set; }

    public int? Idbill { get; set; }

    public virtual Bill? IdbillNavigation { get; set; }
}
