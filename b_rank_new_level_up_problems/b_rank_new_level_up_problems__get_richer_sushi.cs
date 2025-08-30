// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0] * 2];

        foreach( int i in Range( 0, n[0] ) ) {
            int p = int.Parse( ReadLine() );

            a[i] = p;
            a[i + n[0]] = p;
        }
        foreach( int i in Range( 0, n[0] ) ) {
            int p = 0;

            foreach( int j in Range( i, n[1] ) ) {
                p += a[j];
            }
            o = System.Math.Max( o, p );
        }
        WriteLine( o );
        return;
    }
}
