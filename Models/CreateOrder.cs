using Models.DataBaseModels;

namespace Models
{
    public class CreateOrder
    {
        public Order Order { get; set; }
        public IList<OrderItems> Items { get; set; }
    }
}
