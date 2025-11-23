// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[][] g = new int[n][];
        var l = new System.Collections.Generic.List<(int, int)>();

        foreach( int i in Range( 0, n ) ) {
            g[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
            foreach( int j in Range( i + 1, n - i - 1 ).Where( x => 1 < g[i][x] ) ) {
                l.Add( (i + 1, j + 1) );
            }
        }
        WriteLine( l.Count );
        if( 0 < l.Count ) {
            WriteLine( string.Join( System.Environment.NewLine,
                l.Select( x => $"{x.Item1} {x.Item2}" ) ) );
        }
        return;
    }
}
