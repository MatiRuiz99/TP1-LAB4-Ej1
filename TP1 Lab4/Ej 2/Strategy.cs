using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Lab4.Ej_2
{
    interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal amount);
    }

    class NoDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount) => amount;
    }

    class TenPercentDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount) => amount * 0.9m;
    }

    class TwentyPercentDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount) => amount * 0.8m;
    }

    class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void Checkout(decimal totalAmount)
        {
            decimal discountedAmount = _discountStrategy.ApplyDiscount(totalAmount);
            Console.WriteLine($"Total amount after discount: {discountedAmount:C}");
        }
    }

}
