using Azure.AI.OpenAI;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Attempting to use OpenAIClient...");

try
{
    // Use a dummy API key for this test, as we only care about type resolution
    var client = new OpenAIClient("DUMMY_API_KEY_DOES_NOT_MATTER_HERE");
    Console.WriteLine("OpenAIClient instantiated successfully (type resolved).");
}
catch (Exception ex)
{
    Console.WriteLine($"Error or exception during OpenAIClient instantiation: {ex.GetType().Name} - {ex.Message}");
}
