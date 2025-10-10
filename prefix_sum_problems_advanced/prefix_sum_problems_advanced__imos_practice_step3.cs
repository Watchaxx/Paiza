// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int mi = 0;
        int mm = 0;
        int[] q = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[1001];
        int[] b;

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, q[0] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[t[0] - 1] += t[2];
            a[t[1]] -= t[2];
            mi = System.Math.Max( mi, t[1] );
        }
        b = new int[mi + 1];
        foreach( int i in Range( 0, mi ) ) {
            b[i + 1] = b[i] + a[i];
            mm = System.Math.Max( mm, b[i + 1] );
        }
        foreach( int i in Range( 0, mi + 1 ).Where( x => b[x] == mm ) ) {
            WriteLine( i );
        }
        Out.Flush();
        return;
    }
}
