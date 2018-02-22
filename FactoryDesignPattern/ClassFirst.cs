namespace FactoryDesignPattern
{
    public class ClassFirst : IGet
    {
        public string ConcateString(string s1, string s2)
        {
            return $"this is from first class = {s1 + s2}";
        }
    }
}
