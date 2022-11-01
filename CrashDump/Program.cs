// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Runtime.CompilerServices;

foreach (DictionaryEntry environmentVariable in Environment.GetEnvironmentVariables())
{
    if(environmentVariable.Key.ToString()?.StartsWith("DOTNET_") == false) continue;
    Console.WriteLine($"{environmentVariable.Key}={environmentVariable.Value}");
}

Method();

[MethodImpl(MethodImplOptions.NoInlining)]
static void Method()
{
    for (int i = 0; i < 100; i++)
    {
        if(i > 50)
            throw new Exception("Crash");
    }
}
