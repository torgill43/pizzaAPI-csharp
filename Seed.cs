using pizzaAPI_csharp.Data;
using pizzaAPI_csharp.Models;
using System.Collections.Generic;

namespace pizzaAPI_csharp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Order.Any())
            {
                List<Order> orders = new List<Order>()
                {
                    new Order()
                    {
                        CustomerName = "Sydney",
                        Topping1 = "pepperoni",
                        Topping2 = "sausage"
                    },
                    new Order()
                    {
                        CustomerName = "Tim",
                        Topping1 = "pepperoni",
                        Topping2 = "pineapple"
                    },
                    new Order()
                    {
                        CustomerName = "Lance",
                        Topping1 = "mushrooms",
                        Topping2 = "onions"
                    }
                };
                dataContext.Order.AddRange(orders);
                dataContext.SaveChanges();
            }
        }



    }
}
