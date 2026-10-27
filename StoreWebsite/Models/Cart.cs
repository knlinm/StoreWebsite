namespace StoreWebsite.Models
{
    public class Cart:Entity
    {
        public int UserId { get; set; }
        public int ProductColorId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int CartStatusId { get; set; }


        public virtual User User { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual CartStatus CartStatus { get; set; }
    }
}
