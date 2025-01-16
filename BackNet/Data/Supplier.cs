namespace BackNet.Data
{
    public class Supplier
    {
        public long supplierId {  get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public IEnumerable<Product>? products { get; set; }
    }
}
