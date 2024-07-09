// определяем и запускаем задачи
var task1 = SquareAsync(4);
var task2 = SquareAsync(5);
var task3 = SquareAsync(6);

await Task.WhenAll(task1, task2, task3);

//int[] results = await Task.WhenAll(task1, task2, task3);
// получаем результат задачи task2
Console.WriteLine($"task2 result: {task2.Result}"); // task2 result: 25


async Task<int> SquareAsync(int n)
{
    await Task.Delay(1000);
    return n * n;
}