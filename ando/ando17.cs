// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int m = int.Parse( ReadLine() );
        string s = string.Concat( Repeat( 'R', n ) ) + string.Concat( Repeat( 'W', n ) );

        foreach( int _ in Range( 0, m / n ) ) {
            s += s;
        }
        WriteLine( s.Substring( 0, m ) );
        return;
    }
}
