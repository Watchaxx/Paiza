// 実行時間 350ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int k = int.Parse( ReadLine() );
        int[] h = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in h ) {
            int m = 0;

            for( int j = i; j < n; j++ ) {
                int x = a[j];
                int l = j - i;

                while( 0 <= l && x < a[l] ) {
                    a[l + i] = a[l];
                    l -= i;
                    m++;
                }
                a[l + i] = x;
            }
            WriteLine( m );
        }
        return;
    }
}
