// 実行時間 240ms
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        Tpl[] a = new Tpl[n];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[i] = new Tpl( t[0], t[1] );
        }
        foreach( Tpl p in a.OrderBy( x => x.Item1 ).ThenBy( x => x.Item2 ) ) {
            WriteLine( $"{p.Item1} {p.Item2}" );
        }
        Out.Flush();
        return;
    }
}
