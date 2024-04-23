using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GS.Models;

public partial class GsvietContext : DbContext
{
    public GsvietContext()
    {
    }

    public GsvietContext(DbContextOptions<GsvietContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Accounttype> Accounttypes { get; set; }

    public virtual DbSet<Ad> Ads { get; set; }

    public virtual DbSet<Assess> Assesses { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Homework> Homeworks { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Requiredscore> Requiredscores { get; set; }

    public virtual DbSet<Revenue> Revenues { get; set; }

    public virtual DbSet<Servicer> Servicers { get; set; }

    public virtual DbSet<Studentlist> Studentlists { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Timecourse> Timecourses { get; set; }

    public virtual DbSet<Timetable> Timetables { get; set; }

    public virtual DbSet<Transactionhistory> Transactionhistories { get; set; }

    public virtual DbSet<Tutor> Tutors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=137.59.106.42;Server=LAPTOP-UQAFNQ72\\SQLEXPRESS;Initial Catalog=gsviet;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Idtk).HasName("PK__ACCOUNT__B87C3A836D49A6F8");

            entity.ToTable("ACCOUNT");

            entity.Property(e => e.Idtk)
                .ValueGeneratedNever()
                .HasColumnName("IDTK");
            entity.Property(e => e.Activity)
                .HasMaxLength(200)
                .HasColumnName("ACTIVITY");
            entity.Property(e => e.Gradenumber).HasColumnName("GRADENUMBER");
            entity.Property(e => e.Idad).HasColumnName("IDAD");
            entity.Property(e => e.Idas).HasColumnName("IDAS");
            entity.Property(e => e.Idce).HasColumnName("IDCE");
            entity.Property(e => e.Idcr).HasColumnName("IDCR");
            entity.Property(e => e.Idct).HasColumnName("IDCT");
            entity.Property(e => e.Idhk).HasColumnName("IDHK");
            entity.Property(e => e.Idrc).HasColumnName("IDRC");
            entity.Property(e => e.Idservice).HasColumnName("IDSERVICE");
            entity.Property(e => e.Idst).HasColumnName("IDST");
            entity.Property(e => e.Idstt).HasColumnName("IDSTT");
            entity.Property(e => e.Idtime).HasColumnName("IDTIME");
            entity.Property(e => e.Idtr).HasColumnName("IDTR");
            entity.Property(e => e.Idtype).HasColumnName("IDTYPE");
            entity.Property(e => e.Passwordat)
                .HasMaxLength(200)
                .HasColumnName("PASSWORDAT");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .HasColumnName("USERNAME");

            entity.HasOne(d => d.GradenumberNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Gradenumber)
                .HasConstraintName("FK__ACCOUNT__GRADENU__7B5B524B");

            entity.HasOne(d => d.IdadNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idad)
                .HasConstraintName("FK__ACCOUNT__IDAD__7E37BEF6");

            entity.HasOne(d => d.IdasNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idas)
                .HasConstraintName("FK__ACCOUNT__IDAS__75A278F5");

            entity.HasOne(d => d.IdceNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idce)
                .HasConstraintName("FK__ACCOUNT__IDCE__74AE54BC");

            entity.HasOne(d => d.IdcrNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idcr)
                .HasConstraintName("FK__ACCOUNT__IDCR__7F2BE32F");

            entity.HasOne(d => d.IdctNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idct)
                .HasConstraintName("FK__ACCOUNT__IDCT__73BA3083");

            entity.HasOne(d => d.IdhkNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idhk)
                .HasConstraintName("FK__ACCOUNT__IDHK__7A672E12");

            entity.HasOne(d => d.IdrcNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idrc)
                .HasConstraintName("FK__ACCOUNT__IDRC__778AC167");

            entity.HasOne(d => d.IdserviceNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idservice)
                .HasConstraintName("FK__ACCOUNT__IDSERVI__76969D2E");

            entity.HasOne(d => d.IdstNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idst)
                .HasConstraintName("FK__ACCOUNT__IDST__787EE5A0");

            entity.HasOne(d => d.IdsttNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idstt)
                .HasConstraintName("FK__ACCOUNT__IDSTT__797309D9");

            entity.HasOne(d => d.IdtimeNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idtime)
                .HasConstraintName("FK__ACCOUNT__IDTIME__7C4F7684");

            entity.HasOne(d => d.IdtrNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idtr)
                .HasConstraintName("FK__ACCOUNT__IDTR__7D439ABD");

            entity.HasOne(d => d.IdtypeNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Idtype)
                .HasConstraintName("FK__ACCOUNT__IDTYPE__72C60C4A");
        });

        modelBuilder.Entity<Accounttype>(entity =>
        {
            entity.HasKey(e => e.Idtype).HasName("PK__ACCOUNTT__BAB0B7B3EBF80EA6");

            entity.ToTable("ACCOUNTTYPE");

            entity.Property(e => e.Idtype)
                .ValueGeneratedNever()
                .HasColumnName("IDTYPE");
            entity.Property(e => e.Position)
                .HasMaxLength(100)
                .HasColumnName("POSITION");
        });

        modelBuilder.Entity<Ad>(entity =>
        {
            entity.HasKey(e => e.Idad).HasName("PK__AD__B87DB0E217BD32FF");

            entity.ToTable("AD");

            entity.Property(e => e.Idad)
                .ValueGeneratedNever()
                .HasColumnName("IDAD");
            entity.Property(e => e.Namead)
                .HasMaxLength(200)
                .HasColumnName("NAMEAD");
            entity.Property(e => e.Phonenumberad).HasColumnName("PHONENUMBERAD");
        });

        modelBuilder.Entity<Assess>(entity =>
        {
            entity.HasKey(e => e.Idas).HasName("PK__ASSESS__B87DB0F3CE889AA7");

            entity.ToTable("ASSESS");

            entity.Property(e => e.Idas)
                .ValueGeneratedNever()
                .HasColumnName("IDAS");
            entity.Property(e => e.Content).HasColumnName("CONTENT");
            entity.Property(e => e.Rolseas)
                .HasMaxLength(200)
                .HasColumnName("ROLSEAS");
            entity.Property(e => e.Timeas)
                .HasColumnType("datetime")
                .HasColumnName("TIMEAS");
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.Idbill).HasName("PK__BILL__5B84A4709CFF444E");

            entity.ToTable("BILL");

            entity.Property(e => e.Idbill)
                .ValueGeneratedNever()
                .HasColumnName("IDBILL");
            entity.Property(e => e.Dateofpayment)
                .HasColumnType("datetime")
                .HasColumnName("DATEOFPAYMENT");
            entity.Property(e => e.Idtk).HasColumnName("IDTK");
            entity.Property(e => e.Namebill)
                .HasMaxLength(150)
                .HasColumnName("NAMEBILL");
            entity.Property(e => e.Totalmoney).HasColumnName("TOTALMONEY");

            entity.HasOne(d => d.IdtkNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.Idtk)
                .HasConstraintName("FK__BILL__IDTK__02084FDA");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Idct).HasName("PK__CONTRACT__B87D80B50B13AFAD");

            entity.ToTable("CONTRACTS");

            entity.Property(e => e.Idct)
                .ValueGeneratedNever()
                .HasColumnName("IDCT");
            entity.Property(e => e.Contentcontract).HasColumnName("CONTENTCONTRACT");
            entity.Property(e => e.Forfeit).HasColumnName("FORFEIT");
            entity.Property(e => e.Namect)
                .HasMaxLength(500)
                .HasColumnName("NAMECT");
            entity.Property(e => e.Rulect).HasColumnName("RULECT");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Idce).HasName("PK__COURSE__B87D80A42343E8E2");

