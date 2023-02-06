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

File.OpenText(fileName).ReadToEnd()
    .CountWords()
    .PrintResult();