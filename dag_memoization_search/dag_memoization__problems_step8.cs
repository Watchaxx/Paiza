// 実行時間 2130ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            int n = int.Parse( ReadLine() );

            if( 0 <= n && n <= 99 ) {
                WriteLine( 0 );
                continue;
            }

            int[] d = new int[] { n % 10, n % 100 / 10, n % 1000 / 100 }.OrderBy( x => x ).ToArray();
            int a = d[0] + d[1] * 10 + d[2] * 100;
            int b = d[0] * 100 + d[1] * 10 + d[2];

            WriteLine( a - b == 0 || a - b == 99 ? 0 : 495 );
        }
        Out.Flush();
        return;
    }
}
