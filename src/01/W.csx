// What happens when I throw exception as something that doesnt inherit from System.Exception ? What's going on up to 1?

// [x]

class A : Exception {
    public A(string ex) : base(ex) { }
}

void MyFunction() {
    throw new A("Hello");
}

MyFunction();