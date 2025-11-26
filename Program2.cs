namespace CodeReadExercise;
/**
 * Can Main() method compile? If not, how can you fix it?
 * Suppose that InputWidth() compiles and always returns a value between -100 and +100, both inclusive.
 */
internal class Program2
{
    static void Main()
    {
        int omicron;
        int num = InputWidth(); // num is between -100 and +100, both inclusive
        if (num < 40)
        {
            omicron = 3;
        }
        else if (num < 70)
        {
            omicron = 33;
        }
        else if (num > 10)
        {
            Console.WriteLine("Nagyobb, mint 10");
        }
        else
        {
            omicron = 333;
        }
        Console.WriteLine("Omikron = " + omicron);
    }
    // ensures that the return value is between -100 and +100
    static int InputWidth()
    {
        Console.WriteLine("Add meg a szélességet (-100..+100)!");
        for (; ; )
        {
            Console.Write("Sz = ");
            if (int.TryParse(Console.ReadLine(), out int width) && width is >= -100 and <= +100)
                return width;
        }
    }
}
