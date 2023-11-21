using System;

namespace MyApplication
{
  class fruit  //create class
  { 
 
  public string color; //create a field
 
 //create a class constructor with parameters
  
  public fruit (string colorName)
  {
  color=colorName;
  }
  
  static void Main(string[] args)
  {
  fruit myObj=new fruit("red"); //create object for the class constructor
  
  Console.WriteLine(myObj.color);
    }
    
    }
    
   }
 
    
