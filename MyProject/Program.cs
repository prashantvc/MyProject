// See https://aka.ms/new-console-template for more information

using MyNativeLib;

Console.WriteLine("Calling native method...");
int result = NativeClass.MyNativeMethod();
Console.WriteLine($"Result from native method: {result}");