namespace MyShop.ApplicationCore.Entities
{
    public sealed class CatalogBrand
    {
        //TODO replace GUID
        public int Id { get; set; }
        public string Brand { get; set; }

        public CatalogBrand(string brand)
        {
            Brand = brand;
        }
    }
}
