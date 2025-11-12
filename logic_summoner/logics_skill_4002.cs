using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] m = System.Array.ConvertAll( ReadLine().Split(), int.Parse );
        WriteLine( m[0] * m[1] );
        return;
    }
}
