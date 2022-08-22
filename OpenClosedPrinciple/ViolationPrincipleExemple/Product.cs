using System;

namespace OpenClosedPrincipleExtensionMethod.ViolationPrincipleExemple
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CostValue { get; set; }
        public decimal SaleValue { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }

        public double ProfitMargin()
        {
            var netProfit = SaleValue - CostValue;
            var marginProfit = (netProfit / SaleValue) * 100;
            return Convert.ToDouble(marginProfit);
        }
    }
}
