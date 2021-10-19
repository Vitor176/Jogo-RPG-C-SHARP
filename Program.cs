using System;
using CursoPOO_DIO.src.entities;
namespace CursoPOO_DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight ");
            Wizard wizard = new Wizard("Jenica", 23 , "White Wizard");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(30));
        }
    }
}
