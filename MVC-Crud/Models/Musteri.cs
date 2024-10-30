namespace MVC_Crud.Models
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}
