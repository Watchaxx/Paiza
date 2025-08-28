// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] x = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[1000];
        int q = int.Parse( ReadLine() );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        a[0] = x[0];
        foreach( int i in Range( 1, 999 ) ) {
            a[i] = i % 2 == 0 ? a[i - 1] + x[1] : a[i - 1] + x[2];
        }
        foreach( int _ in Range( 0, q ) ) {
            WriteLine( a[int.Parse( ReadLine() ) - 1] );
        }
        Out.Flush();
        return;
    }
}
