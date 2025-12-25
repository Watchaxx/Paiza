// 実行時間 60ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<string>( n * n );

        foreach( int _ in Range( 0, n ) ) {
            string s = ReadLine();

            l.AddRange( Range( 1, s.Length ).Select( x => s.Substring( 0, x ) ) );
        }
        WriteLine( string.Join( System.Environment.NewLine, l.OrderBy( x => x ).Distinct() ) );
        return;
    }
}
