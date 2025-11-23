// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[,] g = new int[n[0], n[0]];
        var l = new System.Collections.Generic.List<(int, int)>();

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[t[0], t[1]]++;
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( i + 1, n[0] - i - 1 ).Where( x => 1 < g[i, x] + g[x, i] ) ) {
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
