// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            uint[] a = ReadLine().Split().Select( uint.Parse ).ToArray();

            WriteLine( Range( 0, 32 ).Any( x => ( ( a[0] >> x ) & ( ( 1 << BitLen( a[1] ) ) - 1 ) ) == a[1] ) ? "Yes" : "No" );
        }
        return;
    }

    static int BitLen( uint n )
    {
        int o = 0;

        while( 0 < n ) {
            n >>= 1;
            o++;
        }
        return o;
    }
}
