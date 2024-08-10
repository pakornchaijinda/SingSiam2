using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SingSiamOffice.Models;

public partial class SingsiamnewdbContext : DbContext
{
    public SingsiamnewdbContext()
    {
    }

    public SingsiamnewdbContext(DbContextOptions<SingsiamnewdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Blacklist> Blacklists { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Closeconfig> Closeconfigs { get; set; }

    public virtual DbSet<Config> Configs { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Expincome> Expincomes { get; set; }

    public virtual DbSet<Externalar> Externalars { get; set; }

    public virtual DbSet<ExternalarDetail> ExternalarDetails { get; set; }

    public virtual DbSet<Lateconfig> Lateconfigs { get; set; }

    public virtual DbSet<Periodtran> Periodtrans { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Promise> Promises { get; set; }

    public virtual DbSet<Receiptdesc> Receiptdescs { get; set; }

    public virtual DbSet<ReceiptdescCancel> ReceiptdescCancels { get; set; }

    public virtual DbSet<Receipttran> Receipttrans { get; set; }

    public virtual DbSet<ReceipttranCancel> ReceipttranCancels { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    public virtual DbSet<UserReport> UserReports { get; set; }

    public virtual DbSet<Userfile> Userfiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=103.91.204.106;Database=singsiamnewdb;user id=sqlserver;password=singsiamP@ssw0rd;Trusted_Connection=false;MultipleActiveResultSets=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Account__3213E83FF82742D0");

            entity.ToTable("Account");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acctype)
                .HasDefaultValueSql("((0))")
                .HasColumnName("acctype");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("name");
            entity.Property(e => e.Sumcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("sumcode");
        });

        modelBuilder.Entity<Blacklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Blacklis__3214EC075AA16FD7");

            entity.ToTable("Blacklist");

            entity.HasIndex(e => e.Cardid, "cardid").IsUnique();

            entity.Property(e => e.Cardid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("cardid");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("name");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdesc");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Branch__3213E83F2BE30023");

            entity.ToTable("Branch");

            entity.HasIndex(e => e.Code, "IX_Branch");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("address");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Closeconfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Closecon__3213E83FDD5AEE74");

            entity.ToTable("Closeconfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("amount");
            entity.Property(e => e.Rangefrom)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rangefrom");
            entity.Property(e => e.Rangeto)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rangeto");
        });

        modelBuilder.Entity<Config>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Config__3213E83FF8E08AE5");

            entity.ToTable("Config");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddonMemo)
                .HasDefaultValueSql("((0))")
                .HasColumnName("addon_memo");
            entity.Property(e => e.Arbranch)
                .HasDefaultValueSql("((0))")
                .HasColumnName("arbranch");
            entity.Property(e => e.Askamt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("askamt");
            entity.Property(e => e.Askpc)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("askpc");
            entity.Property(e => e.Asktime)
                .HasDefaultValueSql("((0))")
                .HasColumnName("asktime");
            entity.Property(e => e.Closeedit)
                .HasDefaultValueSql("((0))")
                .HasColumnName("closeedit");
            entity.Property(e => e.Cutflat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cutflat");
            entity.Property(e => e.DataMore)
                .HasDefaultValueSql("((0))")
                .HasColumnName("data_more");
            entity.Property(e => e.Daylate)
                .HasDefaultValueSql("((7))")
                .HasColumnName("daylate");
            entity.Property(e => e.Disablemanual)
                .HasDefaultValueSql("((0))")
                .HasColumnName("disablemanual");
            entity.Property(e => e.Editfee)
                .HasDefaultValueSql("((0))")
                .HasColumnName("editfee");
            entity.Property(e => e.Externalar)
                .HasDefaultValueSql("((0))")
                .HasColumnName("externalar");
            entity.Property(e => e.Followamt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("followamt");
            entity.Property(e => e.Followpc)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("followpc");
            entity.Property(e => e.Followtime)
                .HasDefaultValueSql("((0))")
                .HasColumnName("followtime");
            entity.Property(e => e.Ftphost)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ftphost");
            entity.Property(e => e.Ftppass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ftppass");
            entity.Property(e => e.Ftppath)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ftppath");
            entity.Property(e => e.Ftpuser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ftpuser");
            entity.Property(e => e.Hurryamt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("hurryamt");
            entity.Property(e => e.Hurrypc)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("hurrypc");
            entity.Property(e => e.Hurrytime)
                .HasDefaultValueSql("((0))")
                .HasColumnName("hurrytime");
            entity.Property(e => e.Latecap)
                .HasDefaultValueSql("((0))")
                .HasColumnName("latecap");
            entity.Property(e => e.Loancontrol)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loancontrol");
            entity.Property(e => e.Loancreate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loancreate");
            entity.Property(e => e.Loanservins)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanservins");
            entity.Property(e => e.Localtaxrate)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("localtaxrate");
            entity.Property(e => e.Maxins)
                .HasDefaultValueSql("((2))")
                .HasColumnName("maxins");
            entity.Property(e => e.Orgaddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("orgaddress");
            entity.Property(e => e.Orgname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("orgname");
            entity.Property(e => e.Orgtelfax)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("orgtelfax");
            entity.Property(e => e.Paymethod)
                .HasDefaultValueSql("((0))")
                .HasColumnName("paymethod");
            entity.Property(e => e.Servicecharge)
                .HasDefaultValueSql("((0))")
                .HasColumnName("servicecharge");
            entity.Property(e => e.Signname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("signname");
            entity.Property(e => e.Specialtaxrate)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("specialtaxrate");
            entity.Property(e => e.Taxid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("taxid");
            entity.Property(e => e.Taxrate)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("taxrate");
            entity.Property(e => e.Wwwpath)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wwwpath");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__customer__3213E83F867906F8");

            entity.ToTable("Customer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("address");
            entity.Property(e => e.Arbalance)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("arbalance");
            entity.Property(e => e.Cardexpire)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("cardexpire");
            entity.Property(e => e.Cardexpireformat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("cardexpireformat");
            entity.Property(e => e.Cardid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("cardid");
            entity.Property(e => e.HomeE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("home_e");
            entity.Property(e => e.HomeN)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("home_n");
            entity.Property(e => e.Homemap)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("homemap");
            entity.Property(e => e.Jobdesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("jobdesc");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("name");
            entity.Property(e => e.Nickname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("nickname");
            entity.Property(e => e.Office)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("office");
            entity.Property(e => e.OfficeE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("office_e");
            entity.Property(e => e.OfficeN)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("office_n");
            entity.Property(e => e.Officeaddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("officeaddress");
            entity.Property(e => e.Officemap)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("officemap");
            entity.Property(e => e.Officetel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("officetel");
            entity.Property(e => e.Reference)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("reference");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((0))")
                .HasColumnName("status");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<Expincome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Expincom__3213E83F6EB111DE");

            entity.ToTable("Expincome");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("accno");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientno");
            entity.Property(e => e.Docno)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('10')")
                .HasColumnName("docno");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("expense");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("income");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("promiseno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Externalar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__External__3213E83F87F48B47");

            entity.ToTable("Externalar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aramount)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("aramount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("customer");
            entity.Property(e => e.Docno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("docno");
            entity.Property(e => e.Flg)
                .HasDefaultValueSql("((0))")
                .HasColumnName("flg");
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("paidamount");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ExternalarDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__External__3213E83F27479B50");

            entity.ToTable("Externalar_Detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("branch");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("customer");
            entity.Property(e => e.Cutamount)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("cutamount");
            entity.Property(e => e.Docno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("docno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Lateconfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lateconf__3213E83FB0C7ABA6");

            entity.ToTable("Lateconfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("amount");
            entity.Property(e => e.FIntpc)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("f_intpc");
            entity.Property(e => e.LIntpc)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("l_intpc");
            entity.Property(e => e.Rangefrom)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rangefrom");
            entity.Property(e => e.Rangeto)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rangeto");
        });

        modelBuilder.Entity<Periodtran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Periodtr__3213E83FFFBC1B83");

            entity.ToTable("Periodtran");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("branch");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("((0))")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cappaid");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("((0))")
                .HasColumnName("deposit");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("((0))")
                .HasColumnName("insurance");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("((0))")
                .HasColumnName("interest");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intpaid");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanplus");
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("paidamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("((0))")
                .HasColumnName("period");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("((0))")
                .HasColumnName("periods");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ptype");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("refcode");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("((0))")
                .HasColumnName("service");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("((0))")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((0))")
                .HasColumnName("status");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("((0))")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3213E83FAE701C5A");

            entity.ToTable("Product");

            entity.HasIndex(e => e.Code, "IX_Product");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cancelfee)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cancelfee");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("code");
            entity.Property(e => e.Colname1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname1");
            entity.Property(e => e.Colname2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname2");
            entity.Property(e => e.Colname3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname3");
            entity.Property(e => e.Colname4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname4");
            entity.Property(e => e.Colname5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname5");
            entity.Property(e => e.Colname6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname6");
            entity.Property(e => e.Colname7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname7");
            entity.Property(e => e.Colname8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname8");
            entity.Property(e => e.Colname9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname9");
            entity.Property(e => e.Financemax)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("financemax");
            entity.Property(e => e.Financerate)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("financerate");
            entity.Property(e => e.Loanmax)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("loanmax");
            entity.Property(e => e.Loanrate)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("loanrate");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Promise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promise__3213E83FEC9387B8");

            entity.ToTable("Promise");

            entity.HasIndex(e => e.Promiseno, "promiseno").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("branch");
            entity.Property(e => e.Cancelno)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cancelno");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("((0))")
                .HasColumnName("capital");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientno");
            entity.Property(e => e.Closecase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("closecase");
            entity.Property(e => e.Closedocno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("closedocno");
            entity.Property(e => e.Closeresult)
                .HasDefaultValueSql("((0))")
                .HasColumnName("closeresult");
            entity.Property(e => e.Coldata1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("coldata1");
            entity.Property(e => e.Coldata2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("coldata2");
            entity.Property(e => e.Coldata3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("coldata3");
            entity.Property(e => e.Coldata4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("coldata4");
            entity.Property(e => e.Coldata5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("coldata5");
            entity.Property(e => e.Coldata6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("coldata6");
            entity.Property(e => e.Coldata7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("coldata7");
            entity.Property(e => e.Coldata8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("coldata8");
            entity.Property(e => e.Coldata9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("coldata9");
            entity.Property(e => e.Colname1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname1");
            entity.Property(e => e.Colname2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname2");
            entity.Property(e => e.Colname3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname3");
            entity.Property(e => e.Colname4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname4");
            entity.Property(e => e.Colname5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname5");
            entity.Property(e => e.Colname6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname6");
            entity.Property(e => e.Colname7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname7");
            entity.Property(e => e.Colname8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname8");
            entity.Property(e => e.Colname9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("colname9");
            entity.Property(e => e.Compromise)
                .HasDefaultValueSql("((0))")
                .HasColumnName("compromise");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("customer");
            entity.Property(e => e.Dateclose)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("dateclose");
            entity.Property(e => e.Dateclosecal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("dateclosecal");
            entity.Property(e => e.Dateclosecalformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("dateclosecalformat");
            entity.Property(e => e.Datecloseformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("datecloseformat");
            entity.Property(e => e.Datewarn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("datewarn");
            entity.Property(e => e.Datewarnformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("datewarnformat");
            entity.Property(e => e.Daypaid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("daypaid");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("((0))")
                .HasColumnName("deposit");
            entity.Property(e => e.Downamount)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("downamount");
            entity.Property(e => e.Firstdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("firstdate");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("((0))")
                .HasColumnName("insurance");
            entity.Property(e => e.Insurance1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("insurance1");
            entity.Property(e => e.Insurance1relation)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("insurance1relation");
            entity.Property(e => e.Insurance2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("insurance2");
            entity.Property(e => e.Insurance2relation)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("insurance2relation");
            entity.Property(e => e.Intrate)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("intrate");
            entity.Property(e => e.Latepc)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("latepc");
            entity.Property(e => e.Nampa)
                .HasDefaultValueSql("((0))")
                .HasColumnName("nampa");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("((0))")
                .HasColumnName("periods");
            entity.Property(e => e.Person1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("person1");
            entity.Property(e => e.Person2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("person2");
            entity.Property(e => e.Person3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("person3");
            entity.Property(e => e.Person4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("person4");
            entity.Property(e => e.Person5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("person5");
            entity.Property(e => e.Prddesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("prddesc");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("product");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ptype");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("refcode");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("((0))")
                .HasColumnName("service");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("((0))")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((0))")
                .HasColumnName("status");
            entity.Property(e => e.Stockcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("stockcode");
            entity.Property(e => e.Sumcharge1)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("sumcharge1");
            entity.Property(e => e.Sumcharge2)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("sumcharge2");
            entity.Property(e => e.Sumstatus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("sumstatus");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("((0))")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasPrecision(0)
                .HasDefaultValueSql("('0000-00-00 00:00:00')")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Totaldown)
                .HasDefaultValueSql("((0.00))")
                .HasColumnName("totaldown");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("usercode");
            entity.Property(e => e.Warndesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("warndesc");
        });

        modelBuilder.Entity<Receiptdesc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Receiptd__3213E83FC7A95BE6");

            entity.ToTable("Receiptdesc");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("((0))")
                .HasColumnName("deposit");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("((0))")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("((0))")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ReceiptdescCancel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Receiptdesc_Cancel");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("((0))")
                .HasColumnName("deposit");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("((0))")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("((0))")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Receipttran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Receiptt__3213E83FE04F53E7");

            entity.ToTable("Receipttran");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("amount");
            entity.Property(e => e.Arbalance)
                .HasDefaultValueSql("((0))")
                .HasColumnName("arbalance");
            entity.Property(e => e.Arperiod)
                .HasDefaultValueSql("((0))")
                .HasColumnName("arperiod");
            entity.Property(e => e.Arremain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("arremain");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cappaid");
            entity.Property(e => e.Capremain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("capremain");
            entity.Property(e => e.Cashpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cashpaid");
            entity.Property(e => e.Charge1amt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("charge1amt");
            entity.Property(e => e.Charge2amt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("charge2amt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientno");
            entity.Property(e => e.Closecase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("closecase");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("((0))")
                .HasColumnName("closefee");
            entity.Property(e => e.Currentperiod)
                .HasDefaultValueSql("((0))")
                .HasColumnName("currentperiod");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("((0))")
                .HasColumnName("deposit");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("discount");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intdiscamt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intdiscamt");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intpaid");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intplus");
            entity.Property(e => e.Intremain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intremain");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("netamount");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("oldint");
            entity.Property(e => e.Otherpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("otherpaid");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("((0))")
                .HasColumnName("periodchg");
            entity.Property(e => e.Periodremain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("periodremain");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptdesc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("receiptdesc");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("receiptno");
            entity.Property(e => e.Resultamount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("resultamount");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("((0))")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("((0))")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Transferdate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("transferdate");
            entity.Property(e => e.Transferpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("transferpaid");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ReceipttranCancel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Receipttran_Cancel");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("amount");
            entity.Property(e => e.Arbalance)
                .HasDefaultValueSql("((0))")
                .HasColumnName("arbalance");
            entity.Property(e => e.Arperiod)
                .HasDefaultValueSql("((0))")
                .HasColumnName("arperiod");
            entity.Property(e => e.Arremain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("arremain");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cappaid");
            entity.Property(e => e.Capremain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("capremain");
            entity.Property(e => e.Cashpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cashpaid");
            entity.Property(e => e.Charge1amt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("charge1amt");
            entity.Property(e => e.Charge2amt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("charge2amt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("clientno");
            entity.Property(e => e.Closecase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("closecase");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("((0))")
                .HasColumnName("closefee");
            entity.Property(e => e.Currentperiod)
                .HasDefaultValueSql("((0))")
                .HasColumnName("currentperiod");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("((0))")
                .HasColumnName("deposit");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("discount");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intdiscamt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intdiscamt");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intpaid");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intplus");
            entity.Property(e => e.Intremain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("intremain");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("netamount");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("oldint");
            entity.Property(e => e.Otherpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("otherpaid");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("((0))")
                .HasColumnName("periodchg");
            entity.Property(e => e.Periodremain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("periodremain");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptdesc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("receiptdesc");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("receiptno");
            entity.Property(e => e.Resultamount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("resultamount");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("((0))")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("((0))")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Transferdate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("transferdate");
            entity.Property(e => e.Transferpaid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("transferpaid");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Station__3213E83F3ABA47E8");

            entity.ToTable("Station");

            entity.HasIndex(e => e.Stationno, "stationno").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accdocno)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accdocno");
            entity.Property(e => e.Addcapno)
                .HasDefaultValueSql("((0))")
                .HasColumnName("addcapno");
            entity.Property(e => e.Arpaidno)
                .HasDefaultValueSql("((0))")
                .HasColumnName("arpaidno");
            entity.Property(e => e.Batchno)
                .HasDefaultValueSql("((0))")
                .HasColumnName("batchno");
            entity.Property(e => e.Branch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("branch");
            entity.Property(e => e.Cloudcamera)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("cloudcamera");
            entity.Property(e => e.Color1)
                .HasDefaultValueSql("((16777168))")
                .HasColumnName("color1");
            entity.Property(e => e.Color2)
                .HasDefaultValueSql("((4194304))")
                .HasColumnName("color2");
            entity.Property(e => e.Color3)
                .HasDefaultValueSql("((16777168))")
                .HasColumnName("color3");
            entity.Property(e => e.Color4)
                .HasDefaultValueSql("((4194304))")
                .HasColumnName("color4");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("ipaddress");
            entity.Property(e => e.Macaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("macaddress");
            entity.Property(e => e.Promiseno)
                .HasDefaultValueSql("((0))")
                .HasColumnName("promiseno");
            entity.Property(e => e.Receiptno)
                .HasDefaultValueSql("((0))")
                .HasColumnName("receiptno");
            entity.Property(e => e.Specialtaxreceive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("specialtaxreceive");
            entity.Property(e => e.Stationno)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("stationno");
            entity.Property(e => e.Taxreceive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("taxreceive");
        });

        modelBuilder.Entity<UserReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRepo__3213E83FEC04309F");

            entity.ToTable("UserReport");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allow)
                .HasDefaultValueSql("((0))")
                .HasColumnName("allow");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("code");
            entity.Property(e => e.Menucode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("menucode");
        });

        modelBuilder.Entity<Userfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Userfile__3213E83F8CCB76E7");

            entity.ToTable("Userfile");

            entity.HasIndex(e => e.Code, "IX_Userfile");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adminflg)
                .HasDefaultValueSql("((0))")
                .HasColumnName("adminflg");
            entity.Property(e => e.Branchchg)
                .HasDefaultValueSql("((0))")
                .HasColumnName("branchchg");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("code");
            entity.Property(e => e.Menu1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("menu1");
            entity.Property(e => e.Menu2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("menu2");
            entity.Property(e => e.Menu3)
                .HasDefaultValueSql("((0))")
                .HasColumnName("menu3");
            entity.Property(e => e.Menu4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("menu4");
            entity.Property(e => e.Menu5)
                .HasDefaultValueSql("((0))")
                .HasColumnName("menu5");
            entity.Property(e => e.Menu6)
                .HasDefaultValueSql("((0))")
                .HasColumnName("menu6");
            entity.Property(e => e.Menu7)
                .HasDefaultValueSql("((0))")
                .HasColumnName("menu7");
            entity.Property(e => e.Menu8)
                .HasDefaultValueSql("((0))")
                .HasColumnName("menu8");
            entity.Property(e => e.Menu9)
                .HasDefaultValueSql("((0))")
                .HasColumnName("menu9");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('-')")
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
