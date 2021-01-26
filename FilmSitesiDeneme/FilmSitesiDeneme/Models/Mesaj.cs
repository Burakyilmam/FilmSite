namespace FilmSitesiDeneme.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mesaj")]
    public partial class Mesaj
    {
        [Key]
        public int Mesaj_ID { get; set; }

        [StringLength(300)]
        public string Mesaj_AD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Mesaj_Tarih { get; set; }

        public string Mesaj_Mesaj { get; set; }

        [StringLength(300)]
        public string Mesaj_Soyad { get; set; }

        [StringLength(300)]
        public string Mesaj_Mail { get; set; }
    }
}
