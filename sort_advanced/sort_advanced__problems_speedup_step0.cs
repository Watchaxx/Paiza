// 実行時間 680ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] q = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).OrderByDescending( x => x ).ToArray();
        int[] k = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, q[1] ) ) {
            WriteLine( a[k[i]] );
        }
        Out.Flush();
        return;
    }
}
