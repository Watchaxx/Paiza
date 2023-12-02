using static System.Console;
using static System.Math;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        string[] rl = ReadLine().Split( ' ' );
        int n = int.Parse( rl[0] );
        int x = int.Parse( rl[1] );
        int a = int.Parse( rl[2] );
        int y = int.Parse( rl[3] );
        int b = int.Parse( rl[4] );
        int z = int.Parse( rl[5] );
        int c = int.Parse( rl[6] );
        int[] p = new int[n + z];

        for( int i = 0; i < n + z; i++ ) {
            p[i] = 10000 * 1000;
        }
        p[0] = 0;
        for( int i = 1; i < n + z; i++ ) {
            if( x <= i ) {
                p[i] = Min( p[i], p[i - x] + a );
            }
            if( y <= i ) {
                p[i] = Min( p[i], p[i - y] + b );
            }
            if( z <= i ) {
                p[i] = Min( p[i], p[i - z] + c );
            }
        }
        for( int i = n + z - 2; 1 <= i; i-- ) {
            p[i] = Min( p[i], p[i + 1] );
        }
        WriteLine( p[n] );
        return;
    }
}
