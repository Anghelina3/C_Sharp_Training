namespace ConsoleApp1
{
    public class Programmer : IPerson, IComparable<IPerson>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Programmer(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public void Work()
        {
            Console.WriteLine("I'm coding");
        }

        public int CompareTo(IPerson other)
        {
            if (other == null) return 1;
            return this.Age.CompareTo(other.Age);
        }
    }
}