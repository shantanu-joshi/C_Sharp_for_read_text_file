using System;  
using System.IO;  
  
namespace ReadATextFile {  
 class Program {  
 
  static readonly string rootFolder = @"C:\\Users\\shantanu joshi\\Desktop\\";    
    
  static readonly string textFile = @"C:\Users\shantanu joshi\Desktop\\helloSir.txt";  
  
  static void Main(string[] args) {  
   if (File.Exists(textFile)) {  
    string text = File.ReadAllText(textFile);   

    Console.WriteLine(text.Length);

    if (text.ToUpper() == text)
    {
      Console.WriteLine("All content is in uppercase");

    }
    else
    {
    Console.WriteLine("Not in uppercase");
    }


    
   }  
    }  
   }   
  }  