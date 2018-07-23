class A : Exception
{
    public A(string ex) : base(ex) { }
}

void MyFunction()
{
    throw new A("Hello");
}

MyFunction();