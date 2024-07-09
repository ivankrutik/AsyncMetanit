var tomTask = PrintNameAsync("Tom");
var bobTask = PrintNameAsync("Bob");
var samTask = PrintNameAsync("Sam");

await tomTask;
await bobTask;
await samTask;

// определение асинхронного метода
async Task PrintNameAsync(string name)
{
    await Task.Delay(3000);     // имитация продолжительной работы
    Console.WriteLine(name);
}