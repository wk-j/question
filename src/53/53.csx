
var s1 = new StringBuilder("abc");
var s2 = new StringBuilder("abc");

Console.WriteLine(s1 == s2);
Console.WriteLine(s1.Equals(s2));

class A {
    public static bool operator ==(A a1, A a2) => false;
    public static bool operator !=(A a1, A a2) => true;
    public override bool Equals(object obj) => true;
}

var a = new A();
Console.WriteLine(a == a);
Console.WriteLine(a.Equals(a));