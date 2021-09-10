using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of item");
    var item = Console.ReadLine ();
    Console.WriteLine ("Enter the quantity");
    int quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the price"); 
    double price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Total price of " + item + " is " + (quantity * price));
  }
}