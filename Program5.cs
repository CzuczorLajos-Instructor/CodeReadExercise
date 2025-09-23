namespace CodeReadExercise;
/**
 * What does this program print?
 */
internal class Program5
{
    static void Main()
    {
        int a = 4;
        int b = 14;
        int c = b / a;
        for (int j = b; j >= c; j--)
        {
            if (j > 4 && j <= 12)
            {
                continue;
            }
            Console.WriteLine(a + 1 + " : " + j * j);
        }
    }
}
