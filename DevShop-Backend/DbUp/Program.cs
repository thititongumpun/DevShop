using DbUp;
using System;
using System.Linq;
using System.Reflection;

namespace DbUp
{
    class Program
    {
        static int Main(string[] args)
        {
            var connectionString = args.FirstOrDefault() 
                                    ?? "Data Source=localhost;Trusted_Connection=True;";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Start...Migrate.......");
            Console.ResetColor();
            var upgrader = DeployChanges.To
                                .SqlDatabase(connectionString)
                                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                                .LogToConsole()
                                .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
                Console.ReadLine();

                return -1;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Db migrate Done.!");
            Console.ResetColor();
            return 0;
            
        }
    }
}
