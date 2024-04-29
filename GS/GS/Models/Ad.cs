using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Ad
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Phonenumberad { get; set; }

   public int AccountId { get; set; }
    public Account Account { get; set; }
}
