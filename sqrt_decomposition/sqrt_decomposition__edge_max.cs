// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0]];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int o = int.MinValue;

            foreach( int i in Range( 0, int.Parse( ReadLine() ) ) ) {
                o = System.Math.Max( o, a[i] );
            }
            WriteLine( o );
        }
        return;
    }
}
