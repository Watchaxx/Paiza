// 実行時間 30ms
using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int t = s.Length / 2;
        int[][] d = new int[t + 1][];
        var o = new List<string>();
        var rc = new List<Tuple<int, string>>[t + 1][];
        var nn = new List<Tuple<int, List<string>>>() { MkTpl( 0, new List<string>() ) };
        var al = new Tuple<int, string>[4][];

        foreach( int i in Range( 0, t + 1 ) ) {
            d[i] = Repeat( int.MaxValue, 4 ).ToArray();
            rc[i] = new List<Tuple<int, string>>[4];
        }
        d[0][0] = 0;
        al[0] = new Tuple<int, string>[] { MkTpl( 0, "00" ), MkTpl( 2, "01" ) };
        al[1] = new Tuple<int, string>[] { MkTpl( 0, "10" ), MkTpl( 2, "11" ) };
        al[2] = new Tuple<int, string>[] { MkTpl( 1, "01" ), MkTpl( 3, "00" ) };
        al[3] = new Tuple<int, string>[] { MkTpl( 1, "11" ), MkTpl( 3, "10" ) };
        foreach( int i in Range( 0, t ) ) {
            string ss = s.Substring( 2 * i, 2 );

            foreach( int j in Range( 0, 4 ).Where( x => d[i][x] != int.MaxValue ) ) {
                foreach( var p in al[j] ) {
                    int v = d[i][j] + HammingD( p.Item2, ss );

                    if( v == d[i + 1][p.Item1] ) {
                        rc[i + 1][p.Item1].Add( MkTpl( j, p.Item2 ) );
                    }
                    if( v < d[i + 1][p.Item1] ) {
                        d[i + 1][p.Item1] = v;
                        rc[i + 1][p.Item1] = new List<Tuple<int, string>>() { MkTpl( j, p.Item2 ) };
                    }
                }
            }
        }
        Console.WriteLine( d[t][0] );
        foreach( int i in Range( 1, t ).Reverse() ) {
            var pn = new List<Tuple<int, List<string>>>();

            foreach( var p in nn ) {
                foreach( var q in rc[i][p.Item1] ) {
                    pn.Add( MkTpl( q.Item1, new List<string>( p.Item2 ) { q.Item2 } ) );
                }
            }
            nn = new List<Tuple<int, List<string>>>( pn );
        }
        Console.WriteLine( nn.Count );
        foreach( var p in nn ) {
            p.Item2.Reverse();
            o.Add( string.Join( "", p.Item2 ) );
        }
        Console.WriteLine( string.Join( Environment.NewLine, o.OrderBy( x => x ) ) );
        return;
    }

    static int HammingD( string s1, string s2 )
    {
        return Range( 0, s1.Length ).Where( x => s1[x] != s2[x] ).Count();
    }

    static Tuple<int, string> MkTpl( int i, string s )
    {
        return Tuple.Create( i, s );
    }

    static Tuple<int, List<string>> MkTpl( int i, List<string> s )
    {
        return Tuple.Create( i, s );
    }
}
