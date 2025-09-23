namespace CodeReadExercise;
/**
 * What does this program print?
 */
internal class Program9
{
    static void Main()
    {
        int i = 200_000_000;
        do
        {
            Console.WriteLine(i / 1_000_000);
            i *= 2;
        } while (i > 0);
    }
}
