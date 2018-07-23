
try {
    throw new Exception("E2");
} catch (Exception e) when (e.Message == "E1") {
    Console.WriteLine("e1");
} catch (Exception e) when (e.Message == "E2") {
    Console.WriteLine("e2");
}
