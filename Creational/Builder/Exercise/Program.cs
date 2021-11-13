using System;
using System.Collections.Generic;

namespace Exercise
{
    public class CodeBuilder
    {
        private readonly string _root;
        private readonly List<string> _fields;

        public CodeBuilder(string root)
        {
            _root = root;
            _fields = new List<string>();
        }

        public CodeBuilder AddField(string name, string type)
        {
            _fields.Add($"  public {type} {name};");
            return this;
        }


        public override string ToString()
        {
            var toRet = $"public class {_root}" +
                        Environment.NewLine + "{" + Environment.NewLine;

            foreach (var field in _fields)
            {
                toRet += field + Environment.NewLine;
            }

            toRet += "}";
            return toRet;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb.ToString());
        }
    }
}
