using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    SayHi("swetha",33);
    SayHi("suvi",23);
    SayHi("Jim" , 27);
   Console.ReadLine();
   
    }
    
    static void SayHi(string name, int age)
    {
    Console.WriteLine(" Hello " + name + " you are age " + age + "!");
  }
}
}
