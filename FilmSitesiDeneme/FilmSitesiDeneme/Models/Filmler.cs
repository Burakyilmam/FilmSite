namespace FilmSitesiDeneme.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Filmler")]
    public partial class Filmler
    {
        [Key]
        public int Film_ID { get; set; }

        [StringLength(300)]
        public string Film_AD { get; set; }

        [StringLength(300)]
        public string Film_Puan { get; set; }

        [StringLength(300)]
        public string Film_Dil { get; set; }

        [StringLength(300)]
        public string Film_Kurdele { get; set; }

        [StringLength(300)]
        public string Film_Resim { get; set; }

        public string Film_Referans { get; set; }

        [StringLength(300)]
        public string Film_Tür { get; set; }
    }
}
