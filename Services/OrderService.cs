using Microsoft.EntityFrameworkCore;
using Models;
using Models.DataBaseModels;
using Services.DataBase;
using Services.Interface;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly PostgreSql _postgreSql;
        public OrderService(PostgreSql postgreSql)
        {
            _postgreSql = postgreSql;
        }

        public async Task<CreateOrder> CreateOrder(CreateOrder createOrder, int userId)
        {
            using (var transaction = _postgreSql.Database.BeginTransaction())
            {

                try
                {
                    createOrder.Order.UserId = userId;
                    createOrder.Order.Date = DateTime.UtcNow;
                    var order = await _postgreSql.Order.AddAsync(createOrder.Order);
                    await _postgreSql.SaveChangesAsync();
                    foreach (var item in createOrder.Items)
                    {
                        item.OrderId = order.Entity.Id;

                        await _postgreSql.OrderItems.AddAsync(item);
                    }
                    await _postgreSql.SaveChangesAsync();
                    transaction.Commit();
                    return createOrder;

                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return new CreateOrder { };
                }
                finally { transaction.Dispose(); }
            }

        }
        public async Task<List<Orders>> GetAllOrdersWithDetailOfUserAsync(int userId)
        {
            var orders = await _postgreSql.Order
        .Where(o => o.UserId == userId)
        .Join(_postgreSql.OrderItems,
            order => order.Id,
            orderItem => orderItem.OrderId,
            (order, orderItem) => new { Order = order, Items = orderItem })
        .ToListAsync();
            var result = orders.GroupBy(o => o.Order)
            .Select(g => new Orders
            {
                Order = g.Key,
                OrderItemsDetailed =
                    g.Select(oi => new OrderItemsDetailed { OrderItem = oi.Items, Menu = _postgreSql.Menu.First(m => m.Id == oi.Items.MenuId) }).ToList()

            }).ToList();
            return result;
        }
        public async Task<List<Order>> GetAllOrdersOfUserAsync(int userId)
        {
            var orders = await _postgreSql.Order
        .Where(o => o.UserId == userId).ToListAsync();
            return orders;
        }
        public async Task<Orders> GetSpecificOrderUserAsync(int userId, int orderId)
        {
            var orders = await _postgreSql.Order
        .Where(o => o.UserId == userId && o.Id == orderId)
        .Join(_postgreSql.OrderItems,
            order => order.Id,
            orderItem => orderItem.OrderId,
            (order, orderItem) => new { Order = order, Items = orderItem })
        .ToListAsync();
            var result = orders.GroupBy(o => o.Order)
            .Select(g => new Orders
            {
                Order = g.Key,
                OrderItemsDetailed =
                    g.Select(oi => new OrderItemsDetailed { OrderItem = oi.Items, Menu = _postgreSql.Menu.First(m => m.Id == oi.Items.MenuId) }).ToList()

            }).FirstOrDefault();

            return result;
        }
        public async Task DeleteOrderByIdAsync(int userId, int orderId,string role)
        {
            Order? order = null;
            if (role != "user")
            {
                order = await _postgreSql.Order
                               .FirstOrDefaultAsync(o=>o.Id == orderId);
            }
            else
            {
                order = await _postgreSql.Order
                .FirstOrDefaultAsync(o => o.UserId == userId && o.Id == orderId);
            }
            if(order!=null)
            {
                _postgreSql.Order.Remove(order);
                await _postgreSql.SaveChangesAsync();
            }

        }
    }
}
