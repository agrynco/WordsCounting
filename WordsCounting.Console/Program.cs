using System.Reflection;
using WordsCounting;

string fileName = "demo.txt";
if (args.Length == 1)
{
    fileName = args[0];
}
else
{
    Console.WriteLine($"{Path.GetFileName(Assembly.GetEntryAssembly()!.Location)} [fileName]");
    Console.WriteLine("No fileName is specified so demo file will be used as source of words");
}

if (!File.Exists(fileName))
{
    Console.WriteLine($"File with name {fileName} does not exist");
    return 1;
}

fileName.ReadAsText()
    .CountWords()
    .PrintResult();

return 0;