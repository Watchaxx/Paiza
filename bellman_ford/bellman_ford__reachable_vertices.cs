// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var s = new System.Collections.Generic.SortedSet<int>();

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            if( a[0] == n[2] ) {
                s.Add( a[1] );
            }
        }
        WriteLine( 0 < s.Count ? string.Join( " ", s ) : "-1" );
        return;
    }
}
