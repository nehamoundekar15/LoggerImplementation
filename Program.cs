
namespace LoggerImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("**************************************************");
            try
            {
                throw new Exception("This is an Exception");
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                LogExceptionToFile(ex);
                
                Console.ReadKey();  
            }
        }

        private static void LogExceptionToFile(Exception ex)
        {
            string filePath = "logger.txt";
            string logMessage = $"[{DateTime.Now}] Exception: {ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}";
            File.AppendAllText(filePath, logMessage);
        }
    }
}
 