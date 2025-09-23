namespace CodeReadExercise;
/**
 * What's the problem with this piece of code?
 */
internal class Program3
{
    static void Main()
    {
        int omicron;
        int num = input(); // num is between -100 and +100, both inclusive, see input() method
        if (num < 40)
        {
            omicron = 3;
        }
        else if (num < 70)
        {
            omicron = 33;
        }
        else if (num < 10)
        {
            Console.WriteLine("Kisbb, mint 10");
        }
        else
        {
            omicron = 333;
        }
        Console.WriteLine("Omikron = " + omicron);
    }

    static int input()
    {
        int number;
        Console.WriteLine("Add meg az N számot (-100 ≤ N ≤ +100)!");
        do
        {
            Console.Write("N = ");
            number = int.Parse(Console.ReadLine() ?? "0");
        } while (number < -100 || number > +100);
        return number;
    }
}
