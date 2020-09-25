using System;
public class Home {




  public void PrintDetails(int a, string b)
  {
    Console.WriteLine("Name : " + a + " " + b);
  }

  internal void PrintDetails(User u)
  {
    Console.WriteLine("class print : " + u);
    Console.WriteLine("Location : " + u.Location + " " + u.Name);
  }

  internal void PrintDetails(string v)
  {
   Console.WriteLine("Name : " + v + " ");
  }
}