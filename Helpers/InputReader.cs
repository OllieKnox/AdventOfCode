using System.Reflection;

namespace AdventOfCode.Helpers
{
    public abstract class InputReader
    {
        public static List<string> ReadInput(string relativeInputPath)
        {
            var executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new DirectoryNotFoundException("Unable to find directory of executable");
            var inputPath = Path.Combine(executablePath, relativeInputPath);
            return [..File.ReadAllLines(inputPath)];

        }
    }
}
