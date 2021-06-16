using System;

namespace estrutura_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) QueueTest");
            Console.WriteLine("2) StackTest");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    QueueTest();
                    return true;
                case "2":
                    StackTest();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void QueueTest()
        {
            var queueManager = new QueueManager();

            queueManager.GenerateNext();
            queueManager.GenerateNext();
            queueManager.GenerateNext();

            queueManager.ShowAll();
            queueManager.GoNext();
            queueManager.GoNext();

            queueManager.ShowAll();
            queueManager.GenerateNext();
            queueManager.GoNext();
            queueManager.ShowAll();

            Console.WriteLine(Environment.NewLine);
        }

        private static void StackTest()
        {
            var stackManager = new StackManager();
            stackManager.Add("Iniciou um artigo.");
            stackManager.Add("Escreveu - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            stackManager.Add("Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");
            stackManager.ShowLast();
            stackManager.Rollback();
            stackManager.ShowLast();
        }
    }
}
