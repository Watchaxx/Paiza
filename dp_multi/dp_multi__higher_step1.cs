// 実行時間 90ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = ReadLine().Split().Select( int.Parse ).ToArray();
        var d = new Dictionary<string, int>[n[0] + 1];

        foreach( int i in Range( 0, n[0] + 1 ) ) {
            d[i] = new Dictionary<string, int>();
        }
        d[0][""] = 0;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( var p in d[i] ) {
                var k = new List<int>();

                if( p.Key != string.Empty ) {
                    k = p.Key.Split( '_' ).Select( int.Parse ).ToList();
                }
                foreach( int j in Range( 0, 11 ) ) {
                    if( k.Sum() + j < a[i] || ( n[0] - n[1] + 1 <= i && 0 < j ) ) {
                        continue;
                    }

                    var nk = new List<int>( k ) { j };

                    if( nk.Count == n[1] ) {
                        nk.RemoveAt( 0 );
                    }

                    int nv = n[0] - n[1] + 1 <= i ? p.Value : p.Value + b[i] * j;
                    string nkStr = string.Join( "_", nk );

                    d[i + 1][nkStr] = d[i + 1].ContainsKey( nkStr ) ? new[] { d[i + 1][nkStr], nv }.Min() : nv;
                }
            }
        }
        WriteLine( d[n[0]].Values.Min() );
        return;
    }
}
