namespace Mission2Assignment;

public class DiceFunctions
{
    private static Random _rand = new Random(); // I probably could have initialized the randomness inside the RollDice method, but I didn't...
    public int[] RollDice(int numRolls)
    {
        int[] results = new int[11]; // One 0 for each possible result of rolling 2 6-sided die, 2-12
        for (int i = 0; i < numRolls; i++)
        {
            int d1 = _rand.Next(1, 7); // Roll dice 1 (random number 1-6)
            int d2 = _rand.Next(1, 7); // Roll dice 2 (random number 1-6)

            int roll = d1 + d2; // Add the 2 rolls together
            results[roll - 2]++; // In the results array, increment the number in the position corresponding to the roll by 1
        }
        return results; // Return the results array
    }
    public double[] CalculateResults(int[] results, int rollNum)
    {
        double[] finalTally = new double[11]; // Initialize an array of doubles with enough space for everything
        for (int i = 0; i < 11; i++)
        {
            int thisNum = results[i]; // grab the number of rolls matching the current iteration (num of rolls equaling 2 for i=0)
            double percentage = (((double)thisNum / rollNum) * 100); // Divide by the total number of rolls and multiply by 100 to give a nice number. Left as a double for now but converted to an int later on.
            finalTally[i] = percentage; // Change the finalTally array to reflect the percentage of rolls for a given number
        }
        return finalTally;
    }

    public string NumAsterisks(double number)
    {
        int convertedNumber = Convert.ToInt32(number); // Takes the double and converts it to an int by rounding
        string asterisks = new string('*', convertedNumber); // Take the int from the previous line and make a string that number of asterisks long
        return asterisks; // Return that string of asterisks
    }
}