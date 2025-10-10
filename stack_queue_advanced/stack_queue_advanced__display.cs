// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        var q = new System.Collections.Generic.Queue<int>();

        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            string[] s = ReadLine().Split();
            int i = int.Parse( s[1] );
            var c = System.StringComparison.Ordinal;

            if( string.Compare( s[0], "add", c ) == 0 ) {
                q.Enqueue( i );
            } else if( string.Compare( s[0], "buy", c ) == 0 ) {
                foreach( int j in Range( 0, i ) ) {
                    q.Dequeue();
                }
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, q ) );
        return;
    }
}
