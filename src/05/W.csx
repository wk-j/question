using System;

class Program {

    void MyFunction() {
        try {
            var a = 100;
            Console.WriteLine(a);
        } catch (Exception) {

        } finally {
            Console.WriteLine("Finally");
        }
    }


}