namespace CodeReadExercise;
/**
 * What does this program print?
 */
internal class Program8
{
    static void Main()
    {
        int a = 2;
        int b = 9;
        int c = b / a;
        for (int i = b; i >= c; i--)
        {
            if (i == 5 || i > 8)
            {
                continue;
            }
            Console.WriteLine(a + 2 + " : " + i * i);
        }
    }
}
