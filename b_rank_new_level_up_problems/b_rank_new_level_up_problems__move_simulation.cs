// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int c = 0;
        int n = int.Parse( ReadLine() );
        int[] t = new int[n];
        long[] x = new long[n];
        long[] y = new long[n];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n ) ) {
            string[] s = ReadLine().Split();

            t[i] = int.Parse( s[0] );
            y[i] = long.Parse( s[1] );
            x[i] = long.Parse( s[2] );
        }
        foreach( int i in Range( 0, 101 ) ) {
            if( i == t[c] ) {
                WriteLine( $"{y[c]} {x[c]}" );
                c++;
            } else {
                WriteLine( $"{y[c - 1] + ( i - t[c - 1] ) * ( y[c] - y[c - 1] ) / ( t[c] - t[c - 1] )} {x[c - 1] + ( i - t[c - 1] ) * ( x[c] - x[c - 1] ) / ( t[c] - t[c - 1] )}" );
            }
        }
        Out.Flush();
        return;
    }
}
