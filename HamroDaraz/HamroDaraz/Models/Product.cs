namespace HamroDaraz.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Descryption { get; set; }
        public int Price { get; set; }
        public string? Producticon { get; set; }
        public int CategoryID { get; set; }
        public virtual Category? Category { get; set; }
    }
}
