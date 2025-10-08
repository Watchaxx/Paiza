// 実行時間 100ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[1] ) ) {
            string[] s = ReadLine().Split();
            int k = int.Parse( s[1] ) - 1;
            var c = System.StringComparison.Ordinal;

            if( string.Compare( s[0], "update", c ) == 0 ) {
                a[k] = int.Parse( s[2] );
            } else if( string.Compare( s[0], "get", c ) == 0 ) {
                WriteLine( a.OrderByDescending( x => x ).ToArray()[k] );
            }
        }
        Out.Flush();
        return;
    }
}
