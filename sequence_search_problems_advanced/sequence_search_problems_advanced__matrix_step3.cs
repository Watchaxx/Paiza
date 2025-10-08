// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[n[0]][];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n[0] - n[2] + 1 ) ) {
            foreach( int j in Range( 0, n[1] - n[2] + 1 ) ) {
                int t = 0;

                foreach( int k in Range( i, n[2] ) ) {
                    t += a[k].Skip( j ).Take( n[2] ).Sum();
                }
                o = System.Math.Max( o, t );
            }
        }
        WriteLine( o );
        return;
    }
}
