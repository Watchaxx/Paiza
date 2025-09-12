// 実行時間 250ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n - 1 ) ) {
            int mi = i;

            for( int j = i + 1; j < n; j++ ) {
                if( a[j] < a[mi] ) {
                    mi = j;
                }
            }
            int t = a[i];
            a[i] = a[mi];
            a[mi] = t;
            WriteLine( string.Join( " ", a ) );
        }
        Out.Flush();
        return;
    }
}
