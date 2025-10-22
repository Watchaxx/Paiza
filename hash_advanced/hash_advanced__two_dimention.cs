// 実行時間 40ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static void Main()
    {
        int[] nmab = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] x = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] y = ReadLine().Split().Select( int.Parse ).ToArray();
        var h = new List<Tpl>[nmab[2]][];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, nmab[2] ) ) {
            h[i] = new List<Tpl>[nmab[3]];
            foreach( int j in Range( 0, nmab[3] ) ) {
                h[i][j] = new List<Tpl>();
            }
        }
        foreach( int i in Range( 0, nmab[0] ) ) {
            h[x[i] % nmab[2]][y[i] % nmab[3]].Add( new Tpl( x[i], y[i] ) );
        }
        foreach( int _ in Range( 0, nmab[1] ) ) {
            int[] p = ReadLine().Split().Select( int.Parse ).ToArray();
            var d = h[p[0]][p[1]];

            WriteLine( 0 < d.Count ? $"{d.Last().Item1} {d.Last().Item2}" : "-1" );
        }
        Out.Flush();
        return;
    }
}
