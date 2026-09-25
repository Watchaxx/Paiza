// 実行時間 30ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        string cnt = string.Empty;
        var dic = new Dictionary<string, int>();
        var vst = new HashSet<string>();
        var lcn = new List<string>();
        var lft = new List<string>();
        var sb = new System.Text.StringBuilder();

        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            string w = ReadLine();

            if( dic.ContainsKey( w ) != true ) {
                dic[w] = 1;
            } else {
                dic[w]++;
            }
        }
        foreach( var kvp in dic ) {
            string s = kvp.Key;

            if( vst.Contains( s ) )
                continue;

            string rev = RevStr( s );

            if( string.CompareOrdinal( s, rev ) == 0 ) {
                int c = kvp.Value;
                int p = c / 2;

                foreach( int _ in Range( 0, p ) ) {
                    lft.Add( s );
                }
                if( c % 2 == 1 ) {
                    lcn.Add( s );
                }
                vst.Add( s );
            } else {
                if( dic.TryGetValue( rev, out int revCnt ) ) {
                    int p = System.Math.Min( kvp.Value, revCnt );
                    string minStr = string.CompareOrdinal( s, rev ) < 0 ? s : rev;

                    foreach( int _ in Range( 0, p ) ) {
                        lft.Add( minStr );
                    }
                    vst.Add( s );
                    vst.Add( rev );
                }
            }
        }
        lft.Sort();
        if( 0 < lcn.Count ) {
            lcn.Sort();
            cnt = lcn[0];
        }
        foreach( string s in lft ) {
            sb.Append( s );
        }
        sb.Append( cnt );
        foreach( int i in Range( 0, lft.Count ).Reverse() ) {
            sb.Append( RevStr( lft[i] ) );
        }
        WriteLine( sb.ToString() );
    }

    static string RevStr( string s )
    {
        char[] c = s.ToCharArray();

        System.Array.Reverse( c );
        return string.Join( "", c );
    }
}
