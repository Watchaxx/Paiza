// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = new int[n];

        foreach( int i in Range( 0, n ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        WriteLine( GcdM( a, n ) );
        return;
    }

    static int GcdM( int[] a, int n )
    {
        int o = a[0];

        foreach( int i in Range( 1, n - 1 ) ) {
            o = Gcd( o, a[i] );
        }
        return o;
    }

    static int Gcd( int a, int b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
