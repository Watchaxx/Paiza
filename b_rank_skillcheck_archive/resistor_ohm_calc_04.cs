// 実行時間 20ms
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
        foreach( char c in ReadLine() ) {
            o += 1m / d[c];
        }
        WriteLine( (int)( 1m / o ) );
        return;
    }
}
