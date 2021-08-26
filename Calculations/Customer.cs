using System;

namespace Calculations
{
    public class Customer
    {
        public virtual int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }
        public byte Age = 35;

        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }

    public class LoyalCostumer : Customer
    {
        public int Discount { get; set; }
        public LoyalCostumer()
        {
            Discount = 10;
        }

        public override int GetOrdersByName(string name)
        {
            return 101;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount <= 100)
                return new Customer();
            else
                return new LoyalCostumer();
        }
    }
}
