using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SingSiamOffice.Models.SingSiamOld;

public partial class _01singsiamContext : DbContext
{
    public _01singsiamContext()
    {
    }

    public _01singsiamContext(DbContextOptions<_01singsiamContext> options)
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

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<Lateconfig> Lateconfigs { get; set; }

    public virtual DbSet<Logfile201301> Logfile201301s { get; set; }

    public virtual DbSet<Logfile201701> Logfile201701s { get; set; }

    public virtual DbSet<Logfile201712> Logfile201712s { get; set; }

    public virtual DbSet<Logfile201801> Logfile201801s { get; set; }

    public virtual DbSet<Logfile201802> Logfile201802s { get; set; }

    public virtual DbSet<Logfile201803> Logfile201803s { get; set; }

    public virtual DbSet<Logfile201804> Logfile201804s { get; set; }

    public virtual DbSet<Logfile201805> Logfile201805s { get; set; }

    public virtual DbSet<Logfile201806> Logfile201806s { get; set; }

    public virtual DbSet<Logfile201807> Logfile201807s { get; set; }

    public virtual DbSet<Logfile201808> Logfile201808s { get; set; }

    public virtual DbSet<Logfile201809> Logfile201809s { get; set; }

    public virtual DbSet<Logfile201810> Logfile201810s { get; set; }

    public virtual DbSet<Logfile201811> Logfile201811s { get; set; }

    public virtual DbSet<Logfile201812> Logfile201812s { get; set; }

    public virtual DbSet<Logfile201901> Logfile201901s { get; set; }

    public virtual DbSet<Logfile201902> Logfile201902s { get; set; }

    public virtual DbSet<Logfile201903> Logfile201903s { get; set; }

    public virtual DbSet<Logfile201904> Logfile201904s { get; set; }

    public virtual DbSet<Logfile201905> Logfile201905s { get; set; }

    public virtual DbSet<Logfile201906> Logfile201906s { get; set; }

    public virtual DbSet<Logfile201907> Logfile201907s { get; set; }

    public virtual DbSet<Logfile201908> Logfile201908s { get; set; }

    public virtual DbSet<Logfile201909> Logfile201909s { get; set; }

    public virtual DbSet<Logfile201910> Logfile201910s { get; set; }

    public virtual DbSet<Logfile201911> Logfile201911s { get; set; }

    public virtual DbSet<Logfile201912> Logfile201912s { get; set; }

    public virtual DbSet<Logfile202001> Logfile202001s { get; set; }

    public virtual DbSet<Logfile202002> Logfile202002s { get; set; }

    public virtual DbSet<Logfile202003> Logfile202003s { get; set; }

    public virtual DbSet<Logfile202004> Logfile202004s { get; set; }

    public virtual DbSet<Logfile202005> Logfile202005s { get; set; }

    public virtual DbSet<Logfile202006> Logfile202006s { get; set; }

    public virtual DbSet<Logfile202007> Logfile202007s { get; set; }

    public virtual DbSet<Logfile202008> Logfile202008s { get; set; }

    public virtual DbSet<Logfile202009> Logfile202009s { get; set; }

    public virtual DbSet<Logfile202010> Logfile202010s { get; set; }

    public virtual DbSet<Logfile202011> Logfile202011s { get; set; }

    public virtual DbSet<Logfile202012> Logfile202012s { get; set; }

    public virtual DbSet<Logfile202101> Logfile202101s { get; set; }

    public virtual DbSet<Logfile202102> Logfile202102s { get; set; }

    public virtual DbSet<Logfile202103> Logfile202103s { get; set; }

    public virtual DbSet<Logfile202104> Logfile202104s { get; set; }

    public virtual DbSet<Logfile202105> Logfile202105s { get; set; }

    public virtual DbSet<Logfile202106> Logfile202106s { get; set; }

    public virtual DbSet<Logfile202107> Logfile202107s { get; set; }

    public virtual DbSet<Logfile202108> Logfile202108s { get; set; }

    public virtual DbSet<Logfile202109> Logfile202109s { get; set; }

    public virtual DbSet<Logfile202110> Logfile202110s { get; set; }

    public virtual DbSet<Logfile202111> Logfile202111s { get; set; }

    public virtual DbSet<Logfile202112> Logfile202112s { get; set; }

