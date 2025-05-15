using Azure.AI.OpenAI;
using System;
using System.Text.Json;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Attempting to use OpenAIClient...");

try
{
    // Read configuration from appsettings.json
    var configJson = File.ReadAllText("appsettings.json");
    var config = JsonSerializer.Deserialize<Config>(configJson);
    
    if (string.IsNullOrEmpty(config?.OpenAI?.ApiKey))
    {
        throw new InvalidOperationException("OpenAI API key not found in appsettings.json");
    }

    var client = new OpenAIClient(config.OpenAI.ApiKey);
    Console.WriteLine("OpenAIClient instantiated successfully (type resolved).");
}
catch (Exception ex)
{
    Console.WriteLine($"Error or exception during OpenAIClient instantiation: {ex.GetType().Name} - {ex.Message}");
}

public class Config
{
    public OpenAIConfig OpenAI { get; set; }
}

public class OpenAIConfig
{
    public string ApiKey { get; set; }
}
