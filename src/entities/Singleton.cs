namespace Singleton
{
    public class Singleton
    {
        // ==========================
        // A static private member of Singleton Type
        // It assurance the global acess
        // ==========================
        private static Singleton instance;

        // ==========================
        // Create a object to lock multitreads
        // Now we can use this singleton in multitreads
        // ==========================
        private static object lockObject = new object();
        private int instanceCount = 0;
        // ==========================
        // Private Void Constructor Method
        // This way only Singleton Class Can Create an instance
        // ==========================
        private Singleton()
        {
            System.Console.WriteLine("Writing inside the private constructor. ");
            instanceCount++;
            System.Console.WriteLine($"Instance's Count: {instanceCount}");
        }

        // ==========================
        // Declare static member Instance
        // That return itself class instance 
        // ==========================
        public static Singleton Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        System.Console.WriteLine("Creating the 1°st instance.");
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}