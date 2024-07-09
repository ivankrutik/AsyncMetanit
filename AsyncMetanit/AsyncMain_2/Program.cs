await PrintNameAsync("Tom");
await PrintNameAsync("Bob");
await PrintNameAsync("Sam");

// определение асинхронного метода
async Task PrintNameAsync(string name)
{
    await Task.Delay(3000);     // имитация продолжительной работы
    Console.WriteLine(name);
}