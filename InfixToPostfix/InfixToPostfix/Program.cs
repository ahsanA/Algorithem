using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infix
{
    class Program
    {

        static string InfixToPostfixConvert(string infixBuffer)
        {
            string postfixBuffer = "";
            return postfixBuffer;
        }

        static void Main(string[] args)
        {
            string infixBuffer = "";
            

            
            
                infixBuffer = "a+b*c";
                System.Console.WriteLine("InFix  :\t" + infixBuffer);
                System.Console.WriteLine("PostFix:\t" + InfixToPostfixConvert(infixBuffer));
                System.Console.WriteLine();

                infixBuffer = "a+b*c/d-e";
                System.Console.WriteLine("InFix  :\t" + infixBuffer);
                System.Console.WriteLine("PostFix:\t" + InfixToPostfixConvert(infixBuffer));
                System.Console.WriteLine();

                infixBuffer = "a+b*c/d-e+f*h/i+j-k";
                System.Console.WriteLine("InFix  :\t" + infixBuffer);
                System.Console.WriteLine("PostFix:\t" + InfixToPostfixConvert(infixBuffer));
                System.Console.WriteLine();

                infixBuffer = "a+b*(c/(d-e)+f)*(h/(i+j-k))";
                System.Console.WriteLine("InFix  :\t" + infixBuffer);
                System.Console.WriteLine("PostFix:\t" + InfixToPostfixConvert(infixBuffer));
                System.Console.WriteLine();

                System.Console.ReadLine();
           
        }
    }
}