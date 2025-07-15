using System;
using System.Collections.Generic;
namespace Collections {

public interface IPerson : IComparable<IPerson>
{
  void work();
  string Name { get; }
  int Age { get; }
}


public class Programmer : IPerson, IComparable<IPerson>
{
  public string Name{get; private set;}
  public int Age{get; private  set;}

  public Programmer(string name, int age)
  {
    Name = name;
    Age = age;
  }



  public void work()
  {
    Console.WriteLine("I'm coding");
  }

  public int CompareTo(IPerson other)
  {
    if (other == null) return 1;
    return this.Age.CompareTo(other.Age);
  }
}

class Example
{
  static void Main() {
    IPerson worker1 = new Programmer( "Alexei", 25);
    IPerson worker2 = new Programmer( "Dina", 22);
    IPerson worker3 = new Programmer( "Mihail", 30);
    List<IPerson> workers = new List<IPerson>();
    workers.Add(worker1);
    workers.Add(worker2);
    workers.Add(worker3);
    foreach (var worker in workers) {
      Console.WriteLine(worker.Name + " " +  worker.Age);
    }

    workers.Sort();
    foreach (var worker in workers) {
      Console.WriteLine(worker.Name + " " +  worker.Age);
    }
  }
}

}