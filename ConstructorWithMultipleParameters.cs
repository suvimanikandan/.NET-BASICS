using System;

namespace MyApplication
{
  class fruit  //create class
  { 
 
  public string color;
  public int counting;
  public string tasting;
  //create a field
 
 //create a class constructor with parameters
  
  public fruit (string colorName, int count , string taste)
  {
  color=colorName;
  counting =count;
  tasting =taste;
  }
  
  static void Main(string[] args)
  {
  fruit myObj=new fruit("red",2,"sweet"); //create object for the class constructor
  
  Console.WriteLine(myObj.color + " " + "counting " + myObj.counting + " " + "tasting" +  " " + myObj.tasting);
    }
    
    }
    
   }
 
    
