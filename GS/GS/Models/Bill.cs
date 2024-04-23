using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Bill
{
    public int Idbill { get; set; }

    public string? Namebill { get; set; }

    public DateTime? Dateofpayment { get; set; }

    public double? Totalmoney { get; set; }

    public int? Idtk { get; set; }

    public virtual Account? IdtkNavigation { get; set; }

    public virtual ICollection<Revenue> Revenues { get; set; } = new List<Revenue>();

    public virtual ICollection<Transactionhistory> Transactionhistories { get; set; } = new List<Transactionhistory>();
}
