// 実行時間 110ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = new int[n[0] - n[1] + 1];
        int mc = 1;
        int mi = -1;
        int mx = -1;
        int s = a.Take( n[1] ).Sum();
        var l = new System.Collections.Generic.List<int>( a.Skip( n[1] ) );

        foreach( int i in Range( 0, l.Count ) ) {
            l[i] -= a[i];
            b[i + 1] = b[i] + l[i];
        }
        foreach( int i in Range( 0, b.Length ) ) {
            b[i] += s;
            if( mx < b[i] ) {
                mc = 1;
                mi = i + 1;
                mx = b[i];
            } else if( mx == b[i] ) {
                mc++;
            }
        }
        WriteLine( $"{mc} {mi}" );
        return;
    }
}
