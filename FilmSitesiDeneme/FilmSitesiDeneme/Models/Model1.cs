namespace FilmSitesiDeneme.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Avengers2Yorum> Avengers2Yorum { get; set; }
        public virtual DbSet<Avengers3Yorum> Avengers3Yorum { get; set; }
        public virtual DbSet<Avengers4Yorum> Avengers4Yorum { get; set; }
        public virtual DbSet<AvengersYorum> AvengersYorum { get; set; }
        public virtual DbSet<BumblebeeYorum> BumblebeeYorum { get; set; }
        public virtual DbSet<Diziler> Diziler { get; set; }
        public virtual DbSet<Fast1Yorum> Fast1Yorum { get; set; }
        public virtual DbSet<Fast2Yorum> Fast2Yorum { get; set; }
        public virtual DbSet<Fast3Yorum> Fast3Yorum { get; set; }
        public virtual DbSet<Fast4Yorum> Fast4Yorum { get; set; }
        public virtual DbSet<Fast5Yorum> Fast5Yorum { get; set; }
        public virtual DbSet<Fast6Yorum> Fast6Yorum { get; set; }
        public virtual DbSet<Fast7Yorum> Fast7Yorum { get; set; }
        public virtual DbSet<Fast8Yorum> Fast8Yorum { get; set; }
        public virtual DbSet<Fast9Yorum> Fast9Yorum { get; set; }
        public virtual DbSet<FastShawYorum> FastShawYorum { get; set; }
        public virtual DbSet<Filmler> Filmler { get; set; }
        public virtual DbSet<Mesaj> Mesaj { get; set; }
        public virtual DbSet<Yönetici> Yönetici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avengers2Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Avengers2Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Avengers2Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Avengers3Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Avengers3Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Avengers3Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Avengers4Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Avengers4Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Avengers4Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<AvengersYorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<AvengersYorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<AvengersYorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<BumblebeeYorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<BumblebeeYorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<BumblebeeYorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Diziler>()
                .Property(e => e.Dizi_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Diziler>()
                .Property(e => e.Dizi_Tür)
                .IsUnicode(false);

            modelBuilder.Entity<Diziler>()
                .Property(e => e.Dizi_Resim)
                .IsUnicode(false);

            modelBuilder.Entity<Diziler>()
                .Property(e => e.Dizi_Dil)
                .IsUnicode(false);

            modelBuilder.Entity<Diziler>()
                .Property(e => e.Dizi_Kurdele)
                .IsUnicode(false);

            modelBuilder.Entity<Diziler>()
                .Property(e => e.Dizi_Referans)
                .IsUnicode(false);

            modelBuilder.Entity<Diziler>()
                .Property(e => e.Dizi_Puan)
                .IsUnicode(false);

            modelBuilder.Entity<Fast1Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Fast1Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Fast1Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Fast2Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Fast2Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Fast2Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Fast3Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Fast3Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Fast3Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Fast4Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Fast4Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Fast4Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Fast5Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Fast5Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Fast5Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Fast6Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Fast6Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Fast6Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Fast7Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Fast7Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Fast7Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Fast8Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Fast8Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Fast8Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Fast9Yorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Fast9Yorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Fast9Yorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<FastShawYorum>()
                .Property(e => e.Yorum_AD)
                .IsUnicode(false);

            modelBuilder.Entity<FastShawYorum>()
                .Property(e => e.Yorum_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<FastShawYorum>()
                .Property(e => e.Yorum_YORUM)
                .IsUnicode(false);

            modelBuilder.Entity<Filmler>()
                .Property(e => e.Film_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Filmler>()
                .Property(e => e.Film_Puan)
                .IsUnicode(false);

            modelBuilder.Entity<Filmler>()
                .Property(e => e.Film_Dil)
                .IsUnicode(false);

            modelBuilder.Entity<Filmler>()
                .Property(e => e.Film_Kurdele)
                .IsUnicode(false);

            modelBuilder.Entity<Filmler>()
                .Property(e => e.Film_Resim)
                .IsUnicode(false);

            modelBuilder.Entity<Filmler>()
                .Property(e => e.Film_Referans)
                .IsUnicode(false);

            modelBuilder.Entity<Filmler>()
                .Property(e => e.Film_Tür)
                .IsUnicode(false);

            modelBuilder.Entity<Mesaj>()
                .Property(e => e.Mesaj_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Mesaj>()
                .Property(e => e.Mesaj_Mesaj)
                .IsUnicode(false);

            modelBuilder.Entity<Mesaj>()
                .Property(e => e.Mesaj_Soyad)
                .IsUnicode(false);

            modelBuilder.Entity<Mesaj>()
                .Property(e => e.Mesaj_Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Yönetici>()
                .Property(e => e.Yönetici_AD)
                .IsUnicode(false);

            modelBuilder.Entity<Yönetici>()
                .Property(e => e.Yönetici_ŞİFRE)
                .IsUnicode(false);
        }
    }
}
