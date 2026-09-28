// 実行時間 120ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] tn = ReadLine().Split().Select( int.Parse ).ToArray();
        uint o = 0;
        uint[] a = new uint[tn[1] + 1];

        foreach( int i in Range( 1, tn[1] ) ) {
            uint m = uint.Parse( ReadLine() );

            a[i] = a[i - 1] + m;
            if( i <= tn[0] ) {
                o += m;
            }
        }
        foreach( int i in Range( tn[0] + 1, tn[1] - tn[0] ) ) {
            o = System.Math.Max( o, a[i] - a[i - tn[0]] );
        }
        WriteLine( o );
        return;
    }
}
