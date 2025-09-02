// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[] s = new bool[nm[0]];

        foreach( int _ in Range( 0, nm[1] ) ) {
            bool b = false;
            int[] ab = ReadLine().Split().Select( int.Parse ).ToArray();

            foreach( int i in Range( ab[1], ab[0] ) ) {
                if( s[Round( i, nm[0] )] == true ) {
                    b = true;
                    break;
                }
            }
            if( b == true ) {
                continue;
            }
            foreach( int i in Range( ab[1], ab[0] ) ) {
                s[Round( i, nm[0] )] = true;
            }
        }
        WriteLine( s.Count( x => x ) );
        return;
    }

    static int Round( int a, int n )
    {
        return n < a ? a - n - 1 : a - 1;
    }
}
