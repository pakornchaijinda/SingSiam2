using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutoGenReports.Models
{
    public partial class singsiamdbContext : DbContext
    {
        public singsiamdbContext()
        {
        }

        public singsiamdbContext(DbContextOptions<singsiamdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlackList> BlackLists { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<CashLog> CashLogs { get; set; } = null!;
        public virtual DbSet<Collateral> Collaterals { get; set; } = null!;
        public virtual DbSet<Config> Configs { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<EventLog> EventLogs { get; set; } = null!;
        public virtual DbSet<Externalar> Externalars { get; set; } = null!;
        public virtual DbSet<Guarantor> Guarantors { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<Periodtran> Periodtrans { get; set; } = null!;
        public virtual DbSet<ProductRefcode> ProductRefcodes { get; set; } = null!;
        public virtual DbSet<Promise> Promises { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<Receiptdesc> Receiptdescs { get; set; } = null!;
        public virtual DbSet<ReceiptdescCancle> ReceiptdescCancles { get; set; } = null!;
        public virtual DbSet<Receipttran> Receipttrans { get; set; } = null!;
        public virtual DbSet<ReceipttranCancle> ReceipttranCancles { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RunningNo> RunningNos { get; set; } = null!;
        public virtual DbSet<SubjectCost> SubjectCosts { get; set; } = null!;
        public virtual DbSet<TransactionHistory> TransactionHistories { get; set; } = null!;
        public virtual DbSet<TransectionSlip> TransectionSlips { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=103.91.204.106;Database=singsiamdb;user id=sqlserver;password=singsiamP@ssw0rd;Trusted_Connection=false;MultipleActiveResultSets=true;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlackList>(entity =>
            {
                entity.HasKey(e => e.BlackId);

                entity.ToTable("black_list");

                entity.Property(e => e.BlackId).HasColumnName("black_id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Detial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("detial");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BlackLists)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_black_list_customer");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("branch");

                entity.HasIndex(e => e.BranchCode, "IX_branch")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accdocno)
                    .HasColumnName("accdocno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .HasColumnName("address");

                entity.Property(e => e.Arpaidno).HasColumnName("arpaidno");

                entity.Property(e => e.BlankType)
                    .HasMaxLength(50)
                    .HasColumnName("blank_type");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .HasColumnName("branch_code");

                entity.Property(e => e.BranchMap)
                    .HasMaxLength(250)
                    .HasColumnName("branch_map");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .HasColumnName("branch_name");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_at");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.NoBlank)
                    .HasMaxLength(50)
                    .HasColumnName("no_blank");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasColumnName("phone");

                entity.Property(e => e.Promiseno).HasColumnName("promiseno");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .HasColumnName("province");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.Receipt).HasColumnName("receipt");

                entity.Property(e => e.Refcode).HasColumnName("refcode");

                entity.HasOne(d => d.ProvinceNavigation)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_branch_province");
            });

            modelBuilder.Entity<CashLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("Cash_Log");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_create");

                entity.Property(e => e.Log1).HasColumnName("log_1");

                entity.Property(e => e.Log10).HasColumnName("log_10");

                entity.Property(e => e.Log100).HasColumnName("log_100");

                entity.Property(e => e.Log1000).HasColumnName("log_1000");

                entity.Property(e => e.Log2).HasColumnName("log_2");

                entity.Property(e => e.Log20).HasColumnName("log_20");

                entity.Property(e => e.Log5).HasColumnName("log_5");

                entity.Property(e => e.Log50).HasColumnName("log_50");

                entity.Property(e => e.Log500).HasColumnName("log_500");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CashLogs)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cash_Log_branch");
            });

            modelBuilder.Entity<Collateral>(entity =>
            {
                entity.ToTable("Collateral");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cancelfee)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cancelfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Financemax)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("financemax")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Financerate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("financerate")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Loanmax)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("loanmax")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Loanrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("loanrate")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Refcode)
                    .HasMaxLength(5)
                    .HasColumnName("refcode")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Config>(entity =>
            {
                entity.ToTable("config");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddonMemo)
                    .HasColumnName("addon_memo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Arbranch)
                    .HasColumnName("arbranch")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Askamt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("askamt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Askpc)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("askpc")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Asktime)
                    .HasColumnName("asktime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Closeedit)
                    .HasColumnName("closeedit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cutflat)
                    .HasColumnName("cutflat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DataMore)
                    .HasColumnName("data_more")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Daylate)
                    .HasColumnName("daylate")
                    .HasDefaultValueSql("((7))");

                entity.Property(e => e.Disablemanual)
                    .HasColumnName("disablemanual")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Editfee)
                    .HasColumnName("editfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Externalar)
                    .HasColumnName("externalar")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Followamt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("followamt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Followpc)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("followpc")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Followtime)
                    .HasColumnName("followtime")
                    .HasDefaultValueSql("((0))");

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
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("hurryamt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hurrypc)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("hurrypc")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Hurrytime)
                    .HasColumnName("hurrytime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Latecap)
                    .HasColumnName("latecap")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Loancontrol)
                    .HasColumnName("loancontrol")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Loancreate)
                    .HasColumnName("loancreate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Loanservins)
                    .HasColumnName("loanservins")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Localtaxrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("localtaxrate")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Maxins)
                    .HasColumnName("maxins")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Orgaddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("orgaddress")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Orgname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("orgname")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Orgtelfax)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("orgtelfax")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Paymethod)
                    .HasColumnName("paymethod")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Servicecharge)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("servicecharge")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Signname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("signname")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Specialtaxrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("specialtaxrate")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Taxid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("taxid")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Taxrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("taxrate")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Wwwpath)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wwwpath");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Bdate)
                    .HasColumnType("date")
                    .HasColumnName("bdate");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CardCreate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("card_create");

                entity.Property(e => e.CardExprite)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("card_exprite");

                entity.Property(e => e.CusImg)
                    .IsUnicode(false)
                    .HasColumnName("cus_img");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("full_name");

                entity.Property(e => e.Job)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("job");

                entity.Property(e => e.JobAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("job_address");

                entity.Property(e => e.LocationLink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("location_link");

                entity.Property(e => e.ManPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("man_phone");

                entity.Property(e => e.ManRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("man_ref");

                entity.Property(e => e.ManRelation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("man_relation");

                entity.Property(e => e.NatId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nat_id");

                entity.Property(e => e.OrtherDebt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("orther_debt");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Religion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("religion");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customer_branch");
            });

            modelBuilder.Entity<EventLog>(entity =>
            {
                entity.HasKey(e => e.Uuid);

                entity.ToTable("event_log");

                entity.Property(e => e.Uuid)
                    .ValueGeneratedNever()
                    .HasColumnName("uuid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Opertation)
                    .HasMaxLength(10)
                    .HasColumnName("opertation")
                    .IsFixedLength();

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .HasColumnName("table_name");

                entity.Property(e => e.UpdateBy).HasColumnName("update_by");
            });

            modelBuilder.Entity<Externalar>(entity =>
            {
                entity.ToTable("Externalar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aramount)
                    .HasColumnName("aramount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Clientno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("clientno");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Docno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("docno");

                entity.Property(e => e.Flg).HasColumnName("flg");

                entity.Property(e => e.LoginId).HasColumnName("login_id");

                entity.Property(e => e.PaidComplete).HasDefaultValueSql("((0))");

                entity.Property(e => e.Paidamount)
                    .HasColumnName("paidamount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PromiseId).HasColumnName("Promise_id");

                entity.Property(e => e.Tdate)
                    .HasColumnType("datetime")
                    .HasColumnName("tdate");

                entity.Property(e => e.Tdesc)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tdesc")
                    .HasDefaultValueSql("('-')");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Externalars)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Externalar_customer");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.Externalars)
                    .HasForeignKey(d => d.LoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Externalar_login");

                entity.HasOne(d => d.Promise)
                    .WithMany(p => p.Externalars)
                    .HasForeignKey(d => d.PromiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Externalar_promise");
            });

            modelBuilder.Entity<Guarantor>(entity =>
            {
                entity.ToTable("guarantor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasColumnName("address")
                    .IsFixedLength();

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.GuarantorName)
                    .HasMaxLength(50)
                    .HasColumnName("guarantorName");

                entity.Property(e => e.GuarantorNatId)
                    .HasMaxLength(13)
                    .HasColumnName("guarantorNatId")
                    .IsFixedLength();

                entity.Property(e => e.GuarantorRelation)
                    .HasMaxLength(20)
                    .HasColumnName("guarantorRelation")
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone")
                    .IsFixedLength();

                entity.Property(e => e.PromiseId).HasColumnName("promise_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Guarantors)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_guarantor_customer");

                entity.HasOne(d => d.Promise)
                    .WithMany(p => p.Guarantors)
                    .HasForeignKey(d => d.PromiseId)
                    .HasConstraintName("FK_guarantor_promise");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("login");

                entity.HasIndex(e => e.Username, "IX_login")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.EmNickname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("em_nickname");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(50)
                    .HasColumnName("fullname");

                entity.Property(e => e.Img)
                    .IsUnicode(false)
                    .HasColumnName("img");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasColumnName("phone");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Salt)
                    .HasMaxLength(10)
                    .HasColumnName("salt");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_login_branch");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_login_role");
            });

            modelBuilder.Entity<Periodtran>(entity =>
            {
                entity.ToTable("periodtran");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Capital)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("capital")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cappaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cappaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Clientno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("clientno")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Deposit)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("deposit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Inspaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("inspaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Insurance)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("insurance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Interest)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("interest")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Intpaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intpaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ispaid)
                    .HasColumnName("ispaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Loanminus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("loanminus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Loanplus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("loanplus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Paidamount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("paidamount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Paidremain)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("paidremain")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Period)
                    .HasColumnName("period")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Periods)
                    .HasColumnName("periods")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PromiseId).HasColumnName("promise_id");

                entity.Property(e => e.Ptype)
                    .HasColumnName("ptype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Service)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("service")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Specialtaxpromise)
                    .HasColumnName("specialtaxpromise")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Srvpaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("srvpaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Taxpromise)
                    .HasColumnName("taxpromise")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdate")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Tdateformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdateformat")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Usercode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usercode")
                    .HasDefaultValueSql("('-')");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Periodtrans)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_periodtran_branch");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Periodtrans)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_periodtran_customer");

                entity.HasOne(d => d.Promise)
                    .WithMany(p => p.Periodtrans)
                    .HasForeignKey(d => d.PromiseId)
                    .HasConstraintName("FK_periodtran_promise");
            });

            modelBuilder.Entity<ProductRefcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product_refcode");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.RefcodeNvBook)
                    .HasColumnName("refcode_nv_book")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefcodeNvCar)
                    .HasColumnName("refcode_nv_car")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefcodeNvLand)
                    .HasColumnName("refcode_nv_land")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefcodeV).HasColumnName("refcode_v");

                entity.HasOne(d => d.Branch)
                    .WithMany()
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_product_refcode_branch");
            });

            modelBuilder.Entity<Promise>(entity =>
            {
                entity.ToTable("promise");

                entity.HasIndex(e => e.Promiseno, "UQ_promiseno")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Cancelno)
                    .HasColumnName("cancelno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Capital)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("capital")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Chargeamt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("chargeamt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Clientno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("clientno")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Closecase)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("closecase")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Closedocno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("closedocno")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Closeresult)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("closeresult")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Coldata1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coldata1")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Coldata2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coldata2")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Coldata3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coldata3")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Coldata4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coldata4")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Coldata5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coldata5")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Coldata6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coldata6")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Coldata7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coldata7")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Coldata8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coldata8")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Coldata9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coldata9")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Colname1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colname1")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Colname2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colname2")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Colname3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colname3")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Colname4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colname4")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Colname5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colname5")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Colname6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colname6")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Colname7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colname7")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Colname8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colname8")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Colname9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colname9")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Compromise)
                    .HasColumnName("compromise")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractType).HasColumnName("contract_type");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Dateclose)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dateclose")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Dateclosecal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dateclosecal")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Dateclosecalformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dateclosecalformat")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Datecloseformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("datecloseformat")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Datewarn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("datewarn")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Datewarnformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("datewarnformat")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Daypaid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("daypaid")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Deposit)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("deposit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Downamount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("downamount")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Firstdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("firstdate")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Guarantor).HasColumnName("guarantor");

                entity.Property(e => e.Insurance)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("insurance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Insurance1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("insurance1")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Insurance1relation)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("insurance1relation")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Insurance2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("insurance2")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Insurance2relation)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("insurance2relation")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Intrate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("intrate")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is_delete")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JsonPrddesc).HasColumnName("json_prddesc");

                entity.Property(e => e.Latepc)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("latepc")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Nampa)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("nampa")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Periods)
                    .HasColumnName("periods")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Person1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("person1")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Person2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("person2")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Person3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("person3")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Person4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("person4")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Person5)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("person5")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Prddesc)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("prddesc")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Promiseno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("promiseno")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.Ptype)
                    .HasColumnName("ptype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Refcode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("refcode")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Service)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("service")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Specialtaxpromise)
                    .HasColumnName("specialtaxpromise")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stockcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("stockcode")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Sumcharge1)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("sumcharge1")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Sumcharge2)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("sumcharge2")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Sumstatus)
                    .HasColumnName("sumstatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Taxpromise)
                    .HasColumnName("taxpromise")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdate")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Tdateformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdateformat")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Tdatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("tdatetime")
                    .HasDefaultValueSql("('1900-01-01 00:00:00')");

                entity.Property(e => e.Totaldown)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("totaldown")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_on")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UploadImg).HasColumnName("upload_img");

                entity.Property(e => e.Usercode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usercode")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Warndesc)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("warndesc")
                    .HasDefaultValueSql("('-')");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Promises)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_promise_branch");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Promises)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_promise_customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Promises)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_promise_Collateral");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Promises)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_promise_province");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("province");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProvinceName)
                    .HasMaxLength(50)
                    .HasColumnName("province_name")
                    .IsFixedLength();

                entity.Property(e => e.ProvinceShortEn)
                    .HasMaxLength(10)
                    .HasColumnName("province_short_en")
                    .IsFixedLength();

                entity.Property(e => e.ProvinceShortTh)
                    .HasMaxLength(10)
                    .HasColumnName("province_short_th")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Receiptdesc>(entity =>
            {
                entity.ToTable("receiptdesc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Cappaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cappaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Chargeamt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("chargeamt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Clientbranch)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("clientbranch")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Clientno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("clientno")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Deposit)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("deposit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Inspaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("inspaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Intpaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intpaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lateamt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("lateamt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Loanminus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("loanminus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Loanplus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("loanplus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Newint)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("newint")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oldint)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("oldint")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.Periodchg)
                    .HasColumnName("periodchg")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Perioddate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("perioddate");

                entity.Property(e => e.PeriodtranId).HasColumnName("periodtran_id");

                entity.Property(e => e.PromiseId).HasColumnName("promise_id");

                entity.Property(e => e.Receiptno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("receiptno");

                entity.Property(e => e.ReceipttranId).HasColumnName("receipttran_id");

                entity.Property(e => e.Srvpaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("srvpaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdate");

                entity.Property(e => e.Tdatecal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdatecal");

                entity.Property(e => e.Tdatecalformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdatecalformat");

                entity.Property(e => e.Tdateformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdateformat");

                entity.Property(e => e.Usercode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usercode");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Receiptdescs)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receiptdesc_branch");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Receiptdescs)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receiptdesc_customer");

                entity.HasOne(d => d.Periodtran)
                    .WithMany(p => p.Receiptdescs)
                    .HasForeignKey(d => d.PeriodtranId)
                    .HasConstraintName("FK_receiptdesc_periodtran");

                entity.HasOne(d => d.Promise)
                    .WithMany(p => p.Receiptdescs)
                    .HasForeignKey(d => d.PromiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receiptdesc_promise");

                entity.HasOne(d => d.Receipttran)
                    .WithMany(p => p.Receiptdescs)
                    .HasForeignKey(d => d.ReceipttranId)
                    .HasConstraintName("FK_receiptdesc_receipttran");
            });

            modelBuilder.Entity<ReceiptdescCancle>(entity =>
            {
                entity.ToTable("receiptdesc_cancle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Cappaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cappaid");

                entity.Property(e => e.Chargeamt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("chargeamt");

                entity.Property(e => e.Clientbranch)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("clientbranch");

                entity.Property(e => e.Clientno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("clientno");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Deposit)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("deposit");

                entity.Property(e => e.Inspaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("inspaid");

                entity.Property(e => e.Intpaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intpaid");

                entity.Property(e => e.Lateamt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("lateamt");

                entity.Property(e => e.Loanminus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("loanminus");

                entity.Property(e => e.Loanplus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("loanplus");

                entity.Property(e => e.Newint)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("newint");

                entity.Property(e => e.Oldint)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("oldint");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.Periodchg).HasColumnName("periodchg");

                entity.Property(e => e.Perioddate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("perioddate");

                entity.Property(e => e.PromiseId).HasColumnName("promise_id");

                entity.Property(e => e.Receiptno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("receiptno");

                entity.Property(e => e.Srvpaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("srvpaid");

                entity.Property(e => e.Tdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdate");

                entity.Property(e => e.Tdatecal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdatecal");

                entity.Property(e => e.Tdatecalformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdatecalformat");

                entity.Property(e => e.Tdateformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdateformat");

                entity.Property(e => e.Usercode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usercode");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ReceiptdescCancles)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receiptdesc_cancle_branch");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ReceiptdescCancles)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receiptdesc_cancle_customer");

                entity.HasOne(d => d.Promise)
                    .WithMany(p => p.ReceiptdescCancles)
                    .HasForeignKey(d => d.PromiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receiptdesc_cancle_promise");
            });

            modelBuilder.Entity<Receipttran>(entity =>
            {
                entity.ToTable("receipttran");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Arbalance)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("arbalance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Arperiod)
                    .HasColumnName("arperiod")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Arremain)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("arremain")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Cappaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cappaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Capremain)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("capremain")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cashpaid)
                    .HasColumnName("cashpaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Charge1amt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("charge1amt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Charge2amt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("charge2amt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Clientbranch)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("clientbranch")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Clientno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("clientno")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Closecase)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("closecase")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Closefee)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("closefee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Currentperiod)
                    .HasColumnName("currentperiod")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Deposit)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("deposit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("discount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Inspaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("inspaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Intdiscamt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intdiscamt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Intpaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intpaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Intplus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intplus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Intremain)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intremain")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Loanminus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("loanminus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Loanplus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("loanplus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Netamount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("netamount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Newint)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("newint")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Oldint)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("oldint")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otherpaid)
                    .HasColumnName("otherpaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidBy)
                    .HasColumnName("paid_by")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Periodchg)
                    .HasColumnName("periodchg")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Periodremain)
                    .HasColumnName("periodremain")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PromiseId).HasColumnName("promise_id");

                entity.Property(e => e.Ptype)
                    .HasColumnName("ptype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Receiptdesc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("receiptdesc")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Receiptno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("receiptno")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.RemainingPrincipal)
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Resultamount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("resultamount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Specialtaxpromise)
                    .HasColumnName("specialtaxpromise")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Srvpaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("srvpaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Taxpromise)
                    .HasColumnName("taxpromise")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdate")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Tdatecal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdatecal")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Tdatecalformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdatecalformat")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Tdateformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdateformat")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Transferdate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transferdate")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Transferpaid)
                    .HasColumnName("transferpaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UploadImg).HasColumnName("upload_img");

                entity.Property(e => e.Usercode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usercode")
                    .HasDefaultValueSql("('-')");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Receipttrans)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receipttran_branch");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Receipttrans)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receipttran_customer");

                entity.HasOne(d => d.Promise)
                    .WithMany(p => p.Receipttrans)
                    .HasForeignKey(d => d.PromiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receipttran_promise");
            });

            modelBuilder.Entity<ReceipttranCancle>(entity =>
            {
                entity.ToTable("receipttran_cancle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.Arbalance)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("arbalance");

                entity.Property(e => e.Arperiod).HasColumnName("arperiod");

                entity.Property(e => e.Arremain)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("arremain");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Cappaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cappaid");

                entity.Property(e => e.Capremain)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("capremain");

                entity.Property(e => e.Cashpaid).HasColumnName("cashpaid");

                entity.Property(e => e.Charge1amt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("charge1amt");

                entity.Property(e => e.Charge2amt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("charge2amt");

                entity.Property(e => e.Clientbranch)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("clientbranch");

                entity.Property(e => e.Clientno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("clientno");

                entity.Property(e => e.Closecase)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("closecase");

                entity.Property(e => e.Closefee)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("closefee");

                entity.Property(e => e.Currentperiod).HasColumnName("currentperiod");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Deposit)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("deposit");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("discount");

                entity.Property(e => e.Inspaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("inspaid");

                entity.Property(e => e.Intdiscamt)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intdiscamt");

                entity.Property(e => e.Intpaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intpaid");

                entity.Property(e => e.Intplus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intplus");

                entity.Property(e => e.Intremain)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("intremain");

                entity.Property(e => e.Loanminus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("loanminus");

                entity.Property(e => e.Loanplus)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("loanplus");

                entity.Property(e => e.Netamount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("netamount");

                entity.Property(e => e.Newint)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("newint");

                entity.Property(e => e.Oldint)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("oldint");

                entity.Property(e => e.Otherpaid).HasColumnName("otherpaid");

                entity.Property(e => e.Periodchg).HasColumnName("periodchg");

                entity.Property(e => e.Periodremain).HasColumnName("periodremain");

                entity.Property(e => e.PromiseId).HasColumnName("promise_id");

                entity.Property(e => e.Ptype).HasColumnName("ptype");

                entity.Property(e => e.Receiptdesc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("receiptdesc");

                entity.Property(e => e.Receiptno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("receiptno");

                entity.Property(e => e.Resultamount)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("resultamount");

                entity.Property(e => e.Specialtaxpromise).HasColumnName("specialtaxpromise");

                entity.Property(e => e.Srvpaid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("srvpaid");

                entity.Property(e => e.Taxpromise).HasColumnName("taxpromise");

                entity.Property(e => e.Tdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdate");

                entity.Property(e => e.Tdatecal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdatecal");

                entity.Property(e => e.Tdatecalformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdatecalformat");

                entity.Property(e => e.Tdateformat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tdateformat");

                entity.Property(e => e.Transferdate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transferdate");

                entity.Property(e => e.Transferpaid).HasColumnName("transferpaid");

                entity.Property(e => e.Usercode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usercode");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ReceipttranCancles)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receipttran_cancle_branch");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ReceipttranCancles)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receipttran_cancle_customer");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("reports");

                entity.Property(e => e.ReportId).HasColumnName("report_id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JsonData).HasColumnName("Json_data");

                entity.Property(e => e.ReportType).HasColumnName("report_type");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<RunningNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("running_no");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CurrentNo)
                    .HasMaxLength(50)
                    .HasColumnName("current_no");

                entity.Property(e => e.NextNo)
                    .HasMaxLength(50)
                    .HasColumnName("next_no");

                entity.Property(e => e.Type)
                    .HasMaxLength(250)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SubjectCost>(entity =>
            {
                entity.HasKey(e => e.SubjectId);

                entity.ToTable("Subject_cost");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_id");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_at");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.SubjectCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Subject_code");

                entity.Property(e => e.SubjectDeital)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Subject_deital");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Subject_name");

                entity.Property(e => e.SubjectType).HasColumnName("Subject_type");
            });

            modelBuilder.Entity<TransactionHistory>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Transaction_history");

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_id");

                entity.Property(e => e.BranchId).HasColumnName("Branch_id");

                entity.Property(e => e.ConfirmTransection)
                    .HasColumnName("confirm_transection")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_at");

                entity.Property(e => e.Detial)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId).HasColumnName("login_id");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("Payment_Method")
                    .HasComment("เงินสด 1 เงินโอน 2");

                entity.Property(e => e.ReceiopttranId).HasColumnName("receiopttran_id");

                entity.Property(e => e.Receiptname)
                    .HasMaxLength(50)
                    .HasColumnName("receiptname")
                    .IsFixedLength();

                entity.Property(e => e.SlipUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Slip_url");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_id");

                entity.Property(e => e.TransectionIdRef).HasColumnName("transection_id_ref");

                entity.Property(e => e.TransectionRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Transection_ref");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TransactionHistories)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_history_branch");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.TransactionHistories)
                    .HasForeignKey(d => d.LoginId)
                    .HasConstraintName("FK_Transaction_history_login");

                entity.HasOne(d => d.Receiopttran)
                    .WithMany(p => p.TransactionHistories)
                    .HasForeignKey(d => d.ReceiopttranId)
                    .HasConstraintName("FK_Transaction_history_receipttran");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TransactionHistories)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_history_Subject_cost");
            });

            modelBuilder.Entity<TransectionSlip>(entity =>
            {
                entity.HasKey(e => e.TransactionSlipId);

                entity.ToTable("Transection_slip");

                entity.Property(e => e.TransactionSlipId).HasColumnName("Transaction_slip_id");

                entity.Property(e => e.Doc)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.PromiseId).HasColumnName("promise_id");

                entity.Property(e => e.TransactionHistoryId).HasColumnName("Transaction_history_id");

                entity.HasOne(d => d.Promise)
                    .WithMany(p => p.TransectionSlips)
                    .HasForeignKey(d => d.PromiseId)
                    .HasConstraintName("FK_Transection_slip_promise");

                entity.HasOne(d => d.TransactionHistory)
                    .WithMany(p => p.TransectionSlips)
                    .HasForeignKey(d => d.TransactionHistoryId)
                    .HasConstraintName("FK_Transection_slip_Transaction_history");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
