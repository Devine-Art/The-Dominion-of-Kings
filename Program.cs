namespace Dominion_of_Kings
{
    public class Program
{
    static void Main(string[] args)
    {
        //ask user for variables and assign them
        Console.WriteLine("Enter # of estates");
        int estate = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter # of duchy's");
        int duchy = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter # of provinces");
        int province = int.Parse(Console.ReadLine());


        //Calculate point totals
        int points = estate + duchy + province

        //write results to console
        Console.WriteLine("# of points");
        Console.WriteLine(points);


    }
}
}