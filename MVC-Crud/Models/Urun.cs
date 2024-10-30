namespace MVC_Crud.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public virtual ICollection<Siparis> Siparisler { get; set; }
    }
}
