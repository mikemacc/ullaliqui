public static async Task Main(string[] args)
{
    var options = new NatsOptions { Url = "nats://localhost:4222" };
    
    await using var connection = new NatsConnection(options);
    
    // Subscribe to a subject
    SubscribeToSubject(connection, "test.subject");

    // Publish a message
    await PublishMessage(connection, "test.subject", "Hello, NATS!");

    // Keep the application running to receive messages
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}
