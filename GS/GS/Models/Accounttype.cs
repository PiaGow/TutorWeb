using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Accounttype
{
    [Key]
    public int Id { get; set; }

    public string? Position { get; set; }

   
}
