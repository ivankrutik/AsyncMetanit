// определяем и запускаем задачи
var task1 = PrintAsync("Hello C#");
var task2 = PrintAsync("Hello World");
var task3 = PrintAsync("Hello METANIT.COM");

// ожидаем завершения всех задач
await Task.WhenAll(task1, task2, task3);
//await Task.WhenAny(task1, task2, task3);

async Task PrintAsync(string message)
{
    await Task.Delay(2000);     // имитация продолжительной операции
    Console.WriteLine(message);
}