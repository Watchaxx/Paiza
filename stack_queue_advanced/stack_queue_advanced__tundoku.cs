// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        var s = new System.Collections.Generic.Stack<int>();

        foreach( int _ in Range( 0, n ) ) {
            string[] t = ReadLine().Split();
            int p = int.Parse( t[1] );
            var c = System.StringComparison.Ordinal;

            if( string.Compare( t[0], "buy_book", c ) == 0 ) {
                o += p;
                s.Push( p );
            } else if( string.Compare( t[0], "read", c ) == 0 ) {
                while( 0 < p ) {
                    int d = s.Pop();

                    if( p < d ) {
                        o -= p;
                        s.Push( d -= p );
                        break;
                    }
                    o -= d;
                    p -= d;
                }
            }
        }
        WriteLine( s.Count );
        WriteLine( o );
        return;
    }
}
