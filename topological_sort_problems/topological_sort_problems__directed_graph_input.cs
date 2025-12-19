// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] g = new int[n[0]][];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new int[n[0]];
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]][a[1]] = 1;
        }
        WriteLine( string.Join( System.Environment.NewLine, g.Select( x => string.Join( "", x ) ) ) );
        foreach( int[] i in g ) {
            foreach( int j in Range( 0, n[0] ).Where( x => i[x] == 1 ) ) {
                Write( j );
            }
            WriteLine();
        }
        Out.Flush();
        return;
    }
}
