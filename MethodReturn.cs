using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    int cubedNumbers= cube(5);
    Console.WriteLine(cubedNumbers);
   Console.ReadLine();
   
   // 2^3 ->2* 2* 2
    }
    
    static int cube(int num)
    {
    int result = num* num * num;
    return result;
    
    }
    
}
}
