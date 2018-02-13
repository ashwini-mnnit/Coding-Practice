using System;
using System.Collections.Generic;

namespace HuffmanEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<char, int>> input = new List<Tuple<char, int>>();
            input.Add(new Tuple<char, int>('a',10));
            input.Add(new Tuple<char, int>('c',40));
            input.Add(new Tuple<char, int>('d',5));
            input.Add(new Tuple<char, int>('e',100));
            input.Add(new Tuple<char, int>('g',30));
            
            Solution sln= new Solution();

            HuffmanNode n = sln.CreateHuffmanTree(input);
            
            Console.WriteLine("Hello World!");
        }
    }
}
