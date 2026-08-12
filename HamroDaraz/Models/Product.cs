namespace HamroDaraz.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Production { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
