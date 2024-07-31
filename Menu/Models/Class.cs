namespace Menu.Models
{
    public class ItemVariantDetailRel
    {

        public int ItemVariantDetailRel_Id { get; set; }
        public int Item_Id { get; set; }
        public int VariantDetailId { get; set; }
        public int VariantPrice { get; set; }
        public string VariantNote { get; set; }

        public virtual Item Item { get; set; }
        public virtual VariantDetail VariantDetail { get; set; }
    }

}
