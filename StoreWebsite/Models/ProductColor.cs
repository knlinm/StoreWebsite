namespace StoreWebsite.Models
{
    public class ProductColor : Entity
    {
        public int ProductSizeId { get; set; }
        public int ColorId { get; set; }

        public virtual ProductSize ProductSize { get; set; }
        public virtual Color Color { get; set; }
    }
}
