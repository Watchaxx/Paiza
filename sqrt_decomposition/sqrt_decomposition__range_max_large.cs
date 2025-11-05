// 実行時間 220ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0]];
        int[] b = Repeat( int.MinValue, n[0] / 100 + 1 ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        foreach( int i in Range( 0, n[0] / 100 ) ) {
            foreach( int j in Range( 0, 100 ) ) {
                b[i] = Max( b[i], a[100 * i + j] );
            }
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int o = int.MinValue;
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            t[0]--;
            if( t[0] / 100 != ( t[1] - 1 ) / 100 ) {
                for( int i = t[0] / 100 + 1; i < t[1] / 100; i++ ) {
                    o = Max( o, b[i] );
                }
                for( int i = t[0]; i < t[0] + 100 - t[0] % 100; i++ ) {
                    o = Max( o, a[i] );
                }
                for( int i = t[1] - t[1] % 100; i < t[1]; i++ ) {
                    o = Max( o, a[i] );
                }
            } else {
                for( int i = t[0]; i < t[1]; i++ ) {
                    o = Max( o, a[i] );
                }
            }
            WriteLine( o );
        }
        Out.Flush();
        return;
    }
}
