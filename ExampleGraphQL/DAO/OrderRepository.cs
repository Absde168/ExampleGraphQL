using ExampleGraphQL.Models;
using Microsoft.EntityFrameworkCore;
namespace ExampleGraphQL.DAO
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BlogDbContext _context;

        public OrderRepository(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _context.Orders.Include(o => o.Client).FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<IEnumerable<Order>> GetOrdersByClientIdAsync(int clientId)
        {
            return await _context.Orders.Where(o => o.ClientId == clientId).ToListAsync();
        }

        public async Task<Order> AddOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<bool> DeleteOrderAsync(int id)
        {
            var order = await GetOrderByIdAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<IQueryable<Order>> GetOrdersEndingNextMonthAsync()
        {
            var nextMonth = DateTime.Now.AddMonths(1).Month;
            var year = DateTime.Now.Year;

            return _context.Orders.Where(o => o.EndDate.HasValue && o.EndDate.Value.Month == nextMonth && o.EndDate.Value.Year == year).AsQueryable();
        }
        public async Task<IQueryable<Order>> GetAllOrdersAsync()
        {
            return _context.Orders.AsQueryable();
        }
    }
}



