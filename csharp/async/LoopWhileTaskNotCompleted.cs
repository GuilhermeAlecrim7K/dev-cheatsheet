public class Program
{
    public static async Task Main()
    {
        // Call the asynchronous method and wait for its completion
        Task<string> task = ProcessDataAsync();

        // Loop until the task is completed
        while (!task.IsCompleted)
        {
            char[] icons = ['|', '/', '\u2014', '\\'];
            foreach (char icon in icons)
            {
                Console.Write($"\rLoading... {icon}");
                await Task.Delay(500); // Simulate doing other work while waiting
            }
        }
        Console.WriteLine();

        // Get the result from the completed task
        string result = task.Result;
        Console.WriteLine($"Task completed with result: {result}");
    }

    // Asynchronous method that returns a string
    public static async Task<string> ProcessDataAsync()
    {
        await Task.Delay(3000); // Simulating a time-consuming operation
        return "Processing complete!";
    }
}
