// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;
using Q = System.Collections.Generic.Queue<int>;

internal class Program
{
    static void Main()
    {
        Q[] q = new Q[3];

        foreach( int i in Range( 0, 3 ) ) {
            q[i] = new Q();
        }
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            string[] s = ReadLine().Split();
            int i = int.Parse( s[1] ) - 1;
            var c = System.StringComparison.Ordinal;

            if( string.Compare( s[0], "push", c ) == 0 ) {
                q[i].Enqueue( int.Parse( s[2] ) );
            } else if( string.Compare( s[0], "pop", c ) == 0 ) {
                q[i].Dequeue();
            }
        }
        foreach( Q i in q.Where( x => 0 < x.Count ) ) {
            WriteLine( string.Join( System.Environment.NewLine, i ) );
        }
        return;
    }
}
