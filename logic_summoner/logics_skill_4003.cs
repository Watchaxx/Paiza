using static System.Console;

internal class Program
{
    static void Main()
    {
        WriteLine( System.Math.Min( int.Parse( ReadLine() ) + 50, 100 ) );
        return;
    }
}
