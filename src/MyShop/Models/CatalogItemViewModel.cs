namespace MyShop.Models
{
    public sealed class CatalogItemViewModel
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
    }
}
