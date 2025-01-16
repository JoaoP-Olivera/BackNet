namespace BackNet.Data
{
    public class Category
    {
        public long categoryId { get; set; }
        public string name {  get; set; }
        public IEnumerable<Product>? products { get; set; }
    }
}
