namespace CodeReadExercise;
/**
 * What does this program print?
 */
internal class Program7
{
    static void Main()
    {
        int s = 0;
        int i = 400_000_000;
        do
        {
            Console.WriteLine(s / 1_000_000);
            s += i;
        } while (s > 0);
    }
}
