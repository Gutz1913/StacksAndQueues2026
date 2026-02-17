using Queues.Backend;

var queue = new QueueUsingArray<int>(5);
var opt = string.Empty;

do
{
    opt = Menu();
    switch (opt)
    {
        case "1":
            try
            {
                Console.Write("Enter a number: ");
                var number = int.Parse(Console.ReadLine()!);
                queue.Enqueue(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "2":
            try
            {
                var item = queue.Dequeue();
                Console.WriteLine($"Item dequeued: {item}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "3":
            try
            {
                var item = queue.Peek();
                Console.WriteLine($"Item at front: {item}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
    }
}
while (opt != "0");

string Menu()
{
    Console.WriteLine("1. Enqueue");
    Console.WriteLine("2. Dequeue");
    Console.WriteLine("3. Peek");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
    return Console.ReadLine()!;
}