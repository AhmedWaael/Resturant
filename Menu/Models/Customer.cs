namespace Menu.Models
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string Notes { get; set; }
        public string Address { get; set; }
        public string BusinessName { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
