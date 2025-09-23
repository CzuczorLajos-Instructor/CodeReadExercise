namespace CodeReadExercise;
/**
 * What's the problem with this piece of code?
 */
internal class Program2
{
    static void Main()
    {
        int omicron;
        int num = input(); // num is between -100 and +100, both inclusive
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
    static int input()
    {
        Console.WriteLine("Add meg az N számot (-100 ≤ N ≤ +100)!");
        do
        {
            int number;
            Console.Write("N = ");
            number = int.TryParse(Console.ReadLine() ?? "0");
        } while (number < -100 || number > +100);
        return number;
    }
}
