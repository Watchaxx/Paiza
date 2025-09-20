// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nkr = ReadLine().Split().Select( int.Parse ).ToArray();
        var s = new System.Collections.Generic.SortedSet<int> { nkr[2] };

        foreach( int _ in Range( 0, nkr[0] - 1 ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            s.Add( a[0] );
            s.Add( a[1] );
        }
        foreach( int _ in Range( 0, nkr[1] ) ) {
            WriteLine( s.Contains( int.Parse( ReadLine() ) ) ? "Yes" : "No" );
        }
        return;
    }
}
