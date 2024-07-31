using System.ComponentModel.DataAnnotations.Schema;

namespace Menu.Models
{
    public class Item
    {
        public int Item_Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string Notes { get; set; }
        public bool ActiveStatus { get; set; }
        public byte[] Image { get; set; }
        public int Category_Id { get; set; }
        public string Ingredients { get; set; }
        public int TotalCalories { get; set; }
        public string NutritionalFacts { get; set; }
        public bool VariantEnabled { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<ItemVariantDetailRel> ItemVariantDetailRels { get; set; }
    }

}
