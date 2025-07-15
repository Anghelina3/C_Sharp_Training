namespace ConsoleApp1
{
  public class Program
  {
    public static void Main(string[] args)
    {
      IPerson worker1 = new Programmer("Alexei", 25);
      IPerson worker2 = new Programmer("Dina", 22);
      IPerson worker3 = new Programmer("Mihail", 30);
      List<IPerson> workers = new List<IPerson>();
      workers.Add(worker1);
      workers.Add(worker2);
      workers.Add(worker3);
      foreach (var worker in workers)
      {
        Console.WriteLine(worker.Name + " " + worker.Age);
      }

      workers.Sort();
      foreach (var worker in workers)
      {
        Console.WriteLine(worker.Name + " " + worker.Age);
      }
    }
  }
}
