using System.Threading.Tasks;


async void Go(int x) {
    if (x == 100) throw new Exception("Error");
    await Task.FromResult(100);
}

try {
    Go(100);
} catch (Exception err) {
    Console.WriteLine(err.Message);
}

Console.WriteLine("Hello");
Console.ReadLine();