            entity.ToTable("COURSE");

            entity.Property(e => e.Idce)
                .ValueGeneratedNever()
                .HasColumnName("IDCE");
            entity.Property(e => e.Courseinformation).HasColumnName("COURSEINFORMATION");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("ENDTIME");
            entity.Property(e => e.Idst).HasColumnName("IDST");
            entity.Property(e => e.Idtimece).HasColumnName("IDTIMECE");
            entity.Property(e => e.Idtr).HasColumnName("IDTR");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("STARTTIME");

            entity.HasOne(d => d.IdstNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.Idst)
                .HasConstraintName("FK__COURSE__IDST__5FB337D6");

            entity.HasOne(d => d.IdtimeceNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.Idtimece)
                .HasConstraintName("FK__COURSE__IDTIMECE__5EBF139D");

            entity.HasOne(d => d.IdtrNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.Idtr)
                .HasConstraintName("FK__COURSE__IDTR__60A75C0F");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Idcr).HasName("PK__CUSTOMER__B87D80B725356A2A");

            entity.ToTable("CUSTOMER");

            entity.Property(e => e.Idcr)
                .ValueGeneratedNever()
                .HasColumnName("IDCR");
            entity.Property(e => e.Addressct)
                .HasMaxLength(2000)
                .HasColumnName("ADDRESSCT");
            entity.Property(e => e.IdcardCr).HasColumnName("IDcardCR");
            entity.Property(e => e.IdcardImg).HasColumnName("IDCardImg");
            entity.Property(e => e.Namect)
                .HasMaxLength(200)
                .HasColumnName("NAMECT");
            entity.Property(e => e.Phonenumber).HasColumnName("PHONENUMBER");
        });

        modelBuilder.Entity<Homework>(entity =>
        {
            entity.HasKey(e => e.Idhk).HasName("PK__HOMEWORK__B87C1A0E9221BA8F");

            entity.ToTable("HOMEWORK");

            entity.Property(e => e.Idhk)
                .ValueGeneratedNever()
                .HasColumnName("IDHK");
            entity.Property(e => e.Assignmentsubmitted).HasColumnName("ASSIGNMENTSUBMITTED");
            entity.Property(e => e.Idce).HasColumnName("IDCE");
            entity.Property(e => e.Namehk).HasColumnName("NAMEHK");
            entity.Property(e => e.Timeend)
                .HasColumnType("datetime")
                .HasColumnName("TIMEEND");
            entity.Property(e => e.Timestart)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTART");

            entity.HasOne(d => d.IdceNavigation).WithMany(p => p.Homeworks)
                .HasForeignKey(d => d.Idce)
                .HasConstraintName("FK__HOMEWORK__IDCE__6C190EBB");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.Gradenumber).HasName("PK__RATING__9D6A8286A3049811");

            entity.ToTable("RATING");

            entity.Property(e => e.Gradenumber)
                .ValueGeneratedNever()
                .HasColumnName("GRADENUMBER");
            entity.Property(e => e.Coursenumber).HasColumnName("COURSENUMBER");
            entity.Property(e => e.Idas).HasColumnName("IDAS");
            entity.Property(e => e.Idtr).HasColumnName("IDTR");
            entity.Property(e => e.Reviewnumber).HasColumnName("REVIEWNUMBER");

            entity.HasOne(d => d.IdasNavigation).WithMany(p => p.Ratings)
                .HasForeignKey(d => d.Idas)
                .HasConstraintName("FK__RATING__IDAS__6FE99F9F");

            entity.HasOne(d => d.IdtrNavigation).WithMany(p => p.Ratings)
                .HasForeignKey(d => d.Idtr)
                .HasConstraintName("FK__RATING__IDTR__6EF57B66");
        });

        modelBuilder.Entity<Requiredscore>(entity =>
        {
            entity.HasKey(e => e.Idrc).HasName("PK__REQUIRED__B87C2ACEEEFB02B5");

            entity.ToTable("REQUIREDSCORE");

            entity.Property(e => e.Idrc)
                .ValueGeneratedNever()
                .HasColumnName("IDRC");
            entity.Property(e => e.Achievements).HasColumnName("ACHIEVEMENTS");
            entity.Property(e => e.Gpa).HasColumnName("GPA");
            entity.Property(e => e.Idtr).HasColumnName("IDTR");

            entity.HasOne(d => d.IdtrNavigation).WithMany(p => p.Requiredscores)
                .HasForeignKey(d => d.Idtr)
                .HasConstraintName("FK__REQUIREDSC__IDTR__59063A47");
        });

        modelBuilder.Entity<Revenue>(entity =>
        {
            entity.HasKey(e => e.Idre).HasName("PK__REVENUE__B87C2AC8B50214F2");

            entity.ToTable("REVENUE");

            entity.Property(e => e.Idre)
                .ValueGeneratedNever()
                .HasColumnName("IDRE");
            entity.Property(e => e.Idbill).HasColumnName("IDBILL");
            entity.Property(e => e.Totalmoneyforthemonth).HasColumnName("TOTALMONEYFORTHEMONTH");
            entity.Property(e => e.Totalmoneyfortheyear).HasColumnName("TOTALMONEYFORTHEYEAR");

            entity.HasOne(d => d.IdbillNavigation).WithMany(p => p.Revenues)
                .HasForeignKey(d => d.Idbill)
                .HasConstraintName("FK__REVENUE__IDBILL__07C12930");
        });

        modelBuilder.Entity<Servicer>(entity =>
        {
            entity.HasKey(e => e.Idservice).HasName("PK__SERVICER__557E69871CE27D4B");

            entity.ToTable("SERVICER");

            entity.Property(e => e.Idservice)
                .ValueGeneratedNever()
                .HasColumnName("IDSERVICE");
            entity.Property(e => e.Moneyse).HasColumnName("MONEYSE");
            entity.Property(e => e.Nameservice)
                .HasMaxLength(1000)
                .HasColumnName("NAMESERVICE");
        });

        modelBuilder.Entity<Studentlist>(entity =>
        {
            entity.HasKey(e => e.Idstt).HasName("PK__STUDENTL__A5C8116357AD21AF");

            entity.ToTable("STUDENTLIST");

            entity.Property(e => e.Idstt)
                .ValueGeneratedNever()
                .HasColumnName("IDSTT");
            entity.Property(e => e.Idce).HasColumnName("IDCE");
            entity.Property(e => e.Idcr).HasColumnName("IDCR");
            entity.Property(e => e.Idtr).HasColumnName("IDTR");
            entity.Property(e => e.Namest)
                .HasMaxLength(200)
                .HasColumnName("NAMEST");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

            entity.HasOne(d => d.IdceNavigation).WithMany(p => p.Studentlists)
                .HasForeignKey(d => d.Idce)
                .HasConstraintName("FK__STUDENTLIS__IDCE__656C112C");

            entity.HasOne(d => d.IdcrNavigation).WithMany(p => p.Studentlists)
                .HasForeignKey(d => d.Idcr)
                .HasConstraintName("FK__STUDENTLIS__IDCR__6477ECF3");

            entity.HasOne(d => d.IdtrNavigation).WithMany(p => p.Studentlists)
                .HasForeignKey(d => d.Idtr)
                .HasConstraintName("FK__STUDENTLIS__IDTR__6383C8BA");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Idst).HasName("PK__SUBJECTS__B87C029970F78760");

            entity.ToTable("SUBJECTS");

            entity.Property(e => e.Idst)
                .ValueGeneratedNever()
                .HasColumnName("IDST");
            entity.Property(e => e.Idtr).HasColumnName("IDTR");
            entity.Property(e => e.Namest)
                .HasMaxLength(100)
                .HasColumnName("NAMEST");

            entity.HasOne(d => d.IdtrNavigation).WithMany(p => p.Subjects)
                .HasForeignKey(d => d.Idtr)
                .HasConstraintName("FK__SUBJECTS__IDTR__5BE2A6F2");
        });

        modelBuilder.Entity<Timecourse>(entity =>
        {
            entity.HasKey(e => e.Idtimece).HasName("PK__TIMECOUR__B9571473C8A53B1F");

            entity.ToTable("TIMECOURSE");

            entity.Property(e => e.Idtimece)
                .ValueGeneratedNever()
                .HasColumnName("IDTIMECE");
            entity.Property(e => e.Daysend)
                .HasMaxLength(100)
                .HasColumnName("DAYSEND");
            entity.Property(e => e.Daysinweek)
                .HasMaxLength(100)
                .HasColumnName("DAYSINWEEK");
            entity.Property(e => e.Daystart)
                .HasMaxLength(100)
                .HasColumnName("DAYSTART");
            entity.Property(e => e.Timeend)
                .HasColumnType("datetime")
                .HasColumnName("TIMEEND");
            entity.Property(e => e.Timestart)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTART");
        });

        modelBuilder.Entity<Timetable>(entity =>
        {
            entity.HasKey(e => e.Idtime).HasName("PK__TIMETABL__E57E047905D5FBB3");

            entity.ToTable("TIMETABLE");

            entity.Property(e => e.Idtime)
                .ValueGeneratedNever()
                .HasColumnName("IDTIME");
            entity.Property(e => e.Dayintweek)
                .HasMaxLength(100)
                .HasColumnName("DAYINTWEEK");
            entity.Property(e => e.Idcr).HasColumnName("IDCR");
            entity.Property(e => e.Idtr).HasColumnName("IDTR");
            entity.Property(e => e.Timeend)
                .HasColumnType("datetime")
                .HasColumnName("TIMEEND");
            entity.Property(e => e.Timestart)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTART");

            entity.HasOne(d => d.IdcrNavigation).WithMany(p => p.Timetables)
                .HasForeignKey(d => d.Idcr)
                .HasConstraintName("FK__TIMETABLE__IDCR__693CA210");

            entity.HasOne(d => d.IdtrNavigation).WithMany(p => p.Timetables)
                .HasForeignKey(d => d.Idtr)
                .HasConstraintName("FK__TIMETABLE__IDTR__68487DD7");
        });

        modelBuilder.Entity<Transactionhistory>(entity =>
        {
            entity.HasKey(e => e.Idth).HasName("PK__TRANSACT__B87C3A8CDEB3B5CE");

            entity.ToTable("TRANSACTIONHISTORY");

            entity.Property(e => e.Idth)
                .ValueGeneratedNever()
                .HasColumnName("IDTH");
            entity.Property(e => e.Dateth)
                .HasColumnType("datetime")
                .HasColumnName("DATETH");
            entity.Property(e => e.Idbill).HasColumnName("IDBILL");
            entity.Property(e => e.Receiver).HasColumnName("RECEIVER");
            entity.Property(e => e.Sender).HasColumnName("SENDER");

            entity.HasOne(d => d.IdbillNavigation).WithMany(p => p.Transactionhistories)
                .HasForeignKey(d => d.Idbill)
                .HasConstraintName("FK__TRANSACTI__IDBIL__04E4BC85");
        });

        modelBuilder.Entity<Tutor>(entity =>
        {
            entity.HasKey(e => e.Idtr).HasName("PK__TUTOR__B87C3AFA13160C70");

            entity.ToTable("TUTOR");

            entity.Property(e => e.Idtr)
                .ValueGeneratedNever()
                .HasColumnName("IDTR");
            entity.Property(e => e.Addresstr)
                .HasMaxLength(2000)
                .HasColumnName("ADDRESSTR");
            entity.Property(e => e.IdcardImg).HasColumnName("IDCardImg");
            entity.Property(e => e.IdcardTr).HasColumnName("IDcardTR");
            entity.Property(e => e.Nametr)
                .HasMaxLength(200)
                .HasColumnName("NAMETR");
            entity.Property(e => e.Phonenumbertr).HasColumnName("PHONENUMBERTR");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
