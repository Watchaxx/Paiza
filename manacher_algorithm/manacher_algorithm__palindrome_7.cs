// 実行時間 70ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        string s = ReadLine();
        int[] o = Manacher( s );

        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, o.Length ).Where( x => ( x & 1 ) == 0 ).Select( x => o[x] ) ) );
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, o.Length ).Where( x => ( x & 1 ) != 0 ).Select( x => o[x] ) ) );
        return;
    }

    static int[] Manacher( string s )
    {
        var t = new List<char>( s.Length * 2 ) { '.' };

        foreach( char c in s ) {
            t.AddRange( new[] { c, '.' } );
        }

        var r = ManacherSub( t );

        r = r.Take( r.Count - 1 ).Skip( 1 ).ToList();
        return r.Select( x => x / 2 ).ToArray();
    }

    static List<int> ManacherSub( List<char> s )
    {
        int n = s.Count;
        int[] r = new int[n];

        for( int i = 0, j = 0; i < n; i++ ) {
            if( i < j + r[j] ) {
                r[i] = System.Math.Min( r[j - ( i - j )], j + r[j] - i );
            }
            if( j + r[j] <= i + r[i] ) {
                while( 0 <= i - r[i] && i + r[i] < n && s[i - r[i]] == s[i + r[i]] ) {
                    r[i]++;
                }
                j = i;
            }
        }
        return r.ToList();
    }
}
