namespace Mission2Assignment;

public class CalculateStuff
{
    public double[] CalculateResults(int[] results, int rollNum)
    {
        double[] finalTally = {0,0,0,0,0,0,0,0,0,0,0}; // Initialize an array of doubles with enough space for everything
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
        int convertedNumber = Convert.ToInt32(number); // Takes the double and converts it to an int
        string asterisks = new string('*', convertedNumber); // Take the int from the previous line and make a string that number of asterisks long
        return asterisks; // Return that string
    }
}