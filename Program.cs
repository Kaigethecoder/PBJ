public class Program
{
    public static void Main(string[] args)
    {
        bool pbj = true;
        int people = 0;

        Console.WriteLine("Hello, welcome to the PBJ Shop!");
        do
        {
            bool searchVal = true;
            while (searchVal) 
            {
                Console.WriteLine();
                Console.WriteLine("How many people are we serving today?");
                string pplnum = Console.ReadLine();
                try
                {
                    people = Int32.Parse(pplnum);
                    if (people > 0)
                    {
                        searchVal = false;
                    }
                    else
                    {
                        searchVal=true;
                        Console.WriteLine();
                        Console.WriteLine("Forgive me, I'm confused.  Please enter a positive number.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("Forgive me, I'm confused.  Please enter a positive number.");
                }
            }

            Console.WriteLine();
            double breadSlices = GetBreadSlices(people);
            double spoonsOfPB = GetPBAmount(people);
            double spoonsOfJelly = GetJellyAmount(people);
            Console.WriteLine(SeeIngredientAmount(people, breadSlices, spoonsOfPB, spoonsOfJelly));
            double totalLoaves = GetTotalLoaves(breadSlices);
            double totalPBJars = GetTotalJarsOfPB(spoonsOfPB);
            double totalJellyJars = GetTotalJarsOfJelly(spoonsOfJelly);
            Console.WriteLine(SeePackagesToOpen(totalLoaves, totalPBJars, totalJellyJars));

            bool validateResponse = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to go again? (y/n?)");
                string decision = Console.ReadLine();
                if (decision.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                {
                    validateResponse = true;
                    pbj = true;
                    Console.WriteLine();
                    Console.WriteLine("Great!");   
                }
                else if (decision.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                {
                    validateResponse = true;
                    pbj = false;
                    Console.WriteLine();
                    Console.WriteLine("Thanks for coming in, enjoy your day!");
                }
                else
                {
                    validateResponse = false;
                    Console.WriteLine();
                    Console.WriteLine("Sorry, I'm not sure what you mean by that.");
                }
            }
            while (validateResponse == false) ;
        }
        while (pbj);
    }
    public static double GetBreadSlices(int people)
    {
        return people * 2;
    }
    public static double GetPBAmount(int people)
    {
        return people * 2;
    }
    public static double GetJellyAmount(int people)
    {
        return people * 4;
    }
    public static string SeeIngredientAmount(int people, double bread, double pB, double jelly)
    {
        return $"To make sandwiches for {people} people we will need {bread} slices of bread, {pB} tablespoons of peanut butter, and {jelly} teaspoons of jelly!";
    }
    public static double GetTotalLoaves(double breadSlices)
    {
        double totalLoaves = breadSlices / 28;
        return Math.Ceiling(totalLoaves);
    }
    public static double GetTotalJarsOfPB(double spoonsOfPB)
    {
        double totalPBJars = spoonsOfPB / 32;
        return Math.Ceiling(totalPBJars);
    }
    public static double GetTotalJarsOfJelly(double spoonsofJelly)
    {
        double totalJellyJars = spoonsofJelly / 48;
        return Math.Ceiling(totalJellyJars);
    }
    public static string SeePackagesToOpen(double totalLoaves, double totalPBJars, double totalJellyJars)
    {
        return $"That means we will need {totalLoaves} loaves of bread, {totalPBJars} jars of Peanut Butter, and {totalJellyJars} jars of jelly.";
    }
}