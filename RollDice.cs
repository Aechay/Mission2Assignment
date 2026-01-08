namespace Mission2Assignment;

public class RollDice
{
    private static Random random = new Random();
    public int RollEm() // I'm bad at naming things :)
    {
        int d1 = random.Next(1, 7); // Roll dice 1 (random number 1-6)
        int d2 = random.Next(1, 7); // Roll dice 2 (random number 1-6)

        int roll = d1 + d2; // Add the 2 rolls together
        return roll; // Return the sum
    }
}