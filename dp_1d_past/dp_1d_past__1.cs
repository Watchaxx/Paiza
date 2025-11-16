// 実行時間 70ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = new int[n];
        int[] d = Repeat( 100001, n ).ToArray();
        var s = new System.Collections.Generic.Dictionary<int, int>();

        foreach( int i in Range( 0, n ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        d[0] = 0;
        s[a[0]] = 0;
        foreach( int i in Range( 1, n - 1 ) ) {
            if( s.ContainsKey( a[i] ) != true ) {
                s[a[i]] = i;
            }
            d[i] = Min( d[i - 1], s[a[i]] ) + 1;
            s[a[i]] = Min( s[a[i]], d[i] );
        }
        WriteLine( d[n - 1] );
        return;
    }
}
