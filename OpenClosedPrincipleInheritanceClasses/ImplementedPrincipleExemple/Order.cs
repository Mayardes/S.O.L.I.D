namespace OpenClosedPrincipleInheritanceClasses.ImplementedPrincipleExemple
{
    /// <summary>
    /// Base class
    /// </summary>
    public class Order
    {
        public virtual double DiscountOrder(double value)
        {
            return value;
        }
    }

    /// <summary>
    /// Derived class
    /// </summary>
    public class DiscountCustumerAssociate : Order
    {
        public override double DiscountOrder(double value)
        {
            return value - 10;
        }
    }

    /// <summary>
    /// Derived class
    /// </summary>
    public class DiscountCustumerEspecial : Order
    {
        public override double DiscountOrder(double value)
        {
            return value - 50;
        }
    }

    /// <summary>
    /// Derived class
    /// </summary>
    public class DiscountCustumerVIP : Order
    {
        public override double DiscountOrder(double value)
        {
            return value = 100;
        }
    }
}
