// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var d = new System.Collections.Generic.Dictionary<char, int>( n );

        foreach( int _ in Range( 0, n ) ) {
            string[] s = ReadLine().Split();

            d[s[0][0]] = int.Parse( s[1] );
        }
        WriteLine( string.Join( System.Environment.NewLine, d.OrderBy( x => x.Key ).Select( x => x.Value ) ) );
        return;
    }
}
