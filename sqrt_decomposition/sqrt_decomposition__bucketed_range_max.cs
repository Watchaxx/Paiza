// 実行時間 200ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0]];
        int[] b = Repeat( int.MinValue, n[0] / n[1] ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        foreach( int i in Range( 0, n[0] / n[1] ) ) {
            foreach( int j in Range( 0, n[1] ) ) {
                b[i] = Max( b[i], a[n[1] * i + j] );
            }
        }
        foreach( int _ in Range( 0, n[2] ) ) {
            int o = int.MinValue;
            int[] t = ReadLine().Split().Select( x => ( int.Parse( x ) - 1 ) / n[1] ).ToArray();

            foreach( int i in Range( t[0], t[1] - t[0] + 1 ) ) {
                o = Max( o, b[i] );
            }
            WriteLine( o );
        }
        Out.Flush();
        return;
    }
}
