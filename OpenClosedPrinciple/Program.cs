using OpenClosedPrincipleExtensionMethod.ImplementedPrincipleExemple;
using OpenClosedPrincipleExtensionMethod.ViolationPrincipleExemple;
using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                Id = 1,
                CostValue = 25.2M,
                SaleValue = 30.0M,
                Stock = 155,
                Description = "pens",
                Name = "bic",
                IsActive = true
            };
            Console.WriteLine($"{product.ProfitMarginExtension()}");
        }
    }
}
