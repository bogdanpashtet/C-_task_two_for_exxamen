using System;

namespace var_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());;

            NUmbers fobj = new NUmbers(a,b);
            
            Console.WriteLine();
            Console.Write("Summ: ");
            Console.Write(fobj.summ());
            Console.WriteLine();
            Console.Write("Minus: ");
            Console.Write(fobj.subtraction());
            Console.WriteLine();
            Console.Write("Umn: ");
            Console.Write(fobj.multiplication());
            Console.WriteLine();
            Console.Write("Del: ");
            Console.Write(fobj.division());
            Console.WriteLine();
            Console.Write("Conjuction: ");
            Console.Write(fobj.conjunction());
            Console.WriteLine();
            Console.Write("Disjunctioon: ");
            Console.Write(fobj.disjunction());
            Console.WriteLine();
            
        }
    }
}