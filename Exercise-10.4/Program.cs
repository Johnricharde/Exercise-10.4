namespace Exercise_10._4
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new MyCopyableClass();
            obj1.ContainedInt = 5;
            MyCopyableClass obj2 = obj1.GetCopy();
            obj1.ContainedInt = 9;
            WriteLine(obj1.ContainedInt);
            WriteLine(obj2.ContainedInt);
        }
    }
}
