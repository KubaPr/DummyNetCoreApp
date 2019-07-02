using System.IO;

namespace DummyNetCoreApp
{
    public static class FileReader
    {
        public static string Read()
        {
            string path = @"D:\dev\sources\jenkins_sandbox\greeting.txt";
            string readText = File.ReadAllText(path);

            return readText;
        }
    }
}
