// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;
using S = System.Collections.Generic.Stack<int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        S[] s = new S[3];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        for( int i = 0; i < 3; i++ ) {
            s[i] = new S();
        }
        foreach( int _ in Range( 0, n ) ) {
            string[] t = ReadLine().Split();
            int b = int.Parse( t[1] ) - 1;
            var c = System.StringComparison.Ordinal;

            if( string.Compare( t[0], "push", c ) == 0 ) {
                s[b].Push( int.Parse( t[2] ) );
            } else if( string.Compare( t[0], "pop", c ) == 0 ) {
                s[b].Pop();
            }
        }
        foreach( S i in s.Where( x => 0 < x.Count ) ) {
            WriteLine( string.Join( System.Environment.NewLine, i ) );
        }
        Out.Flush();
        return;
    }
}
