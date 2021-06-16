using System;
using System.Collections.Generic;

namespace estrutura_dados
{
    public class QueueManager
    {
        private readonly Queue<int> _queueService;
        private int _nextNumberToGenerate = 1;

        public QueueManager()
        {
            _queueService = new Queue<int>();
        }

        public int GenerateNext()
        {
            _queueService.Enqueue(_nextNumberToGenerate);
            Console.WriteLine("Senha gerada.");
            return _nextNumberToGenerate++;
        }

        public void GoNext()
        {
            var nextNumber = _queueService.Dequeue();
            Console.WriteLine($"Próxima senha: {nextNumber}");
        }

        public void ShowAll()
        {
            Console.Write("Senhas da Fila: ");
            Console.Write(string.Join(", ", _queueService));
            Console.WriteLine();
        }

        public void ResetQueue()
        {
            _queueService.Clear();
        }
    }
}
