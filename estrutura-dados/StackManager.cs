using System;
using System.Collections.Generic;

namespace estrutura_dados
{
    public class StackManager
    {
        private Stack<string> _historic;

        public StackManager()
        {
            _historic = new Stack<string>();
        }

        public void Add(string str)
        {
            _historic.Push(str);
        }

        public void Rollback()
        {
            Console.WriteLine($"Última operação desfeita.");
            _historic.Pop();
        }

        public void ShowLast()
        {
            var ultimaOperacao = _historic.Peek();
            Console.WriteLine(ultimaOperacao);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
