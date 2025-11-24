// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        bool b = true;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] r = new int[n[2] + 1];

        r[0] = n[1];
        foreach( int i in Range( 1, n[2] ) ) {
            if( b == true ) {
                if( r[i - 1] + 1 <= n[0] ) {
                    r[i] = r[i - 1] + 1;
                } else {
                    b = false;
                    r[i] = r[i - 1] - 1;
                }
            } else {
                if( 0 < r[i - 1] - 1 ) {
                    r[i] = r[i - 1] - 1;
                } else {
                    b = true;
                    r[i] = r[i - 1] + 1;
                }
            }
        }
        WriteLine( string.Join( " ", r ) );
        return;
    }
}
