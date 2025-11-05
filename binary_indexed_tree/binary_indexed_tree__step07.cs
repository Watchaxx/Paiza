// 実行時間 230ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        long[] a = ReadLine().Split().Select( long.Parse ).ToArray();
        long[] b = new long[n + 1];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n ) ) {
            b[i + 1] = a[i] + b[i];
        }
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            WriteLine( b[int.Parse( ReadLine() )] );
        }
        Out.Flush();
        return;
    }
}
