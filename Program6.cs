namespace CodeReadExercise;
/**
 * What does this program print?
 */
internal class Program6
{
    static void Main()
    {
        for (bool mark = true; mark; mark = !mark)
        {
            int q = -5;
            bool flag = true;
            while (flag)
            {
                flag = ++q < 0;
                Console.WriteLine(q + " " + flag);
            }
        }
    }
}
