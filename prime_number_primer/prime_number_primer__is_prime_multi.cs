// 実行時間 250ms
// 毎回計算すると遅いのでエラトステネスの篩を使う
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const int x = 6000000;
        int n = int.Parse( ReadLine() );
        bool[] p = Repeat( true, x + 1 ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        p[0] = false;
        p[1] = false;
        for( int i = 2; i <= x; i++ ) {
            if( p[i] == true ) {
                for( int j = 2 * i; j <= x; j += i ) {
                    p[j] = false;
                }
            }
        }
        for( int _ = 0; _ < n; _++ ) {
            WriteLine( p[int.Parse( ReadLine() )] ? "pass" : "failure" );
        }
        Out.Flush();
        return;
    }
}
