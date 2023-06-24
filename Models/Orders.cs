using Models.DataBaseModels;

namespace Models
{
    public class Orders
    {
        public Order Order { get; set; }

        public IList<OrderItemsDetailed> OrderItemsDetailed { get; set; }

    }
    public class OrderItemsDetailed
    {
        public OrderItems OrderItem { get; set; }
        public Menu Menu { get; set; }
    }

}
