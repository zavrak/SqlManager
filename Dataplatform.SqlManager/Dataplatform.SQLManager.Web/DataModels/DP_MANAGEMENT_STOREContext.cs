using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dataplatform.SQLManager.Web.DataModels
{
    public partial class DP_MANAGEMENT_STOREContext : DbContext
    {
        public DP_MANAGEMENT_STOREContext()
        {
        }

        public DP_MANAGEMENT_STOREContext(DbContextOptions<DP_MANAGEMENT_STOREContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<AuditCategory> AuditCategory { get; set; }
        public virtual DbSet<Script> Script { get; set; }
        public virtual DbSet<ScriptType> ScriptType { get; set; }
        public virtual DbSet<SqlVersion> SqlVersion { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=DP_MANAGEMENT_STORE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Audit>(entity =>
            {
                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditCategory>(entity =>
            {
                entity.Property(e => e.AuditCategoryText)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Script>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ScriptText).IsRequired();

                entity.Property(e => e.SqlVersion).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScriptType>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ScriptTypeUuid).HasColumnName("ScriptTypeUUID");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SqlVersion>(entity =>
            {
                entity.Property(e => e.SqlVersionText)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
