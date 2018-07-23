// How to catch AccessViolation exceptions? How to catch them at .NET 1?

// [x]

using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

class Program {
    static void AccessViolation() {
        try {
            IntPtr ptr = new IntPtr(123);
            Marshal.StructureToPtr(123, ptr, true);

        } finally {
            Console.WriteLine("Finally");
        }
    }

    [HandleProcessCorruptedStateExceptions]
    static void Main(string[] args) {
        try {
            AccessViolation();
        } catch (Exception e) {
            Console.WriteLine("Catch " + e.Message);
        }
    }
}

/*
csc src/03/H.csx
mono H.exe
 */
