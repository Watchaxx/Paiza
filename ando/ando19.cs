// 実行時間 10ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        string s = ReadLine();
        var d = new System.Collections.Generic.Dictionary<char, int>( 3 ) {
            ['a'] = 0,
            ['c'] = 0,
            ['t'] = 0
        };

        foreach( char c in s ) {
            d[c]++;
        }

        int m = d.Values.Min();
        int x = d.Values.Max() - m;

        WriteLine( m );
        WriteLine( x - ( d['c'] - m ) );
        WriteLine( x - ( d['a'] - m ) );
        WriteLine( x - ( d['t'] - m ) );
        return;
    }
}
