using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WinFormsApp1.Models.Entity;

namespace WinFormsApp1.DataAccess;

public partial class CoffeemanagerContext : DbContext
{
    public CoffeemanagerContext()
    {
    }

    public CoffeemanagerContext(DbContextOptions<CoffeemanagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<BillInfo> BillInfos { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<FoodCategory> FoodCategories { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<TableFood> TableFoods { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        var configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("ConnectionString"));
    }  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bill__3213E83F80FF263E");

            entity.ToTable("Bill");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCheckIn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateCheckOut).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            entity.Property(e => e.IdTableFood).HasColumnName("idTableFood");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((0))")
                .HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.Bills)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__Bill__employeeId__4E88ABD4");

            entity.HasOne(d => d.IdTableFoodNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.IdTableFood)
                .HasConstraintName("FK__Bill__idTableFoo__4F7CD00D");
        });

        modelBuilder.Entity<BillInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BillInfo__3213E83F4B0A5F8F");

            entity.ToTable("BillInfo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdBill).HasColumnName("idBill");
            entity.Property(e => e.IdFood).HasColumnName("idFood");

            entity.HasOne(d => d.IdBillNavigation).WithMany(p => p.BillInfos)
                .HasForeignKey(d => d.IdBill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BillInfo__idBill__5165187F");

            entity.HasOne(d => d.IdFoodNavigation).WithMany(p => p.BillInfos)
                .HasForeignKey(d => d.IdFood)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BillInfo__idFood__52593CB8");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83FE7C72AF9");

            entity.HasIndex(e => e.Email, "UQ_Employees_Email").IsUnique();

            entity.HasIndex(e => e.UserName, "UQ_Employees_Username").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateStartWork)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dateStartWork");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("firstName");
            entity.Property(e => e.JobId).HasColumnName("jobId");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .HasColumnName("lastName");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("phoneNumber");
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .HasColumnName("userName");

            entity.HasOne(d => d.Job).WithMany(p => p.Employees)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__Employees__jobId__5535A963");
        });

        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Food__3213E83F076E2246");

            entity.ToTable("Food");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCateGory).HasColumnName("idCateGory");
            entity.Property(e => e.Images)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("images");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.IdCateGoryNavigation).WithMany(p => p.Foods)
                .HasForeignKey(d => d.IdCateGory)
                .HasConstraintName("FK__Food__idCateGory__571DF1D5");
        });

        modelBuilder.Entity<FoodCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FoodCate__3213E83FBCBDDC3F");

            entity.ToTable("FoodCategory");

            entity.HasIndex(e => e.Name, "UQ_FoodCategory_Name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Job__3213E83FE43F76AC");

            entity.ToTable("Job");

            entity.HasIndex(e => e.Name, "UQ_Job_Name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Salary)
                .HasDefaultValueSql("((0))")
                .HasColumnName("salary");
        });

        modelBuilder.Entity<TableFood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TableFoo__3213E83F3C918BAD");

            entity.ToTable("TableFood");

            entity.HasIndex(e => e.Name, "UQ_TableFood_Name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((0))")
                .HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
