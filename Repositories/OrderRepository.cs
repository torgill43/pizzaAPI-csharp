using pizzaAPI_csharp.Data;
using pizzaAPI_csharp.Interfaces;
using pizzaAPI_csharp.Models;

namespace pizzaAPI_csharp.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateOrder(Order order)
        {
            _context.Add(order);

            return Save();
        }

        public Order GetOrder(int id)
        {
            return _context.Order.Where(o => o.Id == id).FirstOrDefault();
        }

        public ICollection<Order> GetOrders()
        {
            return _context.Order.ToList();
        }

        public bool OrderExists(int id)
        {
            return _context.Order.Any(o => o.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
