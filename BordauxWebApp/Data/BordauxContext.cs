using BordauxLib.Entities;
using Microsoft.EntityFrameworkCore;

namespace BordauxWebApp.Data
{
    public class BordauxContext : DbContext
    {
        public DbSet<Act> Acts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventAct> EventActs { get; set; }
        public DbSet<Promotor> Promotors { get; set; }

        public BordauxContext(DbContextOptions<BordauxContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<EventAct>()
                .HasKey(ea => new { ea.EventId, ea.ActId });
            builder.Entity<EventAct>()
                .HasOne(ea => ea.Act)
                .WithMany(a => a.Events)
                .HasForeignKey(ea => ea.ActId);
            builder.Entity<EventAct>()
                .HasOne(ea => ea.Event)
                .WithMany(e => e.Acts)
                .HasForeignKey(ea => ea.EventId);

            DataSeeder.Seed(builder);
        }
    }
}
