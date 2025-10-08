// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, n[0] ) ) {
            int[] s = ReadLine().Split( ',' ).Select( int.Parse ).ToArray();

            if( n[1] <= s[1] ) {
                WriteLine( string.Join( ",", s ) );
            }
        }
        Out.Flush();
        return;
    }
}
