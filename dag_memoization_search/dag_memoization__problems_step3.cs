// 実行時間 40ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[] R;
    static int[] Rm = Repeat( -1, 10000 ).ToArray();
    static List<int>[] G;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        R = ReadLine().Split().Select( int.Parse ).ToArray();
        G = new List<int>[n[0]];
        foreach( int i in Range( 0, n[0] ) ) {
            G[i] = new List<int>();
        }
        foreach( int i in Range( 0, n[0] - 1 ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            G[t[0]].Add( t[1] );
        }
        Func( 0 );
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, n[1] ).Select( _ => Rm[int.Parse( ReadLine() )] ) ) );
        return;
    }

    static int Func( int c )
    {
        if( Rm[c] != -1 ) {
            return Rm[c];
        }

        int t = R[c];

        foreach( int i in G[c] ) {
            t = new[] { t, Func( i ) }.Max();
        }
        return Rm[c] = t;
    }
}
