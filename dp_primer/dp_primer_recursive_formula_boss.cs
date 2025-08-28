// 実行時間 10ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int Q = int.Parse( ReadLine() );
        int[] a = new int[100];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        a[0] = 1;
        a[1] = 1;
        foreach( int i in Range( 2, 98 ) ) {
            a[i] = a[i - 2] + a[i - 1];
        }
        foreach( int _ in Range( 0, Q ) ) {
            WriteLine( a[int.Parse( ReadLine() ) - 1] );
        }
        Out.Flush();
        return;
    }
}
