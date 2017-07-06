namespace PredictUpOrDown
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockQuote")]
    public partial class StockQuote
    {
        [Key]
        public int QuoteID { get; set; }

        [Required]
        [StringLength(20)]
        public string Symbol { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime QuoteDate { get; set; }

        [Column(TypeName = "money")]
        public decimal OpenValue { get; set; }

        [Column(TypeName = "money")]
        public decimal CloseValue { get; set; }

        [Column(TypeName = "money")]
        public decimal HighValue { get; set; }

        [Column(TypeName = "money")]
        public decimal LowValue { get; set; }

        public long Volume { get; set; }

        public short TimeFrame { get; set; }

        [Column(TypeName = "money")]
        public decimal? MAD50 { get; set; }

        [Column(TypeName = "money")]
        public decimal? MAD200 { get; set; }
    }
}
