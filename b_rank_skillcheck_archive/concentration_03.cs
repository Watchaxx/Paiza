// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hwn = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] t = new int[hwn[0]][];

        foreach( int i in Range( 0, hwn[0] ) ) {
            t[i] = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        }

        int l = int.Parse( ReadLine() );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, l ) ) {
            int[] ab = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            WriteLine( t[ab[0]][ab[1]] == t[ab[2]][ab[3]] ? "YES" : "NO" );
        }
        Out.Flush();
        return;
    }
}
