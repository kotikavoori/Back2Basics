using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsEx
{
    class builderex
    {
        void Create()
        {
            Director director = new Director();

            VehicleBuilder vb1 = new TwoWheelerBuilder();
            VehicleBuilder vb2 = new FourWheelerBuilder();
            
            director.Construct(vb1);
            vb1.Delivery();
            
            director.Construct(vb2);
            vb2.Delivery();
        }

    }


    class Director
    {
        public void Construct(VehicleBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    //This invloves some sequence of complex steps
    abstract class VehicleBuilder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void Delivery();
    }

    class TwoWheelerBuilder : VehicleBuilder
    {
        public override void BuildPartA()
        {
            throw new NotImplementedException();
        }

        public override void BuildPartB()
        {
            throw new NotImplementedException();
        }

        public override void Delivery()
        {
            throw new NotImplementedException();
        }
    }

    class FourWheelerBuilder : VehicleBuilder
    {
        public override void BuildPartA()
        {
            throw new NotImplementedException();
        }

        public override void BuildPartB()
        {
            throw new NotImplementedException();
        }

        public override void Delivery()
        {
            throw new NotImplementedException();
        }
    }
}
