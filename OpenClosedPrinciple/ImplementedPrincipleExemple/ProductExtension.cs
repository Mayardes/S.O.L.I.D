using OpenClosedPrincipleExtensionMethod.ViolationPrincipleExemple;
using System;

namespace OpenClosedPrincipleExtensionMethod.ImplementedPrincipleExemple
{
    public static class ProductExtension
    {
        public static double ProfitMarginExtension (this Product product)
        {
            var netProfit = product.SaleValue - product.CostValue;
            var marginProfit = (netProfit / product.SaleValue) * 100;
            return Convert.ToDouble(marginProfit);
        }
    }
}
