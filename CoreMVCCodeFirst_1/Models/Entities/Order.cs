namespace CoreMVCCodeFirst_1.Models.Entities
{
    public class Order: BaseEntity
    {
        public string ShippingAddress { get; set; }

        //Relational Props

        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
