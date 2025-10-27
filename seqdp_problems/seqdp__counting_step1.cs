// 実行時間 290ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const long mod = 10000000000;
        const string txt = "paiza";
        string s = ReadLine();
        long[][] d = new long[s.Length + 1][];

        foreach( int i in Range( 0, s.Length + 1 ) ) {
            d[i] = new long[txt.Length + 1];
        }
        d[0][0] = 1L;
        foreach( int i in Range( 0, s.Length ) ) {
            foreach( int j in Range( 0, txt.Length + 1 ) ) {
                d[i + 1][j] = ( d[i][j] + d[i + 1][j] ) % mod;
                if( j + 1 <= txt.Length && s[i] == txt[j] ) {
                    d[i + 1][j + 1] = ( d[i][j] + d[i + 1][j + 1] ) % mod;
                }
            }
        }
        WriteLine( d[s.Length][txt.Length] );
        return;
    }
}
