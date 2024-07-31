namespace Menu.Models
{
    public class Category
    {
        public int Category_Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string Notes { get; set; }
        public int Menu_Id { get; set; }
        public byte[] icon { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }

}
