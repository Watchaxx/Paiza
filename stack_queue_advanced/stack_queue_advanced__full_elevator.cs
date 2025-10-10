// 実行時間 70ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int o = 0;
        var s = new System.Collections.Generic.Stack<int>();

        foreach( int _ in Range( 0, n[0] ) ) {
            string[] t = ReadLine().Split();
            var c = System.StringComparison.Ordinal;

            if( string.Compare( t[0], "ride", c ) == 0 ) {
                foreach( var i in t.Skip( 2 ).Select( int.Parse ).Where( x => o + x <= n[1] ) ) {
                    o += i;
                    s.Push( i );
                }
            } else if( string.Compare( t[0], "get_off", c ) == 0 ) {
                foreach( int i in Range( 0, int.Parse( t[1] ) ) ) {
                    o -= s.Pop();
                }
            }
        }
        WriteLine( s.Count );
        WriteLine( o );
        return;
    }
}
