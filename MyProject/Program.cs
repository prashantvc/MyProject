// See https://aka.ms/new-console-template for more information

using MyNativeLib;

Console.WriteLine("Calling native method...");
Console.WriteLine($"*** DYLD_LIBRARY_PATH= {Environment.GetEnvironmentVariable("DYLD_LIBRARY_PATH")}");

int result = NativeClass.MyNativeMethod();
Console.WriteLine($"Result from native method: {result}");