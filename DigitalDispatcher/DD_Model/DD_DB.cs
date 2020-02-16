namespace DigitalDispatcher
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DD_DB : DbContext
    {
        public DD_DB()
            : base("name=DD_DB")
        {
        }

        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<MSG> MSG { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MSG>()
                .HasMany(e => e.History)
                .WithOptional(e => e.MSG)
                .HasForeignKey(e => e.Msg_Id);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.History)
                .WithOptional(e => e.Status)
                .HasForeignKey(e => e.Status_Id);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.MSG)
                .WithOptional(e => e.Type)
                .HasForeignKey(e => e.Msg_Type);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.User)
                .WithMany(e => e.Type)
                .Map(m => m.ToTable("Type_User").MapLeftKey("Type_Id"));

            modelBuilder.Entity<User>()
                .HasMany(e => e.History)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.User_Id);
        }
    }
}
