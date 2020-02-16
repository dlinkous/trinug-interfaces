using System;
using System.Collections.Generic;

namespace Interfaces.Example1
{
    public class Invoice
    {
        private readonly List<Product> products = new List<Product>();
        private readonly List<Service> services = new List<Service>();

        public void Add(Product product) => products.Add(product);

        public void Add(Service service) => services.Add(service);

        public decimal CalculateTotal()
        {
            var total = 0m;
            foreach (var product in products)
                total += product.Calculate();
            foreach (var service in services)
                total += service.Calculate();
            return Math.Round(total, 2);
        }
    }
}
