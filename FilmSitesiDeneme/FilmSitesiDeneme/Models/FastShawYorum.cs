namespace FilmSitesiDeneme.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FastShawYorum")]
    public partial class FastShawYorum
    {
        [Key]
        public int Yorum_ID { get; set; }

        [StringLength(100)]
        public string Yorum_AD { get; set; }

        [StringLength(400)]
        public string Yorum_MAIL { get; set; }

        public string Yorum_YORUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Yorum_TARIH { get; set; }
    }
}