namespace DesignPatternsEx
{
    class AdapterEx
    {

        void Create()
        {
            NewDatabaseConnection obj = new Adapter();
            obj.Connection();
        }
    }


    class NewDatabaseConnection
    {
        public virtual void Connection()
        {

        }
    }

    abstract public class MyClass
    {
      public int Add(int a , int b)
        {
            return a + b;
        }

        public abstract int sub();
    }

    class clientabs : MyClass
    {
        public override int sub()
        {
            
            return 1;
        }
    }

    class Adapter : NewDatabaseConnection
    {
        OldDatabaseConnection curentApplication = new OldDatabaseConnection();
        public override void Connection()
        {
            curentApplication.Connection();
        }
    }

    class OldDatabaseConnection
    {
        public void Connection()
        {
        }
    }
}
