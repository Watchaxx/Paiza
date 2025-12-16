// 実行時間 20ms
using System.Linq;
using static System.Console;

class Program
{
    static void Main()
    {
        int c = 6;
        int[] a = ReadLine().Split().Append( ReadLine() ).Select( int.Parse ).ToArray();

        while( 0 < c ) {
            int p = ( c - 1 ) / 2;

            if( a[c] < a[p] ) {
                int t = a[p];

                a[p] = a[c];
                a[c] = t;
                c = p;
            } else {
                break;
            }
        }
        WriteLine( string.Join( " ", a ) );
        return;
    }
}
