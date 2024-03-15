namespace CoreMVCCodeFirst_1.Models.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Props

        public virtual List<Product> Products { get; set; }

    }
}
