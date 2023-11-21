using System;

namespace MyApplication
{
  class fruit  //create class
  { 
 
  public string color; //create a field
 
 //create a class constructor
  
  public fruit()
  {
  color="apple";
  }
  
  static void Main(string[] args)
  {
  fruit myObj=new fruit(); //create object for the class constructor
  
  Console.WriteLine(myObj.color);
    }
    
    }
    
   }
 
    
