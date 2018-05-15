using System;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    abstract class PrimeOrder : Order
    {
        public abstract void PlaceOrder(OrderType h);
    }
    abstract class RegularOrder : Order
    {
        public abstract void PlaceOrder(OrderType h);
    }

    class RegularOnlineOrder : RegularOrder
    {
        public override void PlaceOrder(OrderType type)
        {
            throw new NotImplementedException();
        }
    }
    class RegularOfflineOrder : RegularOrder
    {
        public override void PlaceOrder(OrderType type)
        {
        }
    }

    class PrimeOnlineOrder : PrimeOrder
    {
        public override void PlaceOrder(OrderType type)
        {
            throw new NotImplementedException();
        }
    }
    class PrimeOfflineOrder : PrimeOrder
    {
        public override void PlaceOrder(OrderType type)
        {
        }
    }

    class MainApp
    {
        public static void Main()
        {
            // Create and run the African animal world

            OrderFactory africa = new RegularOrderFactory();
            OrderWorld world = new OrderWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world

            OrderFactory america = new PrimeOrderFactory();
            world = new OrderWorld(america);
            world.RunFoodChain();

            // Wait for user input

            Console.ReadKey();
        }
    }


    abstract class OrderFactory
    {
        public abstract Order CreatePrimeOrder(OrderType type);
        public abstract Order CreateRegularOrder(OrderType type);
    }
    abstract class Order
    {
        PrimeOrder po;
        RegularOrder ro;
    }
    
    class RegularOrderFactory : OrderFactory
    {
        public override PrimeOrder CreatePrimeOrder(OrderType type)
        {
            throw new NotImplementedException();
        }

        public override RegularOrder CreateRegularOrder(OrderType type)
        {
            if (type == OrderType.Offline)
            {
                return new RegularOfflineOrder();
            }
            else
            {
                return new RegularOnlineOrder();
            }
        }
    }

    enum OrderType
    {
        Online=0,
        Offline=1

    }


    class PrimeOrderFactory : OrderFactory
    {
        public override PrimeOrder CreatePrimeOrder(OrderType type)
        {
            return new PrimeOnlineOrder();
            //throw new NotImplementedException();
        }

        public override RegularOrder CreateRegularOrder(OrderType type)
        {
            throw new NotImplementedException();
        }
    }



    class OrderWorld

    {
        private PrimeOrder  primeOrder;
        private RegularOrder regularOrder;

        // Constructor

        public OrderWorld(OrderFactory factory)
        {
            regularOrder = factory.CreateRegularOrder(OrderType.Offline);
            primeOrder = factory.CreatePrimeOrder(OrderType.Online);
        }

        public void RunFoodChain()
        {
          //  offlineOrder.PlaceOrder(onlineOrder);
        }
    }
}

