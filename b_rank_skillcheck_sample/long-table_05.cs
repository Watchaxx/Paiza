// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int _ in Range( 0, nm[1] ) ) {
            int[] ab = ReadLine().Split().Select( int.Parse ).ToArray();
            var l = new System.Collections.Generic.List<int>( ab[0] );

            foreach( int i in Range( ab[1], ab[0] ) ) {
                l.Add( nm[0] < i ? i - nm[0] : i );
            }
            WriteLine( string.Join( " ", l ) );
        }
        return;
    }
}
