using System.Runtime.InteropServices;

namespace MyNativeLib;

public class NativeClass
{
    [DllImport("native/libmylibrary.so", EntryPoint = "MyNativeMethod")]
    public static extern int MyNativeMethod();
}