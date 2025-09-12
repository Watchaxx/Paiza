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
            for( int j = n - 1; i < j; j-- ) {
                if( a[j] < a[j - 1] ) {
                    int t = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = t;
                }
            }
            WriteLine( string.Join( " ", a ) );
        }
        Out.Flush();
        return;
    }
}
