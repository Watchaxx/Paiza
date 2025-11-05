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
        foreach( int i in Range( 0, n[0] / n[1] ) ) {
            WriteLine( a.Skip( n[1] * i ).Take( n[1] ).Max() );
        }
        return;
    }
}
