// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;
using Tpl = System.Tuple<double, int>;

internal class Program
{
    static void Main()
    {
        int[] p = ReadLine().Split().Select( int.Parse ).ToArray();
        int n = int.Parse( ReadLine() );
        Tpl[] d1 = new Tpl[n];
        Tpl[] d2 = new Tpl[n];

        foreach( int i in Range( 0, n ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            d1[i] = new Tpl( Sqrt( Pow( p[0] - t[0], 2 ) + Pow( p[1] - t[1], 2 ) ), i + 1 );
            d2[i] = new Tpl( Abs( p[0] - t[0] ) + Abs( p[1] - t[1] ), i + 1 );
        }
        foreach( Tpl i in d1.OrderBy( x => x.Item1 ).ThenBy( x => x.Item2 ).Take( 3 ) ) {
            WriteLine( i.Item2 );
        }
        foreach( Tpl i in d2.OrderBy( x => x.Item1 ).ThenBy( x => x.Item2 ).Take( 3 ) ) {
            WriteLine( i.Item2 );
        }
        return;
    }
}