    public virtual DbSet<Logfile202201> Logfile202201s { get; set; }

    public virtual DbSet<Logfile202202> Logfile202202s { get; set; }

    public virtual DbSet<Logfile202203> Logfile202203s { get; set; }

    public virtual DbSet<Logfile202204> Logfile202204s { get; set; }

    public virtual DbSet<Logfile202205> Logfile202205s { get; set; }

    public virtual DbSet<Logfile202206> Logfile202206s { get; set; }

    public virtual DbSet<Logfile202207> Logfile202207s { get; set; }

    public virtual DbSet<Logfile202208> Logfile202208s { get; set; }

    public virtual DbSet<Logfile202209> Logfile202209s { get; set; }

    public virtual DbSet<Logfile202210> Logfile202210s { get; set; }

    public virtual DbSet<Logfile202211> Logfile202211s { get; set; }

    public virtual DbSet<Logfile202212> Logfile202212s { get; set; }

    public virtual DbSet<Logfile202301> Logfile202301s { get; set; }

    public virtual DbSet<Logfile202302> Logfile202302s { get; set; }

    public virtual DbSet<Logfile202303> Logfile202303s { get; set; }

    public virtual DbSet<Logfile202304> Logfile202304s { get; set; }

    public virtual DbSet<Logfile202305> Logfile202305s { get; set; }

    public virtual DbSet<Logfile202306> Logfile202306s { get; set; }

    public virtual DbSet<Logfile202307> Logfile202307s { get; set; }

    public virtual DbSet<Logfile202308> Logfile202308s { get; set; }

    public virtual DbSet<Logfile202309> Logfile202309s { get; set; }

    public virtual DbSet<Logfile202310> Logfile202310s { get; set; }

    public virtual DbSet<Logfile202311> Logfile202311s { get; set; }

    public virtual DbSet<Logfile202312> Logfile202312s { get; set; }

    public virtual DbSet<Logfile202401> Logfile202401s { get; set; }

    public virtual DbSet<Logfile202402> Logfile202402s { get; set; }

    public virtual DbSet<Logfile202403> Logfile202403s { get; set; }

    public virtual DbSet<Logfile202404> Logfile202404s { get; set; }

    public virtual DbSet<Logfile202405> Logfile202405s { get; set; }

    public virtual DbSet<Logfile202406> Logfile202406s { get; set; }

    public virtual DbSet<Logfile202407> Logfile202407s { get; set; }

    public virtual DbSet<Logfile202408> Logfile202408s { get; set; }

    public virtual DbSet<Logfile202409> Logfile202409s { get; set; }

    public virtual DbSet<Logfile202410> Logfile202410s { get; set; }

    public virtual DbSet<Logfile202411> Logfile202411s { get; set; }

    public virtual DbSet<Logfile202412> Logfile202412s { get; set; }

