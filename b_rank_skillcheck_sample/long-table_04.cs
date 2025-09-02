// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        var l = new System.Collections.Generic.List<int>( a[0] );

        foreach( int i in Range( a[1], a[0] ) ) {
            l.Add( n < i ? i - n : i );
        }
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
