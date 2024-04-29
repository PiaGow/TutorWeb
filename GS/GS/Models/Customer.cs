using System;
using System.Collections.Generic;

namespace GS.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Phonenumber { get; set; }

    public string? Addressct { get; set; }

    public int? IdcardCr { get; set; }

    public string? IdcardImg { get; set; }

    public int AccountId { get; set; }
    public Account Account { get; set; }
}
