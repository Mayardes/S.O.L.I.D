namespace OpenClosedPrincipleInheritanceClasses
{
    class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CostValue { get; set; }

        /// <summary>
        /// Violation principle OCP
        /// </summary>
        /// <param name="value"></param>
        /// <param name="custumerType"></param>
        /// <returns></returns>
        public double DiscountOrder(double value, CustumerType custumerType)
        {
            double finalValue;

            if (custumerType == CustumerType.Especial)
            {
                finalValue = value - 50;
            }
            else if (custumerType == CustumerType.Associate)
            {
                finalValue = value - 10;
            }
            else
            {
                finalValue = value;
            }

            return finalValue;
        }
    }
}
