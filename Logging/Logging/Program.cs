using System;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info("App started {arguments}{username}", args, "kaushik");
            try
            {

            }
            catch(Exception e)
            {
                logger.Error(e, "This was unexpected {args}", 2);
            }
            NLog.LogManager.Shutdown();
        }
    }
}
