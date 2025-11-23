// 実行時間 30ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var l = new List<int>[n[0] + 1];

        foreach( int i in Range( 1, n[0] ) ) {
            l[i] = new List<int>();
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            l[t[0]].Add( t[1] );
            l[t[1]].Add( t[0] );
        }
        WriteLine( Range( 1, n[0] ).All( x => ( l[x].Count & 1 ) == 0 ) ? 1 : 0 );
        return;
    }
}
