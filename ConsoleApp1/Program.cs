using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
 class Program
    {
        delegate void Name(string input);
        static void Main()
        {
            Name name = delegate (string input1)
            {
                Console.WriteLine("Hi Mr " + input1);
            };
            Console.Write("Enter your name :");
            string x;
            bool check = true;
            do
            {
                x = Console.ReadLine();
                foreach (char i in x)
                {
                    
                     if (i < '0' || i > '9') 
                    {
                        foreach(char a in "the quick brown fox jumps over the lazy dog THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG")
                        {
                            if (a == i) { check = true; break; }
                            else { check = false;}
                        }
                    }
                    else { Console.WriteLine("input again!"); check = false;break; }
                    if (check == false) { Console.WriteLine("input again!");  break; }
                }
            } while (check == false);
            name(x);
           
        }
    }


}
