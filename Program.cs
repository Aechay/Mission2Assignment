// See https://aka.ms/new-console-template for more information

namespace Mission2Assignment;

internal class Program
{
    public static void Main(string[] args)
    {
        
        DiceFunctions df = new DiceFunctions(); // Imports? (IDK if you still call them that...)
        
        
        Console.WriteLine("Welcome to the dice throwing simulator!" 
                          + Environment.NewLine // \n would probably work here too... This just seemed safer
                          + "How many dice rolls would you like to simulate?");
        
        // It was throwing a fit about me just using Parse, so I switched to TryParse which has slightly different syntax
        Int32.TryParse(Console.ReadLine(), out int numRolls);
        
        int[] results = df.RollDice(numRolls);
        
        double[] percentages = df.CalculateResults(results, numRolls); // Calls the CalculateResults method
        
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS" 
                          + Environment.NewLine + Environment.NewLine 
                          + "Each \"*\" represents 1% of the total number of rolls."
                          + Environment.NewLine 
                          + "Total number of rolls = " 
                          +  numRolls + "."
                          +  Environment.NewLine);
        
        for (int i = 0; i < 11; i++)
        {
            // i + 2 because index zero is for dice roll of 2
            Console.WriteLine((i + 2) + ": " + df.NumAsterisks(percentages[i])); // Print the number and the asterisks
        }
        
        Console.WriteLine(Environment.NewLine + "Thank you for using the dice throwing simulator. Goodbye!");
    }
}