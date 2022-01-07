using System;
using static System.Console;
using Singleton;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================================
            // Test for Singleton in multitreads
            // ================================
            Parallel.Invoke(
                () => TreadAcess1(),
                () => TreadAcess2()
            );
            // ================================
            // Create Singleton Instance
            // ================================
            Console.WriteLine("======Singleton Pattern======");
            Console.WriteLine("Try to create 1°st instance.");
            Singleton s1 = Singleton.Instance;

            // ================================
            // A 2°nd instance for test
            // ================================
            Console.WriteLine("Try to create 2°nd instance jsut for test, remenber only one must exist.");
            Singleton s2 = Singleton.Instance;

            // ================================
            // Test how many instance exist
            // ================================
            if (s1 == s2)
            {
                Console.WriteLine("There's only 1 Singleton instance. That's good.");
            }
            else
            {
                Console.WriteLine("There are diferent instances this is not good.");
            }
        }

        // ==========================================
        // Test Methods to use in parallel multitread
        // ==========================================
        private static void TreadAcess1()
        {
            Singleton test1 = Singleton.Instance;
            Console.WriteLine("Tread 1°");
        }

        private static void TreadAcess2()
        {
            Singleton test2 = Singleton.Instance;
            Console.WriteLine("Tread 2°");
        }
    }
}
