using pizzaAPI_csharp.Models;

namespace pizzaAPI_csharp.Interfaces
{
    public interface IOrderRepository
    {
        ICollection<Order> GetOrders();
        Order GetOrder(int id);
        bool OrderExists(int id);
        bool CreateOrder(Order order);
        bool Save();
    }
}
