using Models;
using Models.DataBaseModels;

namespace Services.Interface
{
    public interface IOrderService
    {
        Task<CreateOrder> CreateOrder(CreateOrder createOrder, int userId);
        Task<List<Orders>> GetAllOrdersWithDetailOfUserAsync(int userId);
        Task<List<Order>> GetAllOrdersOfUserAsync(int userId);
        Task<Orders> GetSpecificOrderUserAsync(int userId, int orderId);
        Task DeleteOrderByIdAsync(int userId, int orderId,string role);
    }
}
