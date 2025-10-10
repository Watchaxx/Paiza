// 実行時間 70ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var q = new System.Collections.Generic.Queue<int>();

        foreach( int _ in Range( 0, n[0] ) ) {
            string[] s = ReadLine().Split();
            var c = System.StringComparison.Ordinal;

            if( string.Compare( s[0], "ride", c ) == 0 ) {
                foreach( int i in s.Skip( 2 ).Select( int.Parse ).Where( x => o + x <= n[1] ) ) {
                    o += i;
                    q.Enqueue( i );
                }
            } else if( string.Compare( s[0], "get_off", c ) == 0 ) {
                foreach( int i in Range( 0, System.Math.Min( int.Parse( s[1] ), q.Count ) ) ) {
                    o -= q.Dequeue();
                }
            }
        }
        WriteLine( q.Count );
        WriteLine( o );
        return;
    }
}
