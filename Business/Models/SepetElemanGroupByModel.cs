using System.ComponentModel;

namespace Business.Models
{
    public class SepetElemanGroupByModel
    {
        public int UrunId { get; set; }
        public int KullaniciId { get; set; }

        [DisplayName("Ürün Adı")]
        public string UrunAdi { get; set; }

        [DisplayName("Toplam Birim Fiyat")]
        public string ToplamBirimFiyatiDisplay { get; set; }
        public double ToplamBirimFiyati{ get; set; }

        [DisplayName("Ürün Sayısı")]
        public int UrunSayisi { get; set; }
    }
}
