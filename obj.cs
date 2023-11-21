using System;

namespace MyApplication
{
  class Shapes
  {
  string triangle = "three sides";
  string square = "four sides";
  string rectangle = "six sides";
  
    static void Main(string[] args)
    {
    Shapes obj=new Shapes();
      Console.WriteLine(obj.triangle);
      Console.WriteLine(obj.square);
      Console.WriteLine(obj.rectangle);
    }
  }
}
