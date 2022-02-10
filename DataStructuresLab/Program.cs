using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word you would like to reverse: ");
            string word = Console.ReadLine();
            Console.WriteLine();
            string result = Reverse(word);
            Console.WriteLine("Your word in reverse is: " + result);
        }
        static string Reverse(string w)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char ch in w)
            {
                stack.Push(ch);
            }
            int count = stack.Count;
            string reverseWord = "";
            for(int i = 0; i < count; i++)
            {
                reverseWord += stack.Pop();
            }            
            return reverseWord;
        }
    }
}