var otherThread = new Thread(() =>
{
    while (true)
    {
        Console.WriteLine("Hello from other thread!");
    }
});

otherThread.Start();

while (true)
{
    Console.WriteLine("Hello from this thread!");
}
