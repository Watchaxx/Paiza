// 実行時間 70ms
using System.Linq;
using static System.Console;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Append( ReadLine() ).Select( int.Parse ).ToArray();

        while( 0 < n ) {
            int p = ( n - 1 ) / 2;

            if( a[n] < a[p] ) {
                int t = a[p];

                a[p] = a[n];
                a[n] = t;
                n = p;
            } else {
                break;
            }
        }
        WriteLine( string.Join( " ", a ) );
        return;
    }
}
