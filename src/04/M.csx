// Method A calls method B from the try block part try + finally.
// Method B causes an exception in the try block part of the try + finally block.
// Is it possible that no finally will be performed? Is it possible that only the outermost(from method A) will be executed ?

// [ ]

using System.Runtime.ExceptionServices;
using System;
using System.Runtime.InteropServices;

class Program {

    static void A() {
        try {
            B();
        } finally {
            Console.WriteLine("Final A");
        }
    }

    static void B() {
        try {
            IntPtr ptr = new IntPtr(123);
            Marshal.StructureToPtr(123, ptr, true);
        } finally {
            Console.WriteLine("Final B");
        }
    }

    static void Main(String[] args) {
        B();
    }
}

/*
csc src/04/M.csx
mono M.exe
*/
