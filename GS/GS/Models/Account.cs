using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GS.Models;

public partial class Account
{
    [Key]
    public int Id { get; set; }

    public string? Username { get; set; }
    [DisplayName("Password")]
    public string? Passwordat { get; set; }

    public string? Activity { get; set; }

    public int? TypeId { get; set; }
    public Accounttype AccountType { get; set; }    

    public int? CourseId { get; set; }
    public Course Course { get; set; }
    public int ContractId { get; set; }
    public Contract contract { get; set; }
    public int? AssessId { get; set; }
    public Assess Assess { get; set; }
    public int? Idservice { get; set; }
    public Servicer Servicer { get; set; }  
    public int? RequireScoreId { get; set; }
    public Requiredscore Requiredscore { get; set; }
    public int? HomeWorkId { get; set; }
    public Homework Homework { get; set; }
    public int? RatingId { get; set; }
    public Rating Rating { get; set; }
    public List<DetailTimeTable> DetailTimeTable { get; set; }
    public virtual ICollection<Bill> Bills { get; set; } 
}
