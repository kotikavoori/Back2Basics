using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternsEx
{
    class Onserver_Example
    {
         void main()
        {
            Infosys iBM = new Infosys("Infosys", 120);

            iBM.Add(new StockInvestor("Koti"));

            iBM.Add(new StockInvestor("Kot2"));

            for (int i = 0; i < 100; i++)
            {
                iBM.Price++;
                Thread.Sleep(5000);

            }
            Console.Read();
        }
    }

    class Infosys : StockItem
    {
        public Infosys(string name, double price) : base(name, price)
        {
        }
    }

    class StockItem
    {
        List<StockInvestor> list = new List<StockInvestor>();

        public string name = string.Empty;
        double price;
        public double Price { get => price; set  {  price = value; NotifyInvestor(); } }

        public void Add(StockInvestor stockInvestor )
        {
            list.Add(stockInvestor);
        }
        public void Remove(StockInvestor stockInvestor)
        {
            list.Remove(stockInvestor);
        }
        
        public void NotifyInvestor()
        {
            foreach (var item in list)
            {
                item.ReceiveUpdate(this);
            }
        }

        public StockItem(string name, double price )
        {
            this.name = name;
            this.price = price;
        }

    }

    internal class StockInvestor : IStockUpdates
    {

        string name;
        public StockInvestor(string name)
        {
            this.name = name;
        }

        public void ReceiveUpdate(StockItem stockItem)
        {
            Console.Write(stockItem.name +" has changed yo " + stockItem.Price.ToString() );

        }
    }
    
    interface IStockUpdates
    {
        void ReceiveUpdate(StockItem stockItem);

    }


}
