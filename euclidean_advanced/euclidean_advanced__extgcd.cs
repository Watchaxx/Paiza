// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        long x = 0;
        long y = 0;
        long[] a = System.Array.ConvertAll( ReadLine().Split(), long.Parse );

        ExtGcd( a[0], a[1], ref x, ref y );
        WriteLine( $"{x} {y}" );
        return;
    }

    static long ExtGcd( long a, long b, ref long x, ref long y )
    {
        long c = a;

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
