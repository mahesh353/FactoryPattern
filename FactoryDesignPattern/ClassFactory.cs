namespace FactoryDesignPattern
{
    public class ClassFactory
    {
        static public IGet CreateandReturnObj(int Choice)
        {
            IGet ObjSelector = null;

            switch (Choice)
            {
                case 1:
                    ObjSelector = new ClassFirst();
                    break;
                case 2:
                    ObjSelector = new SecondClass();
                    break;
                default:
                    ObjSelector = new ClassFirst();
                    break;
            }
            return ObjSelector;
        }
    }
}
