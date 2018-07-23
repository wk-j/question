// How to effectively swallow ThreadAbortException?

// [x]

using System;
using System.Threading;

public class Program {
    static void Start() {
        try {
            Thread.CurrentThread.Abort();
        } catch (ThreadAbortException) {
            Console.WriteLine("First");
        }
    }

    static void Main(String[] args) {
        try {
            try {
                Start();
            } catch (ThreadAbortException) {
                Thread.ResetAbort();
                Console.WriteLine("Second");
            }
        } catch (ThreadAbortException) {
            Console.WriteLine("Third");
        }
    }
}

/*
csc 02/H.csx
mono H.exe
 */
