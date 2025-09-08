// 実行時間 220ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        decimal o = 0m;
        int n = int.Parse( ReadLine() );
        var d = new System.Collections.Generic.Dictionary<char, int>( n );

        foreach( int _ in Range( 0, n ) ) {
            string[] s = ReadLine().Split();

            d[s[0][0]] = int.Parse( s[1] );
        }
        ReadLine();
        foreach( string s in ReadLine().Split() ) {
            if( s.Length == 1 ) {
                o += d[s[0]];
            } else {
                decimal t = 0m;

                foreach( char c in s.ToCharArray() ) {
                    t += 1m / d[c];
                }
                o += 1m / t;
            }
        }
        WriteLine( (int)o );
        return;
    }
}
