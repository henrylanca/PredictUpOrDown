namespace PredictUpOrDown
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StockQuoteContext : DbContext
    {
        public StockQuoteContext()
            : base("name=StockQuoteContext")
        {
        }

        public virtual DbSet<StockQuote> StockQuotes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockQuote>()
                .Property(e => e.Symbol)
                .IsUnicode(false);

            modelBuilder.Entity<StockQuote>()
                .Property(e => e.OpenValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StockQuote>()
                .Property(e => e.CloseValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StockQuote>()
                .Property(e => e.HighValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StockQuote>()
                .Property(e => e.LowValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StockQuote>()
                .Property(e => e.MAD50)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StockQuote>()
                .Property(e => e.MAD200)
                .HasPrecision(19, 4);
        }
    }
}
