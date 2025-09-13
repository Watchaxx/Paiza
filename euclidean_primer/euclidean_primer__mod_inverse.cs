using static System.Console;

internal class Program
{
    static void Main()
    {
        int x = 0;
        int y = 0;
        int[] ma = System.Array.ConvertAll( ReadLine().Split(), int.Parse );

        ExtGcd( ma[1], ma[0], ref x, ref y );
        WriteLine( ( x + ma[0] ) % ma[0] );
        return;
    }

    static int ExtGcd( int a, int b, ref int x, ref int y )
    {
        int c = a;

        if( b != 0 ) {
            c = ExtGcd( b, a % b, ref y, ref x );
            y -= a / b * x;
        } else {
            x = 1;
            y = 0;
        }
        return c;
    }
}
