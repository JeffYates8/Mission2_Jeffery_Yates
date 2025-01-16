using Mission1_Jeffery_Yates;


internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        // user input for num of rolls
        int numOfRolls = int.Parse(Console.ReadLine());

        //
        DiceSimulator simulator = new DiceSimulator();
        int[] rollResults = simulator.SimulateRolls(numOfRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numOfRolls}.\n");

        //for loop to determine roll sum with number of rolls
        for (int total = 2; total <= 12; total++)
        {
            int percentage = (rollResults[total] * 100) / numOfRolls;
            Console.WriteLine($"{total}: {new string('*', percentage)}");
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }
}