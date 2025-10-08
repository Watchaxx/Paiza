// 実行時間 240ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;
using Tpl = System.Tuple<int, int, int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        Tpl[] t = new Tpl[n];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n ) ) {
            int[] yx = ReadLine().Split().Select( int.Parse ).ToArray();

            t[i] = new Tpl( yx[0], yx[1], Abs( yx[0] ) + Abs( yx[1] ) );
        }
        foreach( Tpl p in t.OrderBy( x => x.Item3 ) ) {
            WriteLine( $"{p.Item1} {p.Item2}" );
        }
        Out.Flush();
        return;
    }
}
