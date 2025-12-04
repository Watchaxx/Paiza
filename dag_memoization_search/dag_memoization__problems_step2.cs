// 実行時間 30ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[] Memo = new int[10001];
    static List<int>[] G;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        G = new List<int>[n[0]];
        foreach( int _ in Range( 0, n[0] - 1 ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            if( G[t[0]] == null ) {
                G[t[0]] = new List<int> { t[1] };
            } else {
                G[t[0]].Add( t[1] );
            }
        }
        Func( 0 );
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, n[1] ).Select( _ => Memo[int.Parse( ReadLine() )] ) ) );
        return;
    }

    static int Func( int c )
    {
        if( G[c] == null || G[c].Count == 0 ) {
            return Memo[c] = 1;
        }

        int t = 1;

        foreach( int i in Range( 0, G[c].Count ) ) {
            t += Func( G[c][i] );
        }
        Memo[c] = t;
        return t;
    }
}
