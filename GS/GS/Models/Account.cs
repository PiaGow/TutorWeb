using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GS.Models;

public partial class Account
{
    public int Idtk { get; set; }

    public string? Username { get; set; }
    [DisplayName("Password")]
    public string? Passwordat { get; set; }

    public string? Activity { get; set; }

    public int? Idtype { get; set; }

    public int? Idct { get; set; }

    public int? Idce { get; set; }

    public int? Idas { get; set; }

    public int? Idservice { get; set; }

    public int? Idrc { get; set; }

    public int? Idst { get; set; }

    public int? Idstt { get; set; }

    public int? Idhk { get; set; }

    public int? Gradenumber { get; set; }

    public int? Idtime { get; set; }

    public int? Idtr { get; set; }

    public int? Idad { get; set; }

    public int? Idcr { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual Rating? GradenumberNavigation { get; set; }

    public virtual Ad? IdadNavigation { get; set; }

    public virtual Assess? IdasNavigation { get; set; }

    public virtual Course? IdceNavigation { get; set; }

    public virtual Customer? IdcrNavigation { get; set; }

    public virtual Contract? IdctNavigation { get; set; }

    public virtual Homework? IdhkNavigation { get; set; }

    public virtual Requiredscore? IdrcNavigation { get; set; }

    public virtual Servicer? IdserviceNavigation { get; set; }

    public virtual Subject? IdstNavigation { get; set; }

    public virtual Studentlist? IdsttNavigation { get; set; }

    public virtual Timetable? IdtimeNavigation { get; set; }

    public virtual Tutor? IdtrNavigation { get; set; }

    public virtual Accounttype? IdtypeNavigation { get; set; }
}
