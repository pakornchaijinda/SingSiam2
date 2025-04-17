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

    public virtual DbSet<Listpromise> Listpromises { get; set; }

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

    public virtual DbSet<Logfile202501> Logfile202501s { get; set; }

    public virtual DbSet<Logfile202502> Logfile202502s { get; set; }

    public virtual DbSet<Logfile202503> Logfile202503s { get; set; }

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

    public virtual DbSet<ZzRaw0Ca> ZzRaw0Cas { get; set; }

    public virtual DbSet<ZzRaw0Cb> ZzRaw0Cbs { get; set; }

    public virtual DbSet<ZzRaw0Cc> ZzRaw0Ccs { get; set; }

    public virtual DbSet<ZzRaw0Cd> ZzRaw0Cds { get; set; }

    public virtual DbSet<ZzRaw0Ce> ZzRaw0Ces { get; set; }

    public virtual DbSet<ZzRaw0Cf> ZzRaw0Cfs { get; set; }

    public virtual DbSet<ZzRaw0Cg> ZzRaw0Cgs { get; set; }

    public virtual DbSet<ZzRaw0Ch> ZzRaw0Ches { get; set; }

    public virtual DbSet<ZzRaw0Ci> ZzRaw0Cis { get; set; }

    public virtual DbSet<ZzRaw0Ck> ZzRaw0Cks { get; set; }

    public virtual DbSet<ZzRaw0Cl> ZzRaw0Cls { get; set; }

    public virtual DbSet<ZzRaw0Cm> ZzRaw0Cms { get; set; }

    public virtual DbSet<ZzRaw0Cn> ZzRaw0Cns { get; set; }

    public virtual DbSet<ZzRaw0Co> ZzRaw0Cos { get; set; }

    public virtual DbSet<ZzRaw0Cp> ZzRaw0Cps { get; set; }

    public virtual DbSet<ZzRaw0Pa> ZzRaw0Pas { get; set; }

    public virtual DbSet<ZzRaw0Pb> ZzRaw0Pbs { get; set; }

    public virtual DbSet<ZzRaw1Ca> ZzRaw1Cas { get; set; }

    public virtual DbSet<ZzRaw1Cb> ZzRaw1Cbs { get; set; }

    public virtual DbSet<ZzRaw1Cc> ZzRaw1Ccs { get; set; }

    public virtual DbSet<ZzRaw1Cd> ZzRaw1Cds { get; set; }

    public virtual DbSet<ZzRaw1Ce> ZzRaw1Ces { get; set; }

    public virtual DbSet<ZzRaw1Cf> ZzRaw1Cfs { get; set; }

    public virtual DbSet<ZzRaw1Cg> ZzRaw1Cgs { get; set; }

    public virtual DbSet<ZzRaw1Ch> ZzRaw1Ches { get; set; }

    public virtual DbSet<ZzRaw1Ci> ZzRaw1Cis { get; set; }

    public virtual DbSet<ZzRaw1Ck> ZzRaw1Cks { get; set; }

    public virtual DbSet<ZzRaw1Cl> ZzRaw1Cls { get; set; }

    public virtual DbSet<ZzRaw1Cm> ZzRaw1Cms { get; set; }

    public virtual DbSet<ZzRaw1Cn> ZzRaw1Cns { get; set; }

    public virtual DbSet<ZzRaw1Co> ZzRaw1Cos { get; set; }

    public virtual DbSet<ZzRaw1Cp> ZzRaw1Cps { get; set; }

    public virtual DbSet<ZzRaw1Cq> ZzRaw1Cqs { get; set; }

    public virtual DbSet<ZzRaw1Pa> ZzRaw1Pas { get; set; }

    public virtual DbSet<ZzRaw1Pb> ZzRaw1Pbs { get; set; }

    public virtual DbSet<ZzRaw1Pc> ZzRaw1Pcs { get; set; }

    public virtual DbSet<ZzRaw2Ca> ZzRaw2Cas { get; set; }

    public virtual DbSet<ZzRaw2Cb> ZzRaw2Cbs { get; set; }

    public virtual DbSet<ZzRaw2Cc> ZzRaw2Ccs { get; set; }

    public virtual DbSet<ZzRaw2Cd> ZzRaw2Cds { get; set; }

    public virtual DbSet<ZzRaw2Ce> ZzRaw2Ces { get; set; }

    public virtual DbSet<ZzRaw2Cf> ZzRaw2Cfs { get; set; }

    public virtual DbSet<ZzRaw2Cg> ZzRaw2Cgs { get; set; }

    public virtual DbSet<ZzRaw2Ch> ZzRaw2Ches { get; set; }

    public virtual DbSet<ZzRaw2Ci> ZzRaw2Cis { get; set; }

    public virtual DbSet<ZzRaw2Ck> ZzRaw2Cks { get; set; }

    public virtual DbSet<ZzRaw2Cl> ZzRaw2Cls { get; set; }

    public virtual DbSet<ZzRaw2Cm> ZzRaw2Cms { get; set; }

    public virtual DbSet<ZzRaw2Cn> ZzRaw2Cns { get; set; }

    public virtual DbSet<ZzRaw2Co> ZzRaw2Cos { get; set; }

    public virtual DbSet<ZzRaw2Cp> ZzRaw2Cps { get; set; }

    public virtual DbSet<ZzRaw2Cq> ZzRaw2Cqs { get; set; }

    public virtual DbSet<ZzRaw2Pa> ZzRaw2Pas { get; set; }

    public virtual DbSet<ZzRaw2Pb> ZzRaw2Pbs { get; set; }

    public virtual DbSet<ZzRaw2Pc> ZzRaw2Pcs { get; set; }

    public virtual DbSet<ZzRaw3Ca> ZzRaw3Cas { get; set; }

    public virtual DbSet<ZzRaw3Cb> ZzRaw3Cbs { get; set; }

    public virtual DbSet<ZzRaw3Cc> ZzRaw3Ccs { get; set; }

    public virtual DbSet<ZzRaw3Cd> ZzRaw3Cds { get; set; }

    public virtual DbSet<ZzRaw3Ce> ZzRaw3Ces { get; set; }

    public virtual DbSet<ZzRaw3Cf> ZzRaw3Cfs { get; set; }

    public virtual DbSet<ZzRaw3Cg> ZzRaw3Cgs { get; set; }

    public virtual DbSet<ZzRaw3Ch> ZzRaw3Ches { get; set; }

    public virtual DbSet<ZzRaw3Ci> ZzRaw3Cis { get; set; }

    public virtual DbSet<ZzRaw3Ck> ZzRaw3Cks { get; set; }

    public virtual DbSet<ZzRaw3Cl> ZzRaw3Cls { get; set; }

    public virtual DbSet<ZzRaw3Cm> ZzRaw3Cms { get; set; }

    public virtual DbSet<ZzRaw3Cn> ZzRaw3Cns { get; set; }

    public virtual DbSet<ZzRaw3Co> ZzRaw3Cos { get; set; }

    public virtual DbSet<ZzRaw3Cp> ZzRaw3Cps { get; set; }

    public virtual DbSet<ZzRaw3Cq> ZzRaw3Cqs { get; set; }

    public virtual DbSet<ZzRaw3Pa> ZzRaw3Pas { get; set; }

    public virtual DbSet<ZzRaw3Pb> ZzRaw3Pbs { get; set; }

    public virtual DbSet<ZzRaw3Pc> ZzRaw3Pcs { get; set; }

    public virtual DbSet<ZzRaw4Ca> ZzRaw4Cas { get; set; }

    public virtual DbSet<ZzRaw4Cb> ZzRaw4Cbs { get; set; }

    public virtual DbSet<ZzRaw4Cc> ZzRaw4Ccs { get; set; }

    public virtual DbSet<ZzRaw4Cd> ZzRaw4Cds { get; set; }

    public virtual DbSet<ZzRaw4Ce> ZzRaw4Ces { get; set; }

    public virtual DbSet<ZzRaw4Cf> ZzRaw4Cfs { get; set; }

    public virtual DbSet<ZzRaw4Cg> ZzRaw4Cgs { get; set; }

    public virtual DbSet<ZzRaw4Ch> ZzRaw4Ches { get; set; }

    public virtual DbSet<ZzRaw4Ci> ZzRaw4Cis { get; set; }

    public virtual DbSet<ZzRaw4Ck> ZzRaw4Cks { get; set; }

    public virtual DbSet<ZzRaw4Cl> ZzRaw4Cls { get; set; }

    public virtual DbSet<ZzRaw4Cm> ZzRaw4Cms { get; set; }

    public virtual DbSet<ZzRaw4Cn> ZzRaw4Cns { get; set; }

    public virtual DbSet<ZzRaw4Co> ZzRaw4Cos { get; set; }

    public virtual DbSet<ZzRaw4Cp> ZzRaw4Cps { get; set; }

    public virtual DbSet<ZzRaw4Cq> ZzRaw4Cqs { get; set; }

    public virtual DbSet<ZzRaw4Pa> ZzRaw4Pas { get; set; }

    public virtual DbSet<ZzRaw4Pb> ZzRaw4Pbs { get; set; }

    public virtual DbSet<ZzRaw4Pc> ZzRaw4Pcs { get; set; }

    public virtual DbSet<ZzRaw5Ca> ZzRaw5Cas { get; set; }

    public virtual DbSet<ZzRaw5Cb> ZzRaw5Cbs { get; set; }

    public virtual DbSet<ZzRaw5Cc> ZzRaw5Ccs { get; set; }

    public virtual DbSet<ZzRaw5Cd> ZzRaw5Cds { get; set; }

    public virtual DbSet<ZzRaw5Ce> ZzRaw5Ces { get; set; }

    public virtual DbSet<ZzRaw5Cf> ZzRaw5Cfs { get; set; }

    public virtual DbSet<ZzRaw5Cg> ZzRaw5Cgs { get; set; }

    public virtual DbSet<ZzRaw5Ch> ZzRaw5Ches { get; set; }

    public virtual DbSet<ZzRaw5Ci> ZzRaw5Cis { get; set; }

    public virtual DbSet<ZzRaw5Ck> ZzRaw5Cks { get; set; }

    public virtual DbSet<ZzRaw5Cl> ZzRaw5Cls { get; set; }

    public virtual DbSet<ZzRaw5Cm> ZzRaw5Cms { get; set; }

    public virtual DbSet<ZzRaw5Cn> ZzRaw5Cns { get; set; }

    public virtual DbSet<ZzRaw5Co> ZzRaw5Cos { get; set; }

    public virtual DbSet<ZzRaw5Cp> ZzRaw5Cps { get; set; }

    public virtual DbSet<ZzRaw5Cq> ZzRaw5Cqs { get; set; }

    public virtual DbSet<ZzRaw5Pa> ZzRaw5Pas { get; set; }

    public virtual DbSet<ZzRaw5Pb> ZzRaw5Pbs { get; set; }

    public virtual DbSet<ZzRaw5Pc> ZzRaw5Pcs { get; set; }

    public virtual DbSet<ZzRaw6Ca> ZzRaw6Cas { get; set; }

    public virtual DbSet<ZzRaw6Cb> ZzRaw6Cbs { get; set; }

    public virtual DbSet<ZzRaw6Cc> ZzRaw6Ccs { get; set; }

    public virtual DbSet<ZzRaw6Cd> ZzRaw6Cds { get; set; }

    public virtual DbSet<ZzRaw6Ce> ZzRaw6Ces { get; set; }

    public virtual DbSet<ZzRaw6Cf> ZzRaw6Cfs { get; set; }

    public virtual DbSet<ZzRaw6Cg> ZzRaw6Cgs { get; set; }

    public virtual DbSet<ZzRaw6Ch> ZzRaw6Ches { get; set; }

    public virtual DbSet<ZzRaw6Ci> ZzRaw6Cis { get; set; }

    public virtual DbSet<ZzRaw6Ck> ZzRaw6Cks { get; set; }

    public virtual DbSet<ZzRaw6Cl> ZzRaw6Cls { get; set; }

    public virtual DbSet<ZzRaw6Cm> ZzRaw6Cms { get; set; }

    public virtual DbSet<ZzRaw6Cn> ZzRaw6Cns { get; set; }

    public virtual DbSet<ZzRaw6Co> ZzRaw6Cos { get; set; }

    public virtual DbSet<ZzRaw6Cp> ZzRaw6Cps { get; set; }

    public virtual DbSet<ZzRaw6Cq> ZzRaw6Cqs { get; set; }

    public virtual DbSet<ZzRaw6Pa> ZzRaw6Pas { get; set; }

    public virtual DbSet<ZzRaw6Pb> ZzRaw6Pbs { get; set; }

    public virtual DbSet<ZzRaw6Pc> ZzRaw6Pcs { get; set; }

    public virtual DbSet<ZzRaw7Ca> ZzRaw7Cas { get; set; }

    public virtual DbSet<ZzRaw7Cb> ZzRaw7Cbs { get; set; }

    public virtual DbSet<ZzRaw7Cc> ZzRaw7Ccs { get; set; }

    public virtual DbSet<ZzRaw7Cd> ZzRaw7Cds { get; set; }

    public virtual DbSet<ZzRaw7Ce> ZzRaw7Ces { get; set; }

    public virtual DbSet<ZzRaw7Cf> ZzRaw7Cfs { get; set; }

    public virtual DbSet<ZzRaw7Cg> ZzRaw7Cgs { get; set; }

    public virtual DbSet<ZzRaw7Ch> ZzRaw7Ches { get; set; }

    public virtual DbSet<ZzRaw7Ci> ZzRaw7Cis { get; set; }

    public virtual DbSet<ZzRaw7Ck> ZzRaw7Cks { get; set; }

    public virtual DbSet<ZzRaw7Cl> ZzRaw7Cls { get; set; }

    public virtual DbSet<ZzRaw7Cm> ZzRaw7Cms { get; set; }

    public virtual DbSet<ZzRaw7Cn> ZzRaw7Cns { get; set; }

    public virtual DbSet<ZzRaw7Co> ZzRaw7Cos { get; set; }

    public virtual DbSet<ZzRaw7Cp> ZzRaw7Cps { get; set; }

    public virtual DbSet<ZzRaw7Cq> ZzRaw7Cqs { get; set; }

    public virtual DbSet<ZzRaw7Pa> ZzRaw7Pas { get; set; }

    public virtual DbSet<ZzRaw7Pb> ZzRaw7Pbs { get; set; }

    public virtual DbSet<ZzRaw7Pc> ZzRaw7Pcs { get; set; }

    public virtual DbSet<ZzRepCa> ZzRepCas { get; set; }

    public virtual DbSet<ZzRepCb> ZzRepCbs { get; set; }

    public virtual DbSet<ZzRepCc> ZzRepCcs { get; set; }

    public virtual DbSet<ZzRepCd> ZzRepCds { get; set; }

    public virtual DbSet<ZzRepCe> ZzRepCes { get; set; }

    public virtual DbSet<ZzRepCf> ZzRepCfs { get; set; }

    public virtual DbSet<ZzRepCg> ZzRepCgs { get; set; }

    public virtual DbSet<ZzRepCh> ZzRepChes { get; set; }

    public virtual DbSet<ZzRepCi> ZzRepCis { get; set; }

    public virtual DbSet<ZzRepCk> ZzRepCks { get; set; }

    public virtual DbSet<ZzRepCl> ZzRepCls { get; set; }

    public virtual DbSet<ZzRepCm> ZzRepCms { get; set; }

    public virtual DbSet<ZzRepCn> ZzRepCns { get; set; }

    public virtual DbSet<ZzRepCo> ZzRepCos { get; set; }

    public virtual DbSet<ZzRepCp> ZzRepCps { get; set; }

    public virtual DbSet<ZzRepCq> ZzRepCqs { get; set; }

    public virtual DbSet<ZzRepPa> ZzRepPas { get; set; }

    public virtual DbSet<ZzRepPb> ZzRepPbs { get; set; }

    public virtual DbSet<ZzRepPc> ZzRepPcs { get; set; }

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
            entity.Property(e => e.Editdate)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("editdate");
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
            entity.Property(e => e.Birthdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("birthdate");
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

        modelBuilder.Entity<Listpromise>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("listpromises");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Closecase)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("closecase")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Closedocno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("closedocno")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("code")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("customer")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("name")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Refcode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'")
                .HasColumnName("refcode")
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Status)
                .HasMaxLength(18)
                .HasColumnName("status")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.Tdatetime)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnName("tdatetime");
            entity.Property(e => e.Type)
                .HasMaxLength(12)
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
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

        modelBuilder.Entity<Logfile202501>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202501")
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

        modelBuilder.Entity<Logfile202502>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202502")
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

        modelBuilder.Entity<Logfile202503>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("logfile_202503")
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

        modelBuilder.Entity<ZzRaw0Ca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_ca")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Cb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_cb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Cc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_cc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Cd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_cd")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Ce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_ce")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Cf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_cf")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Cg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_cg")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Ch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_ch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Ci>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_ci")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Ck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_ck")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Cl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_cl")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Cm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_cm")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Cn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_cn")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Co>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_co")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Cp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_cp")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Pa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_pa")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw0Pb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw0_pb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw1Ca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_ca")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
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
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
        });

        modelBuilder.Entity<ZzRaw1Cc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cd")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
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
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
        });

        modelBuilder.Entity<ZzRaw1Ce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_ce")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cf")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cg")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
        });

        modelBuilder.Entity<ZzRaw1Ch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_ch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Ci>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_ci")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
        });

        modelBuilder.Entity<ZzRaw1Ck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_ck")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cl")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
        });

        modelBuilder.Entity<ZzRaw1Cm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cm")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw1Cn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cn")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
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
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("service");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
        });

        modelBuilder.Entity<ZzRaw1Co>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_co")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
        });

        modelBuilder.Entity<ZzRaw1Cp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cp")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
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

        modelBuilder.Entity<ZzRaw1Cq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_cq")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
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

        modelBuilder.Entity<ZzRaw1Pa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_pa")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
        });

        modelBuilder.Entity<ZzRaw1Pb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_pb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
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

        modelBuilder.Entity<ZzRaw1Pc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw1_pc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
        });

        modelBuilder.Entity<ZzRaw2Ca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_ca")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Charge1amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge1amt");
            entity.Property(e => e.Charge2amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge2amt");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("closefee");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("discount");
            entity.Property(e => e.Intdiscamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intdiscamt");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("netamount");
            entity.Property(e => e.Pamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pamount");
            entity.Property(e => e.Pcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pcappaid");
            entity.Property(e => e.Pdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("pdate");
            entity.Property(e => e.Pintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pintpaid");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
        });

        modelBuilder.Entity<ZzRaw2Cc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cd")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Charge1amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge1amt");
            entity.Property(e => e.Charge2amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge2amt");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("closefee");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("discount");
            entity.Property(e => e.Intdiscamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intdiscamt");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("netamount");
            entity.Property(e => e.Pamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pamount");
            entity.Property(e => e.Pcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pcappaid");
            entity.Property(e => e.Pdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("pdate");
            entity.Property(e => e.Pintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pintpaid");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
        });

        modelBuilder.Entity<ZzRaw2Ce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_ce")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cf")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cg")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw2Ch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_ch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Ci>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_ci")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw2Ck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_ck")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cl")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw2Cm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cm")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw2Cn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cn")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Charge1amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge1amt");
            entity.Property(e => e.Charge2amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge2amt");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("closefee");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("discount");
            entity.Property(e => e.Intdiscamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intdiscamt");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intplus");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("netamount");
            entity.Property(e => e.Pamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pamount");
            entity.Property(e => e.Pcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pcappaid");
            entity.Property(e => e.Pdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("pdate");
            entity.Property(e => e.Pintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pintpaid");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
        });

        modelBuilder.Entity<ZzRaw2Co>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_co")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw2Cp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cp")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
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

        modelBuilder.Entity<ZzRaw2Cq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_cq")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
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

        modelBuilder.Entity<ZzRaw2Pa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_pa")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw2Pb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_pb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
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

        modelBuilder.Entity<ZzRaw2Pc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw2_pc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Ca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_ca")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
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
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ramount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("ramount");
            entity.Property(e => e.Rcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rcappaid");
            entity.Property(e => e.Rdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("rdate");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Rintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rintpaid");
            entity.Property(e => e.Rperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("rperiod");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
        });

        modelBuilder.Entity<ZzRaw3Cc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cd")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
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
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ramount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("ramount");
            entity.Property(e => e.Rcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rcappaid");
            entity.Property(e => e.Rdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("rdate");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Rintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rintpaid");
            entity.Property(e => e.Rperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("rperiod");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
        });

        modelBuilder.Entity<ZzRaw3Ce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_ce")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cf")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cg")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Ch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_ch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Ci>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_ci")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Ck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_ck")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cl")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Cm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cm")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw3Cn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cn")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
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
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ramount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("ramount");
            entity.Property(e => e.Rcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rcappaid");
            entity.Property(e => e.Rdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("rdate");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Rintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rintpaid");
            entity.Property(e => e.Rperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("rperiod");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
        });

        modelBuilder.Entity<ZzRaw3Co>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_co")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Cp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cp")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Cq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_cq")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Pa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_pa")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw3Pb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_pb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
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
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ramount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("ramount");
            entity.Property(e => e.Rcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rcappaid");
            entity.Property(e => e.Rdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("rdate");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Rintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rintpaid");
            entity.Property(e => e.Rperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)")
                .HasColumnName("rperiod");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
        });

        modelBuilder.Entity<ZzRaw3Pc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw3_pc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Ca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_ca")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("interest");
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
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Pid)
                .HasColumnType("int(10)")
                .HasColumnName("pid");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ramount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("ramount");
            entity.Property(e => e.Rcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rcappaid");
            entity.Property(e => e.Rdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("rdate");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Rintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rintpaid");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
        });

        modelBuilder.Entity<ZzRaw4Cc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cd")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("interest");
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
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Pid)
                .HasColumnType("int(10)")
                .HasColumnName("pid");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ramount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("ramount");
            entity.Property(e => e.Rcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rcappaid");
            entity.Property(e => e.Rdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("rdate");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Rintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rintpaid");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
        });

        modelBuilder.Entity<ZzRaw4Ce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_ce")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cf")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cg")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Ch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_ch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Ci>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_ci")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Ck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_ck")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cl")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Cm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cm")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw4Cn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cn")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("interest");
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
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Pid)
                .HasColumnType("int(10)")
                .HasColumnName("pid");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ramount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("ramount");
            entity.Property(e => e.Rcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rcappaid");
            entity.Property(e => e.Rdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("rdate");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Rintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rintpaid");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
        });

        modelBuilder.Entity<ZzRaw4Co>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_co")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Cp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cp")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Cq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_cq")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Pa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_pa")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw4Pb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_pb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("deposit");
            entity.Property(e => e.Inspaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("inspaid");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("interest");
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
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Pid)
                .HasColumnType("int(10)")
                .HasColumnName("pid");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ramount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("ramount");
            entity.Property(e => e.Rcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rcappaid");
            entity.Property(e => e.Rdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("rdate");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Rintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rintpaid");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
        });

        modelBuilder.Entity<ZzRaw4Pc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw4_pc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.InsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Ca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_ca")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cd")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Ce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_ce")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cf")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cg")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Ch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_ch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Ci>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_ci")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Ck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_ck")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cl")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Cm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cm")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Cn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cn")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw5Co>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_co")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Cp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cp")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Cq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_cq")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Pa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_pa")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Pb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_pb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw5Pc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw5_pc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Ca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_ca")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cd")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Ce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_ce")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cf")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cg")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Ch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_ch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Ci>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_ci")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Ck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_ck")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cl")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cm")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Cn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cn")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Co>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_co")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Cp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cp")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Cq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_cq")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Pa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_pa")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRaw6Pb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_pb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw6Pc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw6_pc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Periodamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("periodamt");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Ca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_ca")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cd")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Ce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_ce")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cf")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cg")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Ch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_ch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Ci>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_ci")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Ck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_ck")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cl")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cm")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cn")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Co>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_co")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cp")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Cq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_cq")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Pa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_pa")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Pb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_pb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRaw7Pc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_raw7_pc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount1).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CapPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.CapPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital1).HasColumnType("double(17,0)");
            entity.Property(e => e.Capital2).HasColumnType("double(17,0)");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.InsPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.InsPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.IntPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest1).HasColumnType("double(17,0)");
            entity.Property(e => e.Interest2).HasColumnType("double(17,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PaidAmount1).HasColumnType("double(17,0)");
            entity.Property(e => e.PaidAmount2).HasColumnType("double(17,0)");
            entity.Property(e => e.Period1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.Period2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(21)");
            entity.Property(e => e.PeriodAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.SrvPaid1).HasColumnType("double(17,0)");
            entity.Property(e => e.SrvPaid2).HasColumnType("double(17,0)");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepCa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_ca")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
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

        modelBuilder.Entity<ZzRepCb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepCc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepCd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("zz_rep_cd")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("amount");
            entity.Property(e => e.Balance)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)")
                .HasColumnName("balance");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("capital");
            entity.Property(e => e.Cappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("cappaid");
            entity.Property(e => e.Charge1amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge1amt");
            entity.Property(e => e.Charge2amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("charge2amt");
            entity.Property(e => e.Chargeamt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("chargeamt");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("closefee");
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
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("interest");
            entity.Property(e => e.Intpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intpaid");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("intplus");
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
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("netamount");
            entity.Property(e => e.Paidamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("paidamount");
            entity.Property(e => e.Pamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pamount");
            entity.Property(e => e.Pcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pcappaid");
            entity.Property(e => e.Pdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("pdate");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)")
                .HasColumnName("period");
            entity.Property(e => e.Pintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("pintpaid");
            entity.Property(e => e.Promiseno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("promiseno");
            entity.Property(e => e.Ramount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("ramount");
            entity.Property(e => e.Rcappaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rcappaid");
            entity.Property(e => e.Rdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("rdate");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'")
                .HasColumnName("receiptno");
            entity.Property(e => e.Rintpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("rintpaid");
            entity.Property(e => e.Srvpaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("srvpaid");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("tdate");
        });

        modelBuilder.Entity<ZzRepCe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_ce")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepCf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cf")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepCg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cg")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepCh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_ch")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepCi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_ci")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepCk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_ck")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepCl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cl")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        modelBuilder.Entity<ZzRepCm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cm")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasDefaultValueSql("'-'")
                .HasColumnName("address");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanMinus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllLoanPlus).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.CashPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Charge1Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Charge2Amt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ClientBranch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Closefee)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.CurrentPeriod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)");
            entity.Property(e => e.CusName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("ID");
            entity.Property(e => e.Intplus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.MaxPeriod).HasColumnType("int(5)");
            entity.Property(e => e.MinPeriod).HasColumnType("int(5)");
            entity.Property(e => e.Netamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.OtherPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("product");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.ReceiptDesc)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.ResultAmount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
            entity.Property(e => e.TdateCal)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCal");
            entity.Property(e => e.TdateCalFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateCalFormat");
            entity.Property(e => e.TdateFormat)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDateFormat");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("telephone");
            entity.Property(e => e.TransferPaid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
        });

        modelBuilder.Entity<ZzRepCn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cn")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepCo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_co")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepCp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cp")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Cap)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ChargeAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DayPaid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DownAmount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.FirstDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Insur)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Insurance1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Insurance2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.IntRate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Pamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("PAmount");
            entity.Property(e => e.Pdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PDate");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Serv)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
        });

        modelBuilder.Entity<ZzRepCq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_cq")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Cap)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.ChargeAmt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
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
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DayPaid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.DownAmount)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.FirstDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Insur)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Insurance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Insurance1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Insurance2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.IntRate)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("double(10,2)");
            entity.Property(e => e.Interest)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Pamount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)")
                .HasColumnName("PAmount");
            entity.Property(e => e.Pdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PDate");
            entity.Property(e => e.Period)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(10)");
            entity.Property(e => e.Periods)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(5)");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Serv)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.TaxPromise)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)");
            entity.Property(e => e.Tdate)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'")
                .HasColumnName("TDate");
        });

        modelBuilder.Entity<ZzRepPa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_pa")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepPb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_pb")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

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

        modelBuilder.Entity<ZzRepPc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz_rep_pc")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.AllAmount).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCap).HasColumnType("double(17,0)");
            entity.Property(e => e.AllCapPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInsPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllInt).HasColumnType("double(17,0)");
            entity.Property(e => e.AllIntPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.AllSrvPaid).HasColumnType("double(17,0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Customer)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("'0'")
                .HasColumnType("double(10,0)");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Period).HasColumnType("bigint(21)");
            entity.Property(e => e.Pname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'")
                .HasColumnName("PName");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.PromiseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Ptype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(1)")
                .HasColumnName("PType");
            entity.Property(e => e.RefCode)
                .HasMaxLength(25)
                .HasDefaultValueSql("'-'");
            entity.Property(e => e.Telephone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'-'");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
