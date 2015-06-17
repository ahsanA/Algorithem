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
            StringBuilder postfixBuffer = new StringBuilder();

            Dictionary<char, int> precedence = new Dictionary<char, int>();
            precedence.Add('*', 3);
            precedence.Add('/', 3);
            precedence.Add('+', 2);
            precedence.Add('-', 2);
            precedence.Add('(', 1);

            Stack<char> operatorStack = new Stack<char>();

            foreach (char token in infixBuffer)
            {
                if ("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Contains(token) || "0123456789".Contains(token))
                {
                    postfixBuffer.Append(token);
                }
                else if (token == '(')
                {
                    operatorStack.Push(token);
                }
                else if (token == ')')
                {
                    var topToken = operatorStack.Pop();
                    while (topToken != '(')
                    {
                        postfixBuffer.Append(topToken);
                        topToken = operatorStack.Pop();
                    }
                }
                else
                {
                    while (operatorStack.Count != 0 && (precedence[operatorStack.Peek()] >= precedence[token]))
                    {
                        postfixBuffer.Append(operatorStack.Pop());
                    }
                    operatorStack.Push(token);
                }
            }

            while (operatorStack.Count != 0)
                postfixBuffer.Append(operatorStack.Pop());

            return postfixBuffer.ToString();
        }

        static void Main(string[] args)
        {
            string infixBuffer = "";

            infixBuffer = "(A+B)*C";
            System.Console.WriteLine("InFix  :\t" + infixBuffer);
            System.Console.WriteLine("PostFix:\t" + InfixToPostfixConvert(infixBuffer));
            System.Console.WriteLine();


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