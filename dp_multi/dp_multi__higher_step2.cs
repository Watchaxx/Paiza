// 実行時間 2410ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        long[] o = new long[n[0] + 1];
        var d = new Dictionary<string, long>[n[0] + 1, n[0] + 1];

        foreach( int i in Range( 0, n[0] + 1 ) ) {
            foreach( int j in Range( 0, n[0] + 1 ) ) {
                d[i, j] = new Dictionary<string, long>();
            }
        }
        d[0, 0][string.Empty] = 1;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, n[0] + 1 ) ) {
                foreach( var p in d[i, j] ) {
                    var lbase = p.Key == string.Empty
                        ? new List<int>() : p.Key.Split( ',' ).Select( int.Parse ).ToList();
                    var lnew = new List<int>( lbase ) { -1 };

                    if( lnew.Count == n[1] ) {
                        lnew = lnew.Skip( 1 ).ToList();
                    }

                    string nk = string.Join( ",", lnew );

                    d[i + 1, j][nk] = d[i + 1, j].ContainsKey( nk )
                        ? d[i + 1, j][nk] + p.Value : p.Value;
                    if( j == n[0] ) {
                        continue;
                    }
                    foreach( int k in Range( 0, n[0] ) ) {
                        lnew = new List<int>( lbase ) { k };
                        if( Valid( lnew ) != true ) {
                            continue;
                        }
                        if( lnew.Count == n[1] ) {
                            lnew = lnew.Skip( 1 ).ToList();
                        }
                        nk = string.Join( ",", lnew );
                        d[i + 1, j + 1][nk] = d[i + 1, j + 1].ContainsKey( nk )
                            ? d[i + 1, j + 1][nk] + p.Value : p.Value;
                    }
                }
            }
        }
        foreach( int i in Range( 0, n[0] + 1 ) ) {
            foreach( var p in d[n[0], i] ) {
                o[i] += p.Value;
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, o.Skip( 1 ) ) );
        return;
    }

    static bool Valid( List<int> l )
    {
        var m = new HashSet<int>();
        var p = new HashSet<int>();

        foreach( int i in Range( 0, l.Count ) ) {
            int c = l[i];

            if( c == -1 ) {
                continue;
            }
            if( p.Add( i + c ) != true || m.Add( i - c ) != true ) {
                return false;
            }
        }
        return true;
    }
}
