using Business.Models;
using Business.Models.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcWebUI.Models
{
    public class UrunlerIndexViewModel
    {
        public List<UrunModel> Urunler { get; set; }
        public UrunFilterModel Filtre { get; set; }
        public SelectList Kategoriler { get; set; }
        public MultiSelectList Magazalar { get; set; }
        public int SayfaNo { get; set; } = 1;
        public SelectList Sayfalar { get; set; }
        public int ToplamKayitSayisi { get; set; }
    }
}
