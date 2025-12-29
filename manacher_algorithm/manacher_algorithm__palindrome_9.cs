// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

class Program
{
    static void Main()
    {
        string s = ReadLine();
        char[] t = Repeat( '.', 2 * s.Length + 1 ).ToArray();
        int x = -1;
        int[] m = new int[t.Length];
        int[] n = Repeat( -1, t.Length - 1 ).ToArray();
        int[] o = new int[s.Length];

        foreach( int i in Range( 0, s.Length ) ) {
            t[2 * i + 1] = s[i];
        }
        for( int i = 0, j = 0; i < t.Length; i++ ) {
            if( i < j + m[j] ) {
                m[i] = Min( m[j - ( i - j )], j + m[j] - i );
            }
            if( j + m[j] <= i + m[i] ) {
                while( 0 <= i - m[i] && i + m[i] < t.Length && t[i - m[i]] == t[i + m[i]] ) {
                    m[i]++;
                }
                j = i;
            }
        }
        foreach( int i in Range( 0, n.Length ) ) {
            n[i - m[i] + 1] = Max( n[i - m[i] + 1], i );
        }
        foreach( int i in Range( 0, n.Length ) ) {
            x = Max( x, n[i] );
            o[i / 2] = x - i + 1;
        }
        WriteLine( string.Join( System.Environment.NewLine, o ) );
        return;
    }
}
