using System;
using System.Collections.Generic;

namespace DS_Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var words = new List<string>() { "hello", "dog", "hell", "cat", "a", "hel", "help", "helps", "helping" };


            var trie = new Trie(words);
            Console.WriteLine(String.Join(",", trie.Suggest("hel")));

            Console.ReadLine();
        }
    }
}
