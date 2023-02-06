using WordsCounting;

string fileName = "demo.txt";
if (args.Length == 1)
{
    fileName = args[0];
}
else
{
    Console.WriteLine("Demo file will be used as source of words");
}

File.OpenText(fileName).ReadToEnd()
    .CountWords()
    .PrintResult();