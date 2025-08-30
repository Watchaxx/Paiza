// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] nx = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] w = new int[nx[0]];
        int[] p = new int[nx[1] + 1];

        foreach( int i in Range( 0, nx[0] ) ) {
            w[i] = int.Parse( ReadLine() );
        }
        p[0] = 1;
        foreach( int i in Range( 0, nx[0] ) ) {
            foreach( int j in Range( 0, nx[1] + 1 ).Reverse() ) {
                if( 0 <= j - w[i] ) {
                    p[j] = System.Math.Max( p[j], p[j - w[i]] );
                }
            }
        }
        foreach( var i in Range( 0, nx[1] + 1 ).Where( i => p[i] == 1 ) ) {
            o = i;
        }
        WriteLine( o );
        return;
    }
}
