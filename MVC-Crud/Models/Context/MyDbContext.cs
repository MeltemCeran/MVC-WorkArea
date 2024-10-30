using Microsoft.EntityFrameworkCore;

namespace MVC_Crud.Models.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musteri>().HasData(new[]
            {
      new Musteri { MusteriId = 1, Ad = "Ali", Soyad = "Yılmaz", Email = "ali.yilmaz@example.com" },
      new Musteri { MusteriId = 2, Ad = "Ayşe", Soyad = "Kara", Email = "ayse.kara@example.com" },
      new Musteri { MusteriId = 3, Ad = "Mehmet", Soyad = "Demir", Email = "mehmet.demir@example.com" },
      new Musteri { MusteriId = 4, Ad = "Fatma", Soyad = "Öztürk", Email = "fatma.ozturk@example.com" },
      new Musteri { MusteriId = 5, Ad = "Hasan", Soyad = "Çelik", Email = "hasan.celik@example.com" },
      new Musteri { MusteriId = 6, Ad = "Zeynep", Soyad = "Koç", Email = "zeynep.koc@example.com" },
      new Musteri { MusteriId = 7, Ad = "Emre", Soyad = "Aydın", Email = "emre.aydin@example.com" },
      new Musteri { MusteriId = 8, Ad = "Seda", Soyad = "Akman", Email = "seda.akman@example.com" },
      new Musteri { MusteriId = 9, Ad = "Burak", Soyad = "Sönmez", Email = "burak.sonmez@example.com" },
      new Musteri { MusteriId = 10, Ad = "Elif", Soyad = "Yavuz", Email = "elif.yavuz@example.com" }
  });

            modelBuilder.Entity<Urun>().HasData(new[]
            {
      new Urun { UrunId = 1, Adi = "Laptop", Fiyat = 2500 },
      new Urun { UrunId = 2, Adi = "Akıllı Telefon", Fiyat = 1500 },
      new Urun { UrunId = 3, Adi = "Tablet", Fiyat = 1200 },
      new Urun { UrunId = 4, Adi = "Kulaklık", Fiyat = 300 },
      new Urun { UrunId = 5, Adi = "Masaüstü Bilgisayar", Fiyat = 2000 },
      new Urun { UrunId = 6, Adi = "Monitör", Fiyat = 800 },
      new Urun { UrunId = 7, Adi = "Klavyeli", Fiyat = 400 },
      new Urun { UrunId = 8, Adi = "Yazıcı", Fiyat = 600 },
      new Urun { UrunId = 9, Adi = "Modem", Fiyat = 250 },
      new Urun { UrunId = 10, Adi = "Harici Disk", Fiyat = 500 }
  });

            modelBuilder.Entity<Siparis>().HasData(new[]
            {
      new Siparis { SiparisId = 1, MusteriId = 1, UrunId = 1, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 2, MusteriId = 1, UrunId = 2, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 3, MusteriId = 2, UrunId = 3, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 4, MusteriId = 2, UrunId = 4, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 5, MusteriId = 3, UrunId = 5, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 6, MusteriId = 3, UrunId = 6, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 7, MusteriId = 4, UrunId = 7, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 8, MusteriId = 5, UrunId = 8, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 9, MusteriId = 6, UrunId = 9, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 10, MusteriId = 7, UrunId = 10, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 11, MusteriId = 8, UrunId = 1, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 12, MusteriId = 9, UrunId = 2, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 13, MusteriId = 10, UrunId = 3, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 14, MusteriId = 4, UrunId = 5, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 15, MusteriId = 5, UrunId = 6, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 16, MusteriId = 6, UrunId = 7, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 17, MusteriId = 7, UrunId = 8, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 18, MusteriId = 8, UrunId = 9, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 19, MusteriId = 9, UrunId = 10, SiparisTarihi = DateTime.Now },
      new Siparis { SiparisId = 20, MusteriId = 10, UrunId = 1, SiparisTarihi = DateTime.Now }
  });
        }
    }
}
