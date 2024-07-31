namespace Menu.Models
{
    public class VariantHeader
    {
        public int VariantHeader_Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }

        public virtual ICollection<VariantDetail> VariantDetails { get; set; }
    }

}
