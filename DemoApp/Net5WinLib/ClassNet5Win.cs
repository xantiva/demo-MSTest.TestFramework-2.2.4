using System.IO;

namespace Net5WinLib
{
    public class ClassNet5Win
    {
        public void WriteHelloWorld(string fileName)
        {
            File.WriteAllLines(fileName, new string[] { "Hello World!" });
        }
    }
}
