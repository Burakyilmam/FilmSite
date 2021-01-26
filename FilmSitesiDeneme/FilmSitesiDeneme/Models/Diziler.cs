namespace FilmSitesiDeneme.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diziler")]
    public partial class Diziler
    {
        [Key]
        public int Dizi_ID { get; set; }

        [StringLength(300)]
        public string Dizi_AD { get; set; }

        [StringLength(300)]
        public string Dizi_Tür { get; set; }

        [StringLength(300)]
        public string Dizi_Resim { get; set; }

        [StringLength(300)]
        public string Dizi_Dil { get; set; }

        [StringLength(300)]
        public string Dizi_Kurdele { get; set; }

        public string Dizi_Referans { get; set; }

        [StringLength(300)]
        public string Dizi_Puan { get; set; }
    }
}
