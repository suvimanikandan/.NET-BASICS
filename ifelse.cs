using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    bool isMale = true;
    bool isTall = false;
    
    if(isMale && isTall)
    {
    Console.WriteLine("you are a tall male");
    }
    else if(isMale && !isTall) {
    Console.WriteLine("you are a short male");
    }
    else if(!isMale && isTall) {
    Console.WriteLine("you are a not a male but you are a  tall male");
    }
    else{
     Console.WriteLine("You are either not male or not tall or both");
    }
Console.ReadLine();
}
}
}
