using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsEx
{
    internal abstract class ProtoType
    {
        public abstract ProtoType Clone();
    }

    //shallowcopy - keeps the latest update value from the source/dest obj
    //Deepcopy - keeps the latest update value from dest obj

    internal class TestProtoType : ProtoType
    {
        public int id { get; set; }
        public string name { get; set; }

        public override ProtoType Clone()
        {
            return this.MemberwiseClone() as ProtoType;
        }
    }

    internal class Client
    {
        private static void Main(string[] args)
        {
            TestProtoType tp = new TestProtoType();

            tp.id = 1;
            tp.name = "koti";

            TestProtoType t1 = tp.Clone() as TestProtoType;

            tp.id = 2;
            tp.name = "koti2";

            Console.WriteLine(t1.name + t1.id);
            Console.Read();
        }

        private void CreateCopy()
        {
            //TestProtoType tp = new TestProtoType();
            //tp.id = 1;
            //tp.name = "koti";

            //TestProtoType t1 = tp.Clone() as TestProtoType;

            //Console.WriteLine(tp.name + tp.id);
            //Console.Read();
        }
    }
}