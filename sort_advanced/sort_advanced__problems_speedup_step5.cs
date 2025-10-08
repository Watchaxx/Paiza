// 実行時間 260ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nmk = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[nmk[0]][];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, nmk[0] ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        System.Array.Sort( a, ( x, y ) => Compare( x, y, nmk[2] - 1 ) );
        foreach( int[] b in a ) {
            WriteLine( string.Join( " ", b ) );
        }
        Out.Flush();
        return;
    }

    static int Compare( int[] x, int[] y, int k )
    {
        int l = System.Math.Min( x.Length, y.Length );

        if( y[k] < x[k] ) {
            return 1;
        } else if( x[k] < y[k] ) {
            return -1;
        }
        foreach( int i in Range( 0, l ) ) {
            if( y[i] < x[i] ) {
                return 1;
            } else if( x[i] < y[i] ) {
                return -1;
            }
        }
        return 0;
    }
}
