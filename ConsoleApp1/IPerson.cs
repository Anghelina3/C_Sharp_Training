namespace ConsoleApp1
{
    public interface IPerson : IComparable<IPerson>
    {
        void Work();
        string Name { get; }
        int Age { get; }
    }
}