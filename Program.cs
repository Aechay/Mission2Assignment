// See https://aka.ms/new-console-template for more information
using Mission2Assignment;

internal class Program
{
    public static void Main(string[] args)
    {
        RollDice rd = new RollDice(); // Imports? (IDK if you still call them that...)
        CalculateStuff cs = new CalculateStuff();
        
        int numRolls;
        
        int[] results = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; // One 0 for each possible result of rolling 2 6-sided die, 2-12
        Console.WriteLine("Welcome to the dice throwing simulator!" + Environment.NewLine + "How many dice rolls would you like to simulate?");
        numRolls = int.Parse(Console.ReadLine());

        for (int i = 0; i < numRolls; i++) // Call the RollEm method the amount of times specified updating the results array as it goes
        {
            int roll = rd.RollEm();
            results[roll - 2]++;
        }

        double[] percentages = cs.CalculateResults(results, numRolls); // Calls the CalculateResults method
        
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS" 
                          + Environment.NewLine + Environment.NewLine 
                          + "Each \"*\" represents 1% of the total number of rolls."
                          + Environment.NewLine + "Total number of rolls = " +  numRolls + "."
                          +  Environment.NewLine);
        
        for (int i = 0; i < 11; i++)
        {
            // i + 2 because index zero is for dice roll of 2
            Console.WriteLine((i + 2) + ": " + cs.NumAsterisks(percentages[i])); // Print the number and the asterisks
        }
        
        Console.WriteLine(Environment.NewLine + "Thank you for using the dice throwing simulator. Goodbye!");
    }
}