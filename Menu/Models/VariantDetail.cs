namespace Menu.Models
{
    public class VariantDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public int Header_Id { get; set; }

        public virtual VariantHeader VariantHeader { get; set; }
        public virtual ICollection<ItemVariantDetailRel> ItemVariantDetailRels { get; set; }
    }

}
