using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Revenue
{
    [Key]
    public int Id { get; set; }

    public double? Totalmoneyforthemonth { get; set; }

    public double? Totalmoneyfortheyear { get; set; }

    public int? Idbill { get; set; }

    public virtual Bill? IdbillNavigation { get; set; }
}
