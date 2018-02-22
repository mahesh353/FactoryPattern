namespace FactoryDesignPattern
{
    public class SecondClass : IGet
    {
        public string ConcateString(string s1, string s2)
        {
            return $"this is from second class = {s1 + s2}";
        }
    }
}
