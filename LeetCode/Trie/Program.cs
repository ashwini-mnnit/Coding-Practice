using System;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("cat");
            trie.Insert("cap");
            trie.Insert("bat");
            trie.Insert("tre");
            trie.Insert("ball");
            trie.Insert("hat");
            trie.Insert("map");
            trie.Insert("mall");
            
            Console.WriteLine(trie.Search("mallp"));
            Console.WriteLine(trie.Search(""));
        }
    }
}
