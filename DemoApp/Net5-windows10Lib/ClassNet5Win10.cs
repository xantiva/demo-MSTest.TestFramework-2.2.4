using System.IO;

namespace Net5_windows10Lib
{
    public class ClassNet5Win10
    {
        public void WriteHelloWorld(string fileName)
        {
            File.WriteAllLines(fileName, new string[] { "Hello World!" });
        }
    }
}
