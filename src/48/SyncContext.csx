#! "netcoreapp2.1"
#r "nuget:nito.AsyncEx,4.0.1"

using System.Threading;
using Nito.AsyncEx;

async void Go(int x) {
    if (x == 100) throw new Exception("Error");
    await Task.FromResult(100);
}

try {
    AsyncContext.Run(() => {
        Go(100);
    });
    // Go(100);

} catch (Exception ex) {
    Console.WriteLine("Catch {0}", ex.Message);
}

Console.ReadLine();