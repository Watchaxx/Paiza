// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        bool[] b = new bool[50];
        int o = 0;
        int r = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] c = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int l in Range( 0, n[0] ) ) {
            while( r < n[0] && b[c[r]] != true ) {
                b[c[r]] = true;
                r++;
            }
            o = System.Math.Max( o, r - l );
            if( l == r ) {
                r++;
            } else {
                b[c[l]] = false;
            }
        }
        WriteLine( o );
        return;
    }
}
