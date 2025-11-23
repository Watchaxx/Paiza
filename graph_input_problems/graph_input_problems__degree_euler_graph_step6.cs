// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] li = new int[n[0]];
        int[] lo = new int[n[0]];

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            li[t[1]]++;
            lo[t[0]]++;
        }
        WriteLine( string.Join( " ", li ) );
        WriteLine( string.Join( " ", lo ) );
        return;
    }
}
