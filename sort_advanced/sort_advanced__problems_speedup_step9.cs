// 実行時間 160ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).OrderBy( z => z ).ToArray();
        int[] x = ReadLine().Split().Select( int.Parse ).ToArray();
        var d = new System.Collections.Generic.Dictionary<int, int>( n[0] );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            d[a[i]] = i + 1;
        }
        foreach( int i in x ) {
            WriteLine( d[i] );
        }
        Out.Flush();
        return;
    }
}
