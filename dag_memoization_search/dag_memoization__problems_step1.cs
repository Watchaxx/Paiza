// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static long[] Memo;
    static List<int>[] Job;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        Memo = Repeat( -1L, n[0] ).ToArray();
        Job = new List<int>[n[0]];
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            if( Job[t[1]] == null ) {
                Job[t[1]] = new List<int> { t[0] };
            } else {
                Job[t[1]].Add( t[0] );
            }
        }
        foreach( int i in Range( 0, n[0] ).Where( x => Job[x] != null ) ) {
            Job[i] = Job[i].OrderByDescending( x => x ).ToList();
        }
        WriteLine( Func( n[0] - 1 ) );
        return;
    }

    static long Func( int j )
    {
        if( Memo[j] != -1 ) {
            return Memo[j];
        } else if( Job[j] == null || Job[j].Count == 0 ) {
            return Memo[j] = 1;
        }

        long c = 0L;

        foreach( int i in Range( 0, Job[j].Count ) ) {
            c += Func( Job[j][i] );
            c %= 1000000007;
        }
        return Memo[j] = c;
    }
}
