// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();
        bool[,] p = new bool[s.Length + 1, s.Length + 1];
        int[] d = Repeat( s.Length + 1, s.Length + 1 ).ToArray();

        foreach( int i in Range( 0, s.Length ) ) {
            int l = i;
            int r = i;

            while( 0 <= l && r < s.Length ) {
                if( s[l] != s[r] ) {
                    break;
                }
                p[l, r + 1] = true;
                l--;
                r++;
            }
        }
        foreach( int i in Range( 0, s.Length ) ) {
            int l = i;
            int r = i + 1;

            while( 0 <= l && r < s.Length ) {
                if( s[l] != s[r] ) {
                    break;
                }
                p[l, r + 1] = true;
                l--;
                r++;
            }
        }
        d[0] = 0;
        foreach( int i in Range( 1, s.Length ) ) {
            foreach( int j in Range( 0, i ).Where( x => p[x, i] ) ) {
                d[i] = System.Math.Min( d[i], d[j] + 1 );
            }
        }
        WriteLine( d[s.Length] );
        return;
    }
}
