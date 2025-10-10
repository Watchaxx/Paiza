// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const int l = 1001;
        int q = int.Parse( ReadLine() );
        int[] a = new int[l];
        int[] b = new int[l + 1];

        foreach( int i in Range( 1, l - 1 ).Where( x => x % 15 == 0 ) ) {
            a[i] = 1;
        }
        foreach( int i in Range( 0, l ) ) {
            b[i + 1] = b[i] + a[i];
        }
        foreach( int _ in Range( 0, q ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            WriteLine( b[t[1] + 1] - b[t[0]] );
        }
        return;
    }
}
