using Spectre.Console;
using System.Data;
using System.Data.SqlClient;


namespace SpectreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.MarkupLine($"Welcome to My App {Emoji.Known.SmilingFace}");
            var choice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("[green] Select your option [/]?")
                    .AddChoices(new[] {
                        "Add Transaction", "View Expenses", "View Income",
                        "Check Balance"
            }));
            Console.WriteLine($"You selected {choice}");
        }
    }
}