namespace Menu.Models
{
    public class Menu
    {
        public class Menu
        {
            public int Menu_Id { get; set; }
            public string Name { get; set; }
            public string NameAr { get; set; }
            public int Customer_Id { get; set; }

            public virtual Customer Customer { get; set; }
            public virtual ICollection<Category> Categories { get; set; }
        }

   
}
}
