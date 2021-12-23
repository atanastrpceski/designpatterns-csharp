using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Sentence
    {
        private readonly string[] words;
        private readonly Dictionary<int, WordToken> tokens = new();

        public Sentence(string plainText)
        {
            words = plainText.Split(' ');
        }

        public WordToken this[int index]
        {
            get
            {
                WordToken wt = new WordToken();
                tokens.Add(index, wt);
                return tokens[index];
            }
        }

        public override string ToString()
        {
            var ws = new List<string>();
            for (var i = 0; i < words.Length; i++)
            {
                var w = words[i];
                if (tokens.ContainsKey(i) && tokens[i].Capitalize)
                    w = w.ToUpperInvariant();
                ws.Add(w);
            }
            return string.Join(" ", ws);
        }

        public class WordToken
        {
            public bool Capitalize;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Sentence("alpha beta gamma");
            s[1].Capitalize = true;
            Console.WriteLine(s.ToString());
        }
    }
}
