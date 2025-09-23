namespace CodeReadExercise;
/**
 * What does this program print?
 */
internal class Program4
{
    static void Main()
    {
        int increment = 11;
        int i = 8;
        for (; i < 38; i += increment)
        {
            int value = i * (i + 1);
        }
        Console.WriteLine("A ciklusváltozó értéke a ciklust követően: {0}", i);
    }
}
