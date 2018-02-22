namespace FactoryDesignPattern
{
    /// <summary>
    /// This class is actually use to separate the object creation logic from the main class 
    /// we can declare this class as abstract as well
    /// </summary>
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
