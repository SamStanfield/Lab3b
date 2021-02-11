using System;

class MainClass {
  public static void Main (string[] args) {
    int salesammount;
    Console.WriteLine ("Enter sales persons name");
    string name = Console.ReadLine();

    Console.WriteLine ("Enter sales amount");
    salesammount = int.Parse(Console.ReadLine());

    double salescommisions = 200 + (.09 * salesammount);

    if ((salescommisions < 2999 ) && (salescommisions > 0))
    {Console.WriteLine("performance for " + name + " is poor");
    }
    
    if ((salescommisions > 3000) && (salescommisions <4999))
    {Console.WriteLine("performance for "+ name + " is average");
    }

    if ((salescommisions > 5000) && (salescommisions < 9999))
    {Console.WriteLine("performance for " + name + " is good");
    }

    if ((salescommisions > 10000) && (salescommisions < 14999))
    {Console.WriteLine("performance for " + name + " is excellent ");}

    if (salescommisions > 15000)
    {Console.WriteLine("performance for " + name + "is outstanding");
    }

    
    

    
  }
}