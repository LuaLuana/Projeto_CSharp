using System;
using src.Entities;

namespace projeto_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           Knight arus = new Knight("Arus",23,"Knight");
           Wizard wizard = new Wizard("Jenica ",23,"White Wizard");
           Ninja ninja = new Ninja ("Wedge " , 42, "Ninja"); 
           Black_Wizard black_Wizard = new Black_Wizard ("Topapa", 30, "Black Wizard");
           
           Console.WriteLine(arus.Attack()); 
           Console.WriteLine(wizard.Attack()); 
           Console.WriteLine(ninja.Attack()); 
           Console.WriteLine(black_Wizard.Attack()); 
        }
    }
}
