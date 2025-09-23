namespace CodeReadExercise;
/**
 * What's the problem with this piece of code? How can you fix it?
 */
internal class Program1
{
    static void Main()
    {
        int size = 7;
        int difference = 115;
        switch (size)
        {
            case 8:
                difference += 8;
            default:
                difference -= 2;
            case 2:
                difference += -9;
            case 4:
                difference += 12;
        }
        Console.WriteLine("difference : {0}", difference);
    }
}