    public virtual DbSet<Periodtran> Periodtrans { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Promise> Promises { get; set; }

    public virtual DbSet<PromiseMemo> PromiseMemos { get; set; }

    public virtual DbSet<PromiseRemark> PromiseRemarks { get; set; }

    public virtual DbSet<Receiptdesc> Receiptdescs { get; set; }

    public virtual DbSet<ReceiptdescCancel> ReceiptdescCancels { get; set; }

    public virtual DbSet<Receipttran> Receipttrans { get; set; }

    public virtual DbSet<ReceipttranCancel> ReceipttranCancels { get; set; }

    public virtual DbSet<Reinterest> Reinterests { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Userfile> Userfiles { get; set; }

    public virtual DbSet<Userreport> Userreports { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=103.91.204.106;port=3307;user=root;password=OudIaNolEGalEAT;database=01singsiam", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.5.41-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("account")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Acctype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("acctype");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
            entity.Property(e => e.Sumcode)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("sumcode");
        });

        modelBuilder.Entity<Blacklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("blacklist")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Cardid, "cardid").IsUnique();

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Cardid)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("cardid");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("branch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(5)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("address");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Closeconfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("closeconfig")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("tinyint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Rangefrom)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangefrom");
            entity.Property(e => e.Rangeto)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangeto");
        });

        modelBuilder.Entity<Config>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("config")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(3)")
                .HasColumnName("id");
            entity.Property(e => e.AddonMemo)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("addon_memo");
            entity.Property(e => e.Arbranch)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("arbranch");
            entity.Property(e => e.Askamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("askamt");
            entity.Property(e => e.Askpc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("askpc");
            entity.Property(e => e.Asktime)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("asktime");
            entity.Property(e => e.Closeedit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("closeedit");
            entity.Property(e => e.Cutflat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("cutflat");
            entity.Property(e => e.DataMore)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("data_more");
            entity.Property(e => e.Daylate)
                .HasDefaultValueSql("'7'")
                .HasColumnType("int(3)")
                .HasColumnName("daylate");
            entity.Property(e => e.Disablemanual)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("disablemanual");
            entity.Property(e => e.Editfee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("editfee");
            entity.Property(e => e.Externalar)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("externalar");
            entity.Property(e => e.Followamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("followamt");
            entity.Property(e => e.Followpc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("followpc");
            entity.Property(e => e.Followtime)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("followtime");
            entity.Property(e => e.Ftphost)
                .HasMaxLength(50)
                .HasColumnName("ftphost");
            entity.Property(e => e.Ftppass)
                .HasMaxLength(50)
                .HasColumnName("ftppass");
            entity.Property(e => e.Ftppath)
                .HasMaxLength(50)
                .HasColumnName("ftppath");
            entity.Property(e => e.Ftpuser)
                .HasMaxLength(50)
                .HasColumnName("ftpuser");
            entity.Property(e => e.Hurryamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("hurryamt");
            entity.Property(e => e.Hurrypc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("hurrypc");
            entity.Property(e => e.Hurrytime)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("hurrytime");
            entity.Property(e => e.Latecap)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("latecap");
            entity.Property(e => e.Loancontrol)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("loancontrol");
            entity.Property(e => e.Loancreate)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("loancreate");
            entity.Property(e => e.Loanservins)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("loanservins");
            entity.Property(e => e.Localtaxrate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("localtaxrate");
            entity.Property(e => e.Maxins)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(1)")
                .HasColumnName("maxins");
            entity.Property(e => e.Orgaddress)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("orgaddress");
            entity.Property(e => e.Orgname)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("orgname");
            entity.Property(e => e.Orgtelfax)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("orgtelfax");
            entity.Property(e => e.Paymethod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("paymethod");
            entity.Property(e => e.Servicecharge)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("servicecharge");
            entity.Property(e => e.Signname)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("signname");
            entity.Property(e => e.Specialtaxrate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("specialtaxrate");
            entity.Property(e => e.Taxid)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("taxid");
            entity.Property(e => e.Taxrate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("taxrate");
            entity.Property(e => e.Wwwpath)
                .HasMaxLength(50)
                .HasColumnName("wwwpath");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("customer")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Cardid, "cardid").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-'")
                .HasColumnName("address");
            entity.Property(e => e.Arbalance)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("arbalance");
            entity.Property(e => e.Cardexpire)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("cardexpire");
            entity.Property(e => e.Cardexpireformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("cardexpireformat");
            entity.Property(e => e.Cardid)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("cardid");
            entity.Property(e => e.HomeE)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("home_e");
            entity.Property(e => e.HomeN)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("home_n");
            entity.Property(e => e.Homemap)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("homemap");
            entity.Property(e => e.Jobdesc)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("jobdesc");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
            entity.Property(e => e.Nickname)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("nickname");
            entity.Property(e => e.Office)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("office");
            entity.Property(e => e.OfficeE)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("office_e");
            entity.Property(e => e.OfficeN)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("office_n");
            entity.Property(e => e.Officeaddress)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-'")
                .HasColumnName("officeaddress");
            entity.Property(e => e.Officemap)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("officemap");
            entity.Property(e => e.Officetel)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("officetel");
            entity.Property(e => e.Reference)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("reference");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("status");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<Expincome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("expincome")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Accno)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("accno");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Docno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'10'")
                .HasColumnName("docno");
            entity.Property(e => e.Expense)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("expense");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("income");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Externalar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("externalar")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Aramount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("aramount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Docno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("docno");
            entity.Property(e => e.Flg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("flg");
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ExternalarDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("externalar_detail")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Cutamount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("cutamount");
            entity.Property(e => e.Docno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("docno");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Insurance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("insurance")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("tinyint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Rangefrom)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangefrom");
            entity.Property(e => e.Rangeto)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangeto");
        });

        modelBuilder.Entity<Lateconfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("lateconfig")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("tinyint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.FIntpc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("f_intpc");
            entity.Property(e => e.LIntpc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("l_intpc");
            entity.Property(e => e.Rangefrom)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangefrom");
            entity.Property(e => e.Rangeto)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rangeto");
        });

        modelBuilder.Entity<Logfile201301>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201301")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201701>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201701")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201712>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201712")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201801>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201801")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201802>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201802")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201803>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201803")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201804>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201804")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201805>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201805")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201806>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201806")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201807>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201807")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201808>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201808")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201809>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201809")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201810>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201810")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201811>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201811")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201812>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201812")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201901>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201901")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201902>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201902")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201903>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201903")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201904>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201904")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201905>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201905")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201906>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201906")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201907>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201907")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201908>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201908")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201909>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201909")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201910>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201910")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201911>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201911")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile201912>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_201912")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202001>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202001")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202002>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202002")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202003>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202003")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202004>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202004")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202005>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202005")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202006>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202006")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202007>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202007")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202008>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202008")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202009>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202009")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202010>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202010")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202011>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202011")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202012>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202012")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202101>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202101")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202102>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202102")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202103>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202103")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202104>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202104")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202105>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202105")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202106>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202106")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202107>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202107")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202108>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202108")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202109>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202109")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202110>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202110")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202111>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202111")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202112>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202112")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202201>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202201")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202202>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202202")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202203>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202203")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202204>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202204")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202205>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202205")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202206>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202206")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202207>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202207")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202208>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202208")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202209>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202209")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202210>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202210")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202211>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202211")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202212>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202212")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202301>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202301")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202302>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202302")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202303>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202303")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202304>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202304")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202305>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202305")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202306>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202306")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202307>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202307")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202308>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202308")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202309>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202309")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202310>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202310")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202311>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202311")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202312>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202312")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202401>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202401")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202402>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202402")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202403>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202403")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202404>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202404")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202405>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202405")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202406>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202406")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202407>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202407")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202408>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202408")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202409>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202409")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202410>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202410")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202411>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202411")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Logfile202412>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202412")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Branch, "batchno");

            entity.HasIndex(e => e.Usercode, "usercode");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Section)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("section");
            entity.Property(e => e.Tdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdesc");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Periodtran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("periodtran")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("interest");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("periods");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("refcode");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("status");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("product")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cancelfee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cancelfee");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Colname1)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname1");
            entity.Property(e => e.Colname2)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname2");
            entity.Property(e => e.Colname3)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname3");
            entity.Property(e => e.Colname4)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname4");
            entity.Property(e => e.Colname5)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname5");
            entity.Property(e => e.Colname6)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname6");
            entity.Property(e => e.Colname7)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname7");
            entity.Property(e => e.Colname8)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname8");
            entity.Property(e => e.Colname9)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname9");
            entity.Property(e => e.Financemax)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("financemax");
            entity.Property(e => e.Financerate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("financerate");
            entity.Property(e => e.Loanmax)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("loanmax");
            entity.Property(e => e.Loanrate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("loanrate");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Promise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("promise")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Promiseno, "promiseno").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cancelno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("cancelno");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Closecase)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("closecase");
            entity.Property(e => e.Closedocno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("closedocno");
            entity.Property(e => e.Closeresult)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("closeresult");
            entity.Property(e => e.Coldata1)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata1");
            entity.Property(e => e.Coldata2)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata2");
            entity.Property(e => e.Coldata3)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata3");
            entity.Property(e => e.Coldata4)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata4");
            entity.Property(e => e.Coldata5)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata5");
            entity.Property(e => e.Coldata6)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata6");
            entity.Property(e => e.Coldata7)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata7");
            entity.Property(e => e.Coldata8)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata8");
            entity.Property(e => e.Coldata9)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("coldata9");
            entity.Property(e => e.Colname1)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname1");
            entity.Property(e => e.Colname2)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname2");
            entity.Property(e => e.Colname3)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname3");
            entity.Property(e => e.Colname4)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname4");
            entity.Property(e => e.Colname5)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname5");
            entity.Property(e => e.Colname6)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname6");
            entity.Property(e => e.Colname7)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname7");
            entity.Property(e => e.Colname8)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname8");
            entity.Property(e => e.Colname9)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("colname9");
            entity.Property(e => e.Compromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("compromise");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Dateclose)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("dateclose");
            entity.Property(e => e.Dateclosecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("dateclosecal");
            entity.Property(e => e.Dateclosecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("dateclosecalformat");
            entity.Property(e => e.Datecloseformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("datecloseformat");
            entity.Property(e => e.Datewarn)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("datewarn");
            entity.Property(e => e.Datewarnformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("datewarnformat");
            entity.Property(e => e.Daypaid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("daypaid");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Downamount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("downamount");
            entity.Property(e => e.Firstdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("firstdate");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("insurance");
            entity.Property(e => e.Insurance1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("insurance1");
            entity.Property(e => e.Insurance1relation)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("insurance1relation");
            entity.Property(e => e.Insurance2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("insurance2");
            entity.Property(e => e.Insurance2relation)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("insurance2relation");
            entity.Property(e => e.Intrate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("intrate");
            entity.Property(e => e.Latepc)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("latepc");
            entity.Property(e => e.Nampa)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("nampa");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("periods");
            entity.Property(e => e.Person1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("person1");
            entity.Property(e => e.Person2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("person2");
            entity.Property(e => e.Person3)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("person3");
            entity.Property(e => e.Person4)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("person4");
            entity.Property(e => e.Person5)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("person5");
            entity.Property(e => e.Prddesc)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("prddesc");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("refcode");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("status");
            entity.Property(e => e.Stockcode)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("stockcode");
            entity.Property(e => e.Sumcharge1)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("sumcharge1");
            entity.Property(e => e.Sumcharge2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("sumcharge2");
            entity.Property(e => e.Sumstatus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("sumstatus");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Totaldown)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("totaldown");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
            entity.Property(e => e.Warndesc)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("warndesc");
        });

        modelBuilder.Entity<PromiseMemo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("promise_memo")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Descrip)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("descrip");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("refcode");
            entity.Property(e => e.Remark)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("remark");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<PromiseRemark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("promise_remark")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .HasDefaultValueSql("'-'")
                .HasColumnName("remark");
            entity.Property(e => e.Tdatetime)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Tdatetimeformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatetimeformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Receiptdesc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("receiptdesc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ReceiptdescCancel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("receiptdesc_cancel")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Lateamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("lateamt");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("period");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Perioddate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("perioddate");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Receipttran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("receipttran")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Arbalance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("arbalance");
            entity.Property(e => e.Arperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("arperiod");
            entity.Property(e => e.Arremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("arremain");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Capremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capremain");
            entity.Property(e => e.Cashpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("cashpaid");
            entity.Property(e => e.Charge1amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge1amt");
            entity.Property(e => e.Charge2amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge2amt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Closecase)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("closecase");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("closefee");
            entity.Property(e => e.Currentperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("currentperiod");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("discount");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intdiscamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intdiscamt");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intplus");
            entity.Property(e => e.Intremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intremain");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("netamount");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Otherpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("otherpaid");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Periodremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("periodremain");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptdesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptdesc");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Resultamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("resultamount");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Transferdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("transferdate");
            entity.Property(e => e.Transferpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("transferpaid");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<ReceipttranCancel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("receipttran_cancel")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Id, "id");

            entity.HasIndex(e => e.Promiseno, "promiseno");

            entity.HasIndex(e => e.Receiptno, "receiptno");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Arbalance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("arbalance");
            entity.Property(e => e.Arperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("arperiod");
            entity.Property(e => e.Arremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("arremain");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Capremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capremain");
            entity.Property(e => e.Cashpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("cashpaid");
            entity.Property(e => e.Charge1amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge1amt");
            entity.Property(e => e.Charge2amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge2amt");
            entity.Property(e => e.Clientbranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientbranch");
            entity.Property(e => e.Clientno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("clientno");
            entity.Property(e => e.Closecase)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("closecase");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("closefee");
            entity.Property(e => e.Currentperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("currentperiod");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("discount");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Intdiscamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intdiscamt");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intplus");
            entity.Property(e => e.Intremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intremain");
            entity.Property(e => e.Loanminus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanminus");
            entity.Property(e => e.Loanplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("loanplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("netamount");
            entity.Property(e => e.Newint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newint");
            entity.Property(e => e.Oldint)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldint");
            entity.Property(e => e.Otherpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("otherpaid");
            entity.Property(e => e.Periodchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("periodchg");
            entity.Property(e => e.Periodremain)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("periodremain");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("ptype");
            entity.Property(e => e.Receiptdesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptdesc");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Resultamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("resultamount");
            entity.Property(e => e.Specialtaxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("specialtaxpromise");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Taxpromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("taxpromise");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdatecal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecal");
            entity.Property(e => e.Tdatecalformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdatecalformat");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
            entity.Property(e => e.Transferdate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("transferdate");
            entity.Property(e => e.Transferpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("transferpaid");
            entity.Property(e => e.Usercode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("usercode");
        });

        modelBuilder.Entity<Reinterest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("reinterest")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Artotal)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("artotal");
            entity.Property(e => e.Batchno)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("batchno");
            entity.Property(e => e.Customer)
                .HasMaxLength(15)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer_name");
            entity.Property(e => e.Days)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("days");
            entity.Property(e => e.Latetotal)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("latetotal");
            entity.Property(e => e.Newcapital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newcapital");
            entity.Property(e => e.Newinterest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("newinterest");
            entity.Property(e => e.Oldcapital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("oldcapital");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("periods");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("refcode");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
            entity.Property(e => e.Tdateformat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdateformat");
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("station")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Stationno, "stationno").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Accdocno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("accdocno");
            entity.Property(e => e.Addcapno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("addcapno");
            entity.Property(e => e.Arpaidno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("arpaidno");
            entity.Property(e => e.Batchno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("batchno");
            entity.Property(e => e.Branch)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("branch");
            entity.Property(e => e.Cloudcamera)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("cloudcamera");
            entity.Property(e => e.Color1)
                .HasDefaultValueSql("'16777168'")
                .HasColumnType("double(10,0)")
                .HasColumnName("color1");
            entity.Property(e => e.Color2)
                .HasDefaultValueSql("'4194304'")
                .HasColumnType("double(10,0)")
                .HasColumnName("color2");
            entity.Property(e => e.Color3)
                .HasDefaultValueSql("'16777168'")
                .HasColumnType("double(10,0)")
                .HasColumnName("color3");
            entity.Property(e => e.Color4)
                .HasDefaultValueSql("'4194304'")
                .HasColumnType("double(10,0)")
                .HasColumnName("color4");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("ipaddress");
            entity.Property(e => e.Macaddress)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("macaddress");
            entity.Property(e => e.Promiseno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("promiseno");
            entity.Property(e => e.Receiptno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("receiptno");
            entity.Property(e => e.Specialtaxreceive)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("specialtaxreceive");
            entity.Property(e => e.Stationno)
                .HasMaxLength(5)
                .HasDefaultValueSql("'-'")
                .HasColumnName("stationno");
            entity.Property(e => e.Taxreceive)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("taxreceive");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("stock")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Data1)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data1");
            entity.Property(e => e.Data2)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data2");
            entity.Property(e => e.Data3)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data3");
            entity.Property(e => e.Data4)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data4");
            entity.Property(e => e.Data5)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data5");
            entity.Property(e => e.Data6)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data6");
            entity.Property(e => e.Data7)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data7");
            entity.Property(e => e.Data8)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data8");
            entity.Property(e => e.Data9)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("data9");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("price");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Userfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("userfile")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Adminflg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("adminflg");
            entity.Property(e => e.Branchchg)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("branchchg");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Menu1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu1");
            entity.Property(e => e.Menu2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu2");
            entity.Property(e => e.Menu3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu3");
            entity.Property(e => e.Menu4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu4");
            entity.Property(e => e.Menu5)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu5");
            entity.Property(e => e.Menu6)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu6");
            entity.Property(e => e.Menu7)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu7");
            entity.Property(e => e.Menu8)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu8");
            entity.Property(e => e.Menu9)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("menu9");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("password");
        });

        modelBuilder.Entity<Userreport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("userreport")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Allow)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("allow");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code");
            entity.Property(e => e.Menucode)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("menucode");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
