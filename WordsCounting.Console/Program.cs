// See https://aka.ms/new-console-template for more information

using System.IO;
using WordsCounting;

string fileName = "demo.txt";
if (args.Length == 1)
{
    fileName = args[0];
}

File.OpenText(fileName).ReadToEnd().CountWords().PrintResult();