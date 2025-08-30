// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int level = 4;
        int n = int.Parse( ReadLine() );
        int[] ng = new int[4];
        int[] ok = new int[4];
        char[] lvl = new char[] { 'A', 'B', 'C', 'D', 'E' };
        string[] exm = new string[] { "TA", "TB", "TC", "TD" };

        foreach( int _ in Range( 0, n ) ) {
            string[] tj = ReadLine().Split( ' ' );
            var c = System.StringComparison.Ordinal;

            foreach( int i in Range( 0, 4 ).Where( i => string.Compare( tj[0], exm[i], c ) == 0 ) ) {
                if( string.Compare( tj[1], "ng", c ) == 0 ) {
                    ng[i]++;
                } else if( string.Compare( tj[1], "ok", c ) == 0 ) {
                    ok[i]++;
                }
                if( 2 <= ok[i] && ng[i] < 2 ) {
                    level = System.Math.Min( level, i );
                }
            }
        }
        WriteLine( lvl[level] );
        return;
    }
}
