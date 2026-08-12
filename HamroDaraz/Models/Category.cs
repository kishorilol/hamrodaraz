namespace HamroDaraz.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
