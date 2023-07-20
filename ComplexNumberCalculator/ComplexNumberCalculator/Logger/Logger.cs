using System.Reflection;

namespace ComplexNumberCalculator;
using System.Configuration;
public static class Logger
{
    /// <summary>
    /// метод расширения для логирования в папку на диске C:\\Temp/log.txt
    /// </summary>
    /// <param name="message">сообщение для лога</param>
    public static void WriteLog(string message)
    {
        string logPath = "C:\\Temp/log.txt";
        using (StreamWriter writer = new StreamWriter(logPath, true))
        {
            writer.WriteLine($"{DateTime.Now} : {message}");
        }
    }
}