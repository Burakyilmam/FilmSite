namespace FilmSitesiDeneme.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Yönetici
    {
        [Key]
        public int Yönetici_ID { get; set; }

        [StringLength(300)]
        public string Yönetici_AD { get; set; }

        [StringLength(300)]
        public string Yönetici_ŞİFRE { get; set; }
    }
}
