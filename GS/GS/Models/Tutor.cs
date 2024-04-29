using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Tutor
{
    [Key]
    public int Id { get; set; }

    public string? Nametr { get; set; }

    public int? Phonenumbertr { get; set; }

    public string? Addresstr { get; set; }

    public int? IdcardTr { get; set; }

    public string? IdcardImg { get; set; }

    public int AccountId { get; set; }
    public Account Account { get; set; }
}
