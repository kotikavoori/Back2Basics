using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsEx.Factory
{
    class FactoryClient
    {
        IOrder newOrder = OrderFactory.CreateOrder("RegularOrder");
    }

    public static class OrderFactory
    {
        public static IOrder CreateOrder(string name)
        {
            if (name == "RegularOrder")
            {
                return new RegularOrder();
            }
            else
            {
                return new PrimeOrder();
            }
        }

    }

    public interface IOrder
    {
        void CreateOrder();
    }

    class RegularOrder : IOrder
    {
        public void CreateOrder()
        {

        }
    }

    class PrimeOrder : IOrder
    {
        public void CreateOrder()
        {

        }
    }
}
