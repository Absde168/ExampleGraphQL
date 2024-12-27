using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleGraphQL.DAO
{

    public interface IOrderRepository
    {
        Task<Order> GetOrderByIdAsync(int id);
        Task<IEnumerable<Order>> GetOrdersByClientIdAsync(int clientId);
        Task<Order> AddOrderAsync(Order order);
        Task<Order> UpdateOrderAsync(Order order);
        Task<bool> DeleteOrderAsync(int id);
        Task<IQueryable<Order>> GetAllOrdersAsync();
        Task<IQueryable<Order>> GetOrdersEndingNextMonthAsync();
    }
}


